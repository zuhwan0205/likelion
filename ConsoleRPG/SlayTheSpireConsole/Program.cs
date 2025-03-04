using System;
using System.Collections.Generic;

namespace SlayTheSpireConsole
{
    // 카드 클래스: 카드 이름, 데미지, 코스트 정보를 가짐
    // 단, "Shield" 카드의 경우 데미지 대신 플레이어 쉴드를 증가시키는 효과를 가집니다.
    class Card
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Cost { get; set; }

        public Card(string name, int damage, int cost)
        {
            Name = name;
            Damage = damage;
            Cost = cost;
        }

        // 플레이어와 적을 모두 전달하여 카드 효과를 적용
        public void Play(Player player, Enemy enemy)
        {
            if (Name.Equals("Shield", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{Name} 카드 사용! {player.Name}의 쉴드가 5 증가합니다. (코스트: {Cost})");
                player.AddShield(5);
            }
            else
            {
                Console.WriteLine($"{Name} 카드 사용! {enemy.Name}에게 {Damage}의 피해를 입혔습니다. (코스트: {Cost})");
                enemy.TakeDamage(Damage);
            }
        }
    }

    // 플레이어 클래스: 체력, 덱, 손패, 버림(Discard) 더미, 쉴드 관리
    class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Shield { get; set; }
        public List<Card> Deck { get; set; }
        public List<Card> Hand { get; set; }
        public List<Card> DiscardPile { get; set; }

        public Player(string name, int health)
        {
            Name = name;
            Health = health;
            Shield = 0;
            Deck = new List<Card>();
            Hand = new List<Card>();
            DiscardPile = new List<Card>();
        }

        // 덱에 카드 추가
        public void AddCard(Card card)
        {
            Deck.Add(card);
        }

        // 쉴드 추가 메서드
        public void AddShield(int amount)
        {
            Shield += amount;
            Console.WriteLine($"{Name}의 쉴드: {Shield}");
        }

        // 덱에서 손패로 카드 뽑기 (count 장)
        // 덱에 카드가 부족하면 DiscardPile을 섞어 덱으로 합칩니다.
        public void DrawCards(int count)
        {
            Hand.Clear();
            if (Deck.Count < count && DiscardPile.Count > 0)
            {
                Console.WriteLine("덱에 카드가 부족합니다. 버린 카드를 섞어 덱으로 가져옵니다.");
                Deck.AddRange(DiscardPile);
                DiscardPile.Clear();
                // 덱 섞기 (Fisher-Yates shuffle)
                Random rng = new Random();
                int n = Deck.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    Card temp = Deck[k];
                    Deck[k] = Deck[n];
                    Deck[n] = temp;
                }
            }
            int drawCount = Math.Min(count, Deck.Count);
            for (int i = 0; i < drawCount; i++)
            {
                Hand.Add(Deck[i]);
            }
            Deck.RemoveRange(0, drawCount);
        }

        // 플레이어 턴: 최대 3 코스트 사용, 남은 카드가 있다면 계속 카드 선택 가능
        public void PlayerTurn(Enemy enemy)
        {
            int totalCost = 3;
            int usedCost = 0;

            // 매 턴마다 5장의 카드를 뽑음
            DrawCards(5);

            while (usedCost < totalCost && Hand.Count > 0)
            {
                Console.WriteLine($"\n남은 사용 가능 코스트: {totalCost - usedCost}");
                Console.WriteLine("현재 손패:");
                for (int i = 0; i < Hand.Count; i++)
                {
                    Card c = Hand[i];
                    Console.WriteLine($"{i + 1}. {c.Name} (데미지: {c.Damage}, 코스트: {c.Cost})");
                }
                Console.Write("사용할 카드 번호를 선택하세요 (턴 종료는 0 입력): ");
                string input = Console.ReadLine();
                int choice;
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("올바른 숫자를 입력하세요.");
                    continue;
                }
                if (choice == 0)
                {
                    Console.WriteLine("턴을 종료합니다.");
                    break;
                }
                if (choice < 1 || choice > Hand.Count)
                {
                    Console.WriteLine("유효하지 않은 카드 번호입니다.");
                    continue;
                }
                Card selected = Hand[choice - 1];

                // 선택한 카드의 코스트 검사
                if (usedCost + selected.Cost > totalCost)
                {
                    Console.WriteLine("해당 카드를 사용할 수 있는 코스트가 부족합니다.");
                    continue;
                }

                // 카드 사용: 플레이어와 적 모두 전달
                selected.Play(this, enemy);
                usedCost += selected.Cost;
                // 사용한 카드는 버림 더미로 이동
                DiscardPile.Add(selected);
                Hand.RemoveAt(choice - 1);

                if (enemy.Health <= 0)
                {
                    break;
                }
            }
        }

        // 데미지 받기 시 Shield를 우선 소모하여 데미지 감소
        public void TakeDamage(int damage)
        {
            int blocked = Math.Min(Shield, damage);
            Shield -= blocked;
            damage -= blocked;
            if (blocked > 0)
            {
                Console.WriteLine($"{Name}의 쉴드가 {blocked}의 피해를 막았습니다. 남은 쉴드: {Shield}");
            }
            if (damage > 0)
            {
                Health -= damage;
                Console.WriteLine($"{Name}이(가) {damage}의 피해를 받았습니다. 남은 체력: {Health}");
            }
            else if (damage == 0)
            {
                Console.WriteLine($"{Name}은(는) 체력 피해를 받지 않았습니다.");
            }
        }
    }

    // 적 클래스: 체력과 공격 기능을 포함
    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Enemy(string name, int health)
        {
            Name = name;
            Health = health;
        }

        // 적의 공격 (고정 데미지: 5)
        public void Attack(Player player)
        {
            int damage = 5;
            Console.WriteLine($"{Name}의 공격! {player.Name}에게 {damage}의 피해!");
            player.TakeDamage(damage);
        }

        // 적이 데미지를 받을 때 처리
        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name}이(가) {damage}의 피해를 입었습니다. 남은 체력: {Health}");
        }
    }

    // 메인 프로그램: 전투 루프를 구현
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("슬레이 더 스파이어 콘솔 게임 시작!");

            // 플레이어와 적 생성
            Player player = new Player("플레이어", 30);
            Enemy enemy = new Enemy("적", 20);

            // 덱에 카드 추가 (카드 이름, 데미지, 코스트)
            // 공격 카드
            player.AddCard(new Card("Strike", 6, 1));
            player.AddCard(new Card("Strike", 6, 1));
            player.AddCard(new Card("Bash", 8, 2));
            player.AddCard(new Card("Heavy Strike", 10, 3));
            player.AddCard(new Card("Quick Slash", 4, 1));
            player.AddCard(new Card("Cleave", 7, 2));
            // 쉴드 카드 5장 추가 (데미지는 0, 사용 시 쉴드 5 증가)
            player.AddCard(new Card("Shield", 0, 1));
            player.AddCard(new Card("Shield", 0, 1));
            player.AddCard(new Card("Shield", 0, 1));
            player.AddCard(new Card("Shield", 0, 1));
            player.AddCard(new Card("Shield", 0, 1));

            // 전투 루프
            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("\n=== 플레이어 턴 ===");
                // 턴 시작 시 코스트는 3으로 리셋되고 쉴드 유지
                player.PlayerTurn(enemy);

                if (enemy.Health <= 0)
                {
                    Console.WriteLine("적을 물리쳤습니다!");
                    break;
                }

                Console.WriteLine("\n=== 적 턴 ===");
                enemy.Attack(player);

                if (player.Health <= 0)
                {
                    Console.WriteLine("플레이어가 패배했습니다!");
                    break;
                }
            }

            Console.WriteLine("게임 종료!");
        }
    }
}
