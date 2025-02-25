//switch 문
// int day = 1;
//
// switch (day)
// {
//     case 1:
//         Console.WriteLine("월");
//         break;
//     case 2:
//         Console.WriteLine("화");
//         break;
//     case 3:
//         Console.WriteLine("수");
//         break;
//     case 4:
//         Console.WriteLine("목");
//         break;
//     case 5:
//         Console.WriteLine("금");
//         break;
//     case 6:
//         Console.WriteLine("토");
//         break;
//     case 7:
//         Console.WriteLine("일");
//         break;
// }

// string cha = Console.ReadLine();
// switch (cha)
// {
//     case "검사":
//         Console.WriteLine($"캐릭터: {cha}공격력: 100 \n 방어력: 90");
//         break;
//     case "법사":
//         Console.WriteLine($"캐릭터: {cha}공격력: 110 \n 방어력: 80");
//         break;
//     case "도적":
//         Console.WriteLine($"캐릭터: {cha}공격력: 120 \n 방어력: 70");
//         break;
// }

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine($"{i+1}");
// }
// //무한반복
// for (;;)
// {
//     Console.WriteLine("무한 반복");
// }
// //1~10 합 구하기
// int result = 0;
// for (int i = 0; i < 11; i++)
// {
//     result += i;
// }
// Console.WriteLine(result);
// int count = 1; //초기화
//
// while(count <= 5) //조건식
// {
//     Console.WriteLine("Count : " + count);
//
//     count++; //증가,감소
//
//     if(count == 3)
//     {
//         Console.WriteLine("3일때 반복문 탈출");
//         break;
//     }
//
// }
//
//
// Console.WriteLine("Count : " + count); 

//랜덤
// Random rand  = new Random(); //Ramdom 객체 생성
//
// int rannum = rand.Next(0, 100); //0~99 중 하나의 정수 뽑아냄
// float rannum2 = rand.Next(0, 100); //0~99 중 하나의 실수를 뽑아냄
// Console.WriteLine(rannum);

//대장장이 키우기
// Random rand  = new Random();
// int number = rand.Next(0, 100);
// if (number <= 10)
// {
//     Console.WriteLine($"{number}확률로 SSS 등급 도끼 획득");
// }
// else if (number > 10 && number <= 50)
// {
//     Console.WriteLine($"{number}확률로 SS 등급 도끼 획득");
// }
// else
// {
//     Console.WriteLine($"{number}확률로 S 등급 도끼 획득");
// }

//do while문
// int x= 5;
// do
// {
//     Console.WriteLine("최소 한 번은 실행됩니다");
//     x--;
// } while (x > 0);

// //break문 : 반복문 탈출
// for (int i = 0; i < 10; i++)
// {
//     if (i == 5)
//     {
//         break;
//     }
//     
//     Console.WriteLine(i);
// }

//continue
//현재 반복문을 건너뜀
// for (int i = 0; i < 10; i++)
// {
//     if (i %2 ==0)
//     {
//         continue;
//     }
//     
//     Console.WriteLine(i); //홀수만 출력
// }

//goto : 이중 for문을 한 번에 탈출 할 때 한 번씩 사용 하지만 거의 사용하지 않는게 좋음

// int n=1;
//
// Start:
// if (n <= 5)
// {
//     Console.WriteLine(n);
//     n++;
//     
//     goto Start;
// }
//
// Console.WriteLine("게임 시작 = 1");
// int gamestart = int.Parse(Console.ReadLine());
// Random rand = new Random();
// int wood = 0;
// int endwood = 0;
// int number = 0;
// int endgame = 0;
// while (gamestart == 1)
// {
//     Console.WriteLine("무기를 뽑기 위해 나무를 하러 가자 나무 10개 당 뽑기 1번 \n 나무를 그만 하려면 1번");
//     while(wood < 100)
//     {
//         wood += rand.Next(1, 10);
//         Thread.Sleep(1000);
//         Console.WriteLine($"나무: {wood}개");
//         
//     }
//     Console.WriteLine("무기 뽑기 시작 더 못 뽑을 때 까지 뽑습니다.");
//     while(wood > 9)
//     {
//         number = rand.Next(0, 100);
//         if (number <= 10) 
//         {
//             Console.WriteLine($"{number}확률로 SSS 등급 도끼 획득");
//             wood -= 10;
//         }
//         else if (number > 10 && number <= 40)
//         {
//             Console.WriteLine($"{number}확률로 SS 등급 도끼 획득"); 
//             wood -= 10;
//         }
//         else
//         {
//             Console.WriteLine($"{number}확률로 S 등급 도끼 획득");
//             wood -= 10;
//         }
//         Thread.Sleep(1000);
//     }
//}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



// Random rand = new Random();
//
// Console.OutputEncoding = System.Text.Encoding.UTF8;
//
// //멋사 4기는 능력이 사기다
// int gold = 500;
// int health = 100;
// int power = 10;
// int input;
// bool isAlive = true;
//
// Console.WriteLine(" ⚔️ 모험가 키우기 ⚔️ ");
// Thread.Sleep(1000);
//
// while(isAlive)
// {
//     Console.Clear();
//     Console.WriteLine($" 현재 상태: 체력 {health} | 골드 {gold} | 공격력 {power}");
//     Console.WriteLine("\n1. 탐험하기 🏕️");
//     Console.WriteLine("2. 장비 뽑기 🎲 (1000골드)");
//     Console.WriteLine("3. 휴식하기 💤 (체력 +20");
//     Console.WriteLine("4. 게임 종료 ");
//     Console.Write("입력: ");
//
//     input = int.Parse(Console.ReadLine());
//     
//
//     if(input == 1)  //탐험하기
//     {
//         Console.Clear();
//         Console.WriteLine(" 탐험을 떠납니다.");
//         Thread.Sleep(500);
//         Console.WriteLine(" 탐험을 떠납니다..");
//         Thread.Sleep(500);
//         Console.WriteLine(" 탐험을 떠납니다...");
//         Thread.Sleep(500);
//         Console.WriteLine(" 탐험을 떠납니다....");
//
//         int eventChance = rand.Next(1, 101); //1~100 랜덤 이벤트 발생
//
//
//         if(eventChance <= 30) //30%확률로 전투 발생
//         {
//             int damage = rand.Next(5, 21);
//             Console.WriteLine($"⚔️ 몬스터를 만났습니다! (체력 -{damage}");
//             health -= damage;
//
//             Console.Write("┏┯┯┯┯┯┓\r\n┃││∧ ∧│┃살려줘!!\r\n┃│  (≧Д≦)  ┃\r\n┃││ф  ф│┃\r\n┗┷┷┷┷┷┛\r\n");
//             Thread.Sleep(1000);
//
//
//         }
//         else if(eventChance <= 70)  //40%확률로 보상
//         {
//             int reward = rand.Next(100, 301); //100~300골드
//             Console.WriteLine($"💰 보물을 발견했습니다! (+{reward} 골드)");
//             gold += reward;
//         }
//         else //30$확률로 회복
//         {
//             int heal = rand.Next(10, 31); //10~30 체력 회복
//             Console.WriteLine($"🌿 신비한 약초를 발견했습니다! (+{heal} 체력)");
//             health += heal; 
//         }
//
//         if(health <= 0)
//         {
//             Console.WriteLine("\n 💀체력이 0이 되어 사망했습니다... 게임 오버!");
//             isAlive = false;
//         }
//
//         Thread.Sleep(1000);
//     }
//     else if( input == 2) //장비 뽑기
//     {
//         if(gold >= 1000)
//         {
//             gold -= 1000;
//             Console.Clear();
//             Console.WriteLine("🎲 장비를 뽑습니다...");
//             Thread.Sleep(1000);
//
//             int rnd = rand.Next(1, 101); //1~100랜덤
//
//             if(rnd == 1)
//             {
//                 Console.WriteLine("SSS급 전설의 검 (공격력 +50) 획득!");
//                 power += 50;
//             }
//             else if(rnd <= 10)
//             {
//                 Console.WriteLine("SS급 희귀한 검 (공격력 +30) 획득!");
//                 power += 30;
//             }
//             else if(rnd <= 30)
//             {
//                 Console.WriteLine("S급 강철 검 (공격력 +20) 획득!");
//                 power += 20;
//             }
//             else 
//             {
//                 Console.WriteLine("녹슨칼 (공격력 +5) 획득!");
//                 power += 5;
//             }
//             Thread.Sleep(5000);
//         }
//         else
//         {
//             Console.WriteLine("골드가 부족합니다. (1000 골드 필요) ");
//             Thread.Sleep(1000);
//         }
//     }
//     else if(input == 3) //휴식하기
//     {
//         Console.WriteLine("휴식을 취합니다...(+20 체력)");
//         health += 20;
//         Thread.Sleep(1000);
//     }
//     else if (input == 4) //휴식하기
//     {
//         Console.WriteLine("게임을 종료합니다.");
//         Environment.Exit(1);
//     }
//     else
//     {
//         Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
//         Thread.Sleep(1000);
//     }
//                 
// }           

Console.SetCursorPosition(0, 0);
Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
Console.SetCursorPosition(0, 1);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 2);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 3);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 4);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 4);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 5);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 6);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 7);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 8);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 9);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 10);
Console.Write("┃                               대장장이 키우기                                  ┃");
Console.SetCursorPosition(0, 11);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 12);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 13);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 14);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 15);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 16);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 17);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 18);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 19);
Console.Write("┃                                                                              ┃");
Console.SetCursorPosition(0, 20);
Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

Thread.Sleep(3000);

Console.Clear();

int total = 50; // 로딩바의 길이
Console.Write("Loading: [");
        
for (int i = 0; i <= total; i++)
{
    Console.Write("#"); 
    Thread.Sleep(50); 
}
        
Console.WriteLine("] Done!");
Console.Clear();
Console.OutputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("게임시작");
        int level = 1;
        string weapon = "나무검";
        int HP = 100;
        int gold = 0;
        int input;
        int percent;
        Random random = new Random();

        while (true)
        {
            Console.WriteLine($"\n현재 상태: 레벨 {level}, HP {HP}, 골드 {gold}, 무기: {weapon}\n");
            Console.WriteLine("1. 사냥터");
            Console.WriteLine("2. 무기 강화");
            Console.WriteLine("3. 수련");
            Console.WriteLine("4. 체력 회복");
            Console.WriteLine("5. 나가기");
            Console.Write("\n입력: ");
            
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("숫자로 입력해주세요.");
                continue;
            }

            switch (input)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("사냥터에 진입했습니다.");
                    Console.WriteLine("몬스터를 만날 수도, 무기 상자를 발견할 수도 있습니다.");
                    // 1~100 중 10 이하이면 무기 상자, 그 외엔 몬스터
                    percent = random.Next(1, 101);
                    if (percent <= 10)
                    {
                        Console.Clear();
                        Console.WriteLine("무기 상자 발견!");
                        Console.WriteLine("미니게임: 1부터 3 사이의 숫자를 맞춰보세요. 정답이면 강력한 무기를 얻습니다.");
                        int answer = random.Next(1, 4);
                        Console.Write("숫자 입력: ");
                        if (int.TryParse(Console.ReadLine(), out int guess))
                        {
                            if (guess == answer)
                            {
                                Console.WriteLine("정답입니다! 새로운 무기를 획득했습니다.");
                                weapon = "강력한 검";
                            }
                            else
                            {
                                Console.WriteLine($"오답입니다. 정답은 {answer}였습니다. 무기를 획득하지 못했습니다.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("입력 오류로 미니게임을 종료합니다.");
                        }
                        Console.WriteLine("엔터를 눌러 계속...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        // 전투 시작: 몬스터와 전투는 플레이어나 몬스터가 죽을 때까지 반복
                        int monsterHP = 30;
                        Console.Clear();
                        Console.WriteLine("몬스터와 전투를 시작합니다!");
                        while (HP > 0 && monsterHP > 0)
                        {
                            Console.WriteLine($"\n당신의 HP: {HP} / 몬스터의 HP: {monsterHP}");
                            Console.WriteLine("공격하려면 1, 도망가려면 2를 입력하세요.");
                            if (!int.TryParse(Console.ReadLine(), out int battleChoice))
                            {
                                Console.WriteLine("숫자로 입력해주세요.");
                                continue;
                            }
                            if (battleChoice == 1)
                            {
                                // 전투 라운드 진행: 선공 결정
                                percent = random.Next(1, 3); // 1 또는 2
                                if (percent == 1)
                                {
                                    Console.WriteLine("당신의 선제 공격!");
                                    // 플레이어 공격: (여기서는 간단히 15의 피해)
                                    monsterHP -= 15;
                                    Console.WriteLine("몬스터에게 15의 피해를 입혔습니다.");
                                    if (monsterHP <= 0)
                                        break;
                                    // 몬스터의 반격
                                    Console.WriteLine("몬스터의 반격!");
                                    HP -= 20;
                                    Console.WriteLine("몬스터에게 20의 피해를 받았습니다.");
                                }
                                else
                                {
                                    Console.WriteLine("몬스터의 선제 공격!");
                                    HP -= 10;
                                    Console.WriteLine("몬스터에게 10의 피해를 받았습니다.");
                                    if (HP <= 0)
                                        break;
                                    Console.WriteLine("당신의 반격!");
                                    monsterHP -= 15;
                                    Console.WriteLine("몬스터에게 15의 피해를 입혔습니다.");
                                }
                            }
                            else if (battleChoice == 2)
                            {
                                Console.WriteLine("도망가기를 선택했습니다.");
                                // 도망가면 전투 종료 (도망가는 도중 약간의 페널티)
                                HP -= 10;
                                Console.WriteLine("도망치는 도중 몬스터에게 10의 피해를 받았습니다.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("잘못된 선택입니다.");
                            }
                        }
                        // 전투 종료 후 결과 처리
                        if (HP <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("HP가 0이 되어 당신은 사망했습니다. 게임 오버!");
                            return;
                        }
                        else if (monsterHP <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("몬스터를 처치했습니다! 골드 +100, 레벨업!");
                            gold += 100;
                            level++;
                        }
                        else
                        {
                            Console.WriteLine("전투를 중단했습니다.");
                        }
                        Console.WriteLine("엔터를 눌러 계속...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("무기 강화를 시도합니다...");
                    gold -= 30;
                    percent = random.Next(1, 101);
                    if (percent <= 50 && gold > 0)
                    {
                        Console.WriteLine("무기 강화 성공! 무기가 더욱 강력해졌습니다.");
                        if (!weapon.StartsWith("강화된"))
                            weapon = "강화된 " + weapon;
                        else
                            weapon += "★";
                    }
                    else
                    {
                        Console.WriteLine("무기 강화 실패!");
                    }
                    Console.WriteLine("엔터를 눌러 계속...");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("수련 중...");
                    HP += 20;
                    Console.WriteLine("수련 완료! HP가 20 증가했습니다.");
                    Console.WriteLine($"현재 HP: {HP}");
                    Console.WriteLine("엔터를 눌러 계속...");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 4:
                    // 체력 회복: 골드 300원을 사용해 HP 회복
                    Console.Clear();
                    Console.WriteLine("1. 골드 300원을 사용해 체력 회복");
                    Console.WriteLine("2. 나가기");
                    Console.Write("\n선택: ");
                    if (!int.TryParse(Console.ReadLine(), out int recoveryChoice))
                    {
                        Console.WriteLine("숫자로 입력해주세요.");
                        break;
                    }
                    if (recoveryChoice == 1)
                    {
                        if (gold >= 300)
                        {
                            gold -= 300;
                            // 예를 들어 HP를 50 회복
                            HP += 50;
                            Console.WriteLine("체력이 50 회복되었습니다!");
                        }
                        else
                        {
                            Console.WriteLine("골드가 부족합니다.");
                        }
                    }
                    else if (recoveryChoice == 2)
                    {
                        Console.WriteLine("체력 회복 메뉴를 종료합니다.");
                    }
                    else
                    {
                        Console.WriteLine("잘못된 선택입니다.");
                    }
                    Console.WriteLine("엔터를 눌러 계속...");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("게임을 종료합니다. 플레이해주셔서 감사합니다!");
                    return;

                default:
                    Console.WriteLine("잘못된 입력입니다. 1 ~ 5 사이의 숫자를 입력해주세요.");
                    break;
            }
        }