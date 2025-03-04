// // See https://aka.ms/new-console-template for more information
//
// //1. 매개 변수도 반환 값도 없는 함수
//
// using System.Drawing;
//
// static void PrintHello()
// {
//     Console.WriteLine("Hello");
// }
//
// PrintHello();
//
// //2. 매개변수만 있는 함수
// static void SayHello(string message)
// {
//     Console.WriteLine(message);
// }
//
// SayHello("hello");
//
// //3. 반환값만 있는 함수
//
// static int Getnum()
// {
//     return 3;
// }
//
// int num = Getnum();
// Console.WriteLine(num);
//
// //4.매개변수와 반환값이 있는 함수
// static int Add(int x, int y)
// {
//     return x + y;
// }
//
// int result = Add(1, 2);
// Console.WriteLine(result);
//
// //5. 기본 값을 가진 매개 변수(디폴트 매개변수)
// static void Greet(string name = "손님")
// {
//     Console.WriteLine($"안녕하세요 {name}");
// }
//
// Greet();
// Greet("철수");
//
// //6. 함수 오버로딩
// // <summary>
// // 두수를 곱하는 함수
// // </summary>
// // <param name="a">int,double 오버로딩해놈</param>
// // <param name="b">int,double 오버로딩해놈</param>
// // <returns></returns>
// static int Maltiply(int x, int y)
// {
//     return x * y;
// }
//
// static double Divide2(int x, int y)
// {
//     return x * y;
// }
//
// //7. OUT 키워드 (여러 값을 반환할 때)
// static void Divide(int x, int y, out int quotient, out int remainder)
// {
//     quotient = x / y;
//     remainder = x % y;
// }
//
// int q, r;
// Divide(10,3, out q, out r );
//
// //8. ref 키워드
// static void Increase(ref int num)
// {
//     num += 10;
// }
//
// int value = 5;
// Increase(ref value);
//
// //params 키워드(가변 매개변수)
// static int Sum(params int[] numbers)
// {
//     int total = 0;
//     foreach(int num in numbers)
//     {
//         total += num;
//     }
//     return total;
// }
// Console.WriteLine(Sum(1, 2, 3));   //출력 6
// Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9,10));
//
// //재귀함수(자기자신을 호출)
// static int Factorial(int n)
// {
//     if (n <= 1)
//         return 1;   //출력겸 탈출
//
//     return n * Factorial(n - 1);
// }
// //Factorial(5) = 5 * 4 * 3 * 2 * 1 = 120
// Console.WriteLine(Factorial(5));
//
// //람다 표현식
// //기본
// static int Add2(int x, int y)
// {
//     return x + y;
// }
// //람다
// static int AddArrow(int x, int y) => x + y;
//
// Console.WriteLine(Add2(3, 4));
// Console.WriteLine(AddArrow(3, 4));
//
// //math클래스 사용 수학적 계산
// Console.WriteLine($"Pi: {Math.PI}");
// Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}");
// Console.WriteLine($"Power (2^3): {Math.Pow(2, 3)}");
// Console.WriteLine($"Round(3.75): {Math.Round(3.75)}");
//
// //enum : 열거형
// enum DayOfWeek
// {
//     Monday,
//     Tuesday,
//     Wednesday,
//     Thursday,
//     Friday,
//     Saturday,
//     Sunday,
// }
//
// DayOfWeek today = DayOfWeek.Monday;
// Console.WriteLine(today);
//
// enum StatusCode
// {
//     Success = 200,
//     BadRequest = 400,
//     Unauthorized = 401,
//     NotFound = 404
// }
//
// StatusCode status = StatusCode.Success;
// Console.WriteLine((int)status);
//
// //문제 열거형과 함수를 이용해서 풀어라
// //Weapontype.Sword = 검을 선택했습니다.
//
// static void WeaponPrint(Weapontype weapon)
// {
//     if (weapon == Weapontype.Sword)
//     {
//         Console.WriteLine("검");
//     }
//     else if (weapon == Weapontype.Bow)
//     {
//         Console.WriteLine("활");
//     }
//     else
//     {
//         Console.WriteLine("지팡이");
//     }
// }
// WeaponPrint(Weapontype.Sword);
//
// enum Weapontype
// {
//     Sword, Bow, Staff
// }
//
//
// Point p;
// p.x = 10;
// p.y = 10;
// p.Print();
// struct Point
// {
//     public int x;
//     public int y;
//
//     public void Print()
//     {
//         Console.WriteLine($"x: {x}, y: {y}");
//     }
// }

// var rect = new Rantangle { Width = 5, Height = 5 };
// Console.WriteLine(rect.GetArea());
//
// struct Rantangle()
// {
//     public int Width;
//     public int Height;
//     public int GetArea() => Width * Height;
// }

// Point[] points = new Point[2];
//
// points[0].x = 10;
// points[0].y = 10;
//
// points[1].x = 20;
// points[1].y = 20;
//
// foreach(var point in points)
// {
//     Console.WriteLine($"Point: ({point.x},{point.y})");
// }
//
// struct Point
// {
//     public int x;
//     public int y;
// }
// Stdent[] stdents = new Stdent[3];
// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine("학생 이름 입력");
//     stdents[i].Name = Console.ReadLine();
//     Console.WriteLine("국어: ");
//     stdents[i].Korean = int.Parse(Console.ReadLine());
//     Console.WriteLine("영어: ");
//     stdents[i].English = int.Parse(Console.ReadLine());
//     Console.WriteLine("수학: ");
//     stdents[i].Math = int.Parse(Console.ReadLine());
// }
//
// foreach (Stdent std in stdents)
// {
//     std.Print();
// }
// struct Stdent
// {
//     public string Name;
//     public int Korean;
//     public int English;
//     public int Math;
//
//     public void Print()
//     {
//         Console.WriteLine($"{Name,-10} {Korean,5} {English,5} {Math,5}");
//     }
// }
// namespace Inventory
// {
//     class Program
//     {
//         //최대 아이템 개수(배열 크기)
//         const int MAX_ITEMS = 10;
//
//         //아이템 배열 (이름 저장)
//         static string[] itemNames = new string[MAX_ITEMS];
//         static int[] itemCounts = new int[MAX_ITEMS];
//
//
//         //아이템 추가 함수
//         static void AddItem(string name, int count)
//         {
//             for(int i =0; i<MAX_ITEMS; i++)
//             {
//                 if (itemNames[i] == name)  //이미 있는 아이템이면 개수 증가
//                 {
//                     itemCounts[i] += count;
//                     return;
//                 }
//             }
//
//             //빈 슬롯에 새로운 아이템 추가
//             for(int i=0; i<MAX_ITEMS; i++)
//             {
//                 if (itemNames[i] == null)
//                 {
//                     itemNames[i] = name;
//                     itemCounts[i] = count;
//                     return;
//                 }
//             }
//             Console.WriteLine("인벤토리가 가득 찼습니다.");
//
//         }
//
//         //아이템 제거 함수
//         static void RemoveItem(string name, int count)
//         {
//             for (int i =0; i<MAX_ITEMS; i++)
//             {
//                 if (itemNames[i] ==name) //이름하고 같은지
//                 {
//                     if (itemCounts[i] >= count) //개수가 충분하면 차감
//                     {
//                         itemCounts[i] -= count;
//                         if (itemCounts[i]==0) //개수가 0이면 삭제
//                         {
//                             itemNames[i] = null;
//                         }
//                         return;
//                     }
//                     else
//                     {
//                         Console.WriteLine("아이템 개수가 부족합니다!");
//                         return;
//                     }
//                 }
//             }
//
//             Console.WriteLine("아이템을 찾을 수 없습니다!");
//
//         }
//
//
//         //인벤토리 출력 함수
//         static void ShowInventory()
//         {
//             Console.WriteLine("현재 인벤토리 : ");
//             bool isEmpty = true;
//
//             for(int i =0; i<MAX_ITEMS; i++)
//             {
//                 if (itemNames[i] != null)
//                 {
//                     Console.WriteLine($"{itemNames[i]} (x{itemCounts[i]})");
//                     isEmpty = false;
//                 }
//             }
//
//             if(isEmpty)
//             {
//                 Console.WriteLine("인벤토리가 비어 있습니다.");
//             }
//         }
//
//         static void Main(string[] args)
//         {
//             //테스트 : 아이템 추가
//             AddItem("포션", 5);
//             AddItem("칼", 1);
//             AddItem("포션", 3); //포션 개수 추가
//
//             ShowInventory();
//
//             //아이템 사용
//             Console.WriteLine("포션 2개 사용");
//             RemoveItem("포션", 2);
//             ShowInventory();
//
//             //테스트 : 없는 아이템 제거
//             Console.WriteLine("방패 1개 제거 시도");
//             RemoveItem("방패", 1);
//
//             ShowInventory();
//
//
//             //테스트: 모든 포션 제거
//             Console.WriteLine("포션 6개 사용(초과 사용 테스트)");
//             RemoveItem("포션", 6);
//             ShowInventory();
//
//
//         }
//     }
// }

// namespace Inventory
// {
//     struct Inventory
//     {
//         //최대 아이템 개수(배열 크기)
//          const int MAX_ITEMS = 10;
//
//         //아이템 배열 (이름 저장)
//         string[] itemNames;
//         int[] itemCounts;
//
//         //생성자 선언
//         public Inventory(int temp) //매개변수가 없는 생성자 선언은 불가능해서 임시로 넣음
//         {
//             itemNames = new string[MAX_ITEMS]; //필드에서 바로 초기화가 불가능해서 생성자를 만들고 초기화
//             itemCounts = new int[MAX_ITEMS];
//         }
//
//         //아이템 추가 함수
//         public void AddItem(string name, int count)
//         {
//             for (int i = 0; i < MAX_ITEMS; i++)
//             {
//                 if (itemNames[i] == name)  //이미 있는 아이템이면 개수 증가
//                 {
//                     itemCounts[i] += count;
//                     return;
//                 }
//             }
//             //빈 슬롯에 새로운 아이템 추가
//             for (int i = 0; i < MAX_ITEMS; i++)
//             {
//                 if (itemNames[i] == null)
//                 {
//                     itemNames[i] = name;
//                     itemCounts[i] = count;
//                     return;
//                 }
//             }
//             Console.WriteLine("인벤토리가 가득 찼습니다.");
//         }
//
//         //아이템 제거 함수
//         public void RemoveItem(string name, int count)
//         {
//             for (int i = 0; i < MAX_ITEMS; i++)
//             {
//                 if (itemNames[i] == name) //이름하고 같은지
//                 {
//                     if (itemCounts[i] >= count) //개수가 충분하면 차감
//                     {
//                         itemCounts[i] -= count;
//                         if (itemCounts[i] == 0) //개수가 0이면 삭제
//                         {
//                             itemNames[i] = null;
//                         }
//                         return;
//                     }
//                     else
//                     {
//                         Console.WriteLine("아이템 개수가 부족합니다!");
//                         return;
//                     }
//                 }
//             }
//             Console.WriteLine("아이템을 찾을 수 없습니다!");
//         }
//
//
//         //인벤토리 출력 함수
//         public void ShowInventory()
//         {
//             Console.WriteLine("현재 인벤토리 : ");
//             bool isEmpty = true;
//
//             for (int i = 0; i < MAX_ITEMS; i++)
//             {
//                 if (itemNames[i] != null)
//                 {
//                     Console.WriteLine($"{itemNames[i]} (x{itemCounts[i]})");
//                     isEmpty = false;
//                 }
//             }
//             if (isEmpty)
//             {
//                 Console.WriteLine("인벤토리가 비어 있습니다.");
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Inventory iv = new Inventory(1);
//
//             //테스트 : 아이템 추가
//             iv.AddItem("포션", 5);
//             iv.AddItem("칼", 1);
//             iv.AddItem("포션", 3); //포션 개수 추가
//
//             iv.ShowInventory();
//
//             //아이템 사용
//             Console.WriteLine("포션 2개 사용");
//             iv.RemoveItem("포션", 2);
//             iv.ShowInventory();
//
//             //테스트 : 없는 아이템 제거
//             Console.WriteLine("방패 1개 제거 시도");
//             iv.RemoveItem("방패", 1);
//
//             iv.ShowInventory();
//
//
//             //테스트: 모든 포션 제거
//             Console.WriteLine("포션 6개 사용(초과 사용 테스트)");
//             iv.RemoveItem("포션", 6);
//             iv.ShowInventory();
//         }
//     }
// }

using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace ConsoleGame
{
    // 플레이어를 나타내는 구조체
    struct Player
    {
        public int X;
        public int Y;
        public string[] Shape;

        public Player(int x, int y, string[] shape)
        {
            X = x;
            Y = y;
            Shape = shape;
        }

        // 플레이어 이동 처리 함수
        public void Move(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (Y > 0)
                        Y--;
                    break;
                case ConsoleKey.DownArrow:
                    if (Y < Console.WindowHeight - Shape.Length)
                        Y++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (X > 0)
                        X--;
                    break;
                case ConsoleKey.RightArrow:
                    if (X < Console.WindowWidth - GetMaxWidth())
                        X++;
                    break;
            }
        }

        // 플레이어 모양의 최대 폭 계산
        public int GetMaxWidth()
        {
            int max = 0;
            foreach (string line in Shape)
            {
                if (line.Length > max)
                    max = line.Length;
            }
            return max;
        }

        // 플레이어 그리기 함수
        public void Render()
        {
            for (int i = 0; i < Shape.Length; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.Write(Shape[i]);
            }
        }
    }

    // 미사일을 나타내는 구조체
    struct Missile
    {
        public int X;
        public int Y;
        public bool Active;

        public Missile(int x, int y)
        {
            X = x;
            Y = y;
            Active = true;
        }

        // 미사일 이동 (오른쪽으로 진행)
        public void Move()
        {
            X++;
            if (X >= Console.WindowWidth)
                Active = false;
        }

        // 미사일 그리기 ('-' 문자로 표시)
        public void Render()
        {
            if (Active)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write("-");
            }
        }
    }

    // 적(Enemy)을 나타내는 구조체 (오른쪽에서 등장하는 "M" 문자)
    struct Enemy
    {
        public int X;
        public int Y;
        public bool Active;

        public Enemy(int x, int y)
        {
            X = x;
            Y = y;
            Active = true;
        }

        // 적 이동 (왼쪽으로 진행)
        public void Move()
        {
            X--;
            if (X < 0)
                Active = false;
        }

        // 적 그리기
        public void Render()
        {
            if (Active)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write("M");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            // 플레이어 초기화 (배열로 모양 지정)
            Player player = new Player(0, 12, new string[] { "->", ">>>", "->" });

            // 미사일 리스트 초기화
            List<Missile> missiles = new List<Missile>();

            // 적은 오른쪽 끝에서 임의의 세로 위치에서 등장
            Random rnd = new Random();
            Enemy enemy = new Enemy(Console.WindowWidth - 1, rnd.Next(Console.WindowHeight));

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long prevTime = stopwatch.ElapsedMilliseconds;

            while (true)
            {
                long currentTime = stopwatch.ElapsedMilliseconds;
                if (currentTime - prevTime >= 100) // 100밀리초마다 루프 실행
                {
                    Console.Clear();

                    // 키 입력 처리
                    while (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.Escape)
                            return;
                        else if (keyInfo.Key == ConsoleKey.Spacebar)
                        {
                            // 스페이스바를 누를 때마다 미사일 추가 (플레이어의 오른쪽에서 중앙 높이)
                            missiles.Add(new Missile(player.X + player.GetMaxWidth(), player.Y + player.Shape.Length / 2));
                        }
                        else
                        {
                            player.Move(keyInfo.Key);
                        }
                    }

                    // 미사일 업데이트
                    for (int i = 0; i < missiles.Count; i++)
                    {
                        Missile m = missiles[i];
                        if (m.Active)
                        {
                            m.Move();
                            missiles[i] = m; // 구조체 업데이트
                        }
                    }
                    // 비활성 미사일 제거
                    missiles.RemoveAll(m => !m.Active);

                    // 적 업데이트 : 적이 비활성 상태이면 새로운 적 생성
                    if (enemy.Active)
                    {
                        enemy.Move();
                    }
                    else
                    {
                        enemy = new Enemy(Console.WindowWidth - 1, rnd.Next(Console.WindowHeight));
                    }

                    // 미사일과 적 충돌 검사
                    for (int i = 0; i < missiles.Count; i++)
                    {
                        Missile m = missiles[i];
                        if (m.Active && enemy.Active && m.X == enemy.X && m.Y == enemy.Y)
                        {
                            m.Active = false;
                            missiles[i] = m;
                            enemy.Active = false;
                        }
                    }

                    // 오브젝트 렌더링
                    player.Render();
                    foreach (var m in missiles)
                    {
                        if (m.Active)
                            m.Render();
                    }
                    if (enemy.Active)
                        enemy.Render();

                    prevTime = currentTime;
                }
            }
        }
    }
}
