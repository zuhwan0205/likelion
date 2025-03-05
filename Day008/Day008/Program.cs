using System.Collections;
using System.Diagnostics;
using System.Text;
// //프로그램 종료
//
// using System.Diagnostics;
// using System.Text.RegularExpressions;
//
// Console.WriteLine("프로그램 종료");
// Environment.Exit(0);
//
// //path경로
// string path = Environment.GetEnvironmentVariable("PATH");
// Console.WriteLine($"PATH: {path}");
//
// //랜덤 숫자 뽑기
// Random random = new Random();
//
// int randomNumber = random.Next(1, 101); // 1부터 100까지
// Console.WriteLine("랜덤 숫자 : "+randomNumber);
//
// //프로그램 진행 시간을 측정
// Stopwatch stopwatch = Stopwatch.StartNew();//시작
// for (int i = 0; i < 100; i++)
// {
//     Thread.Sleep(1);
// }
// //0.001
// stopwatch.Stop();   //정지
// Console.WriteLine($"for 시간 {stopwatch.ElapsedMilliseconds}ms" );
//
// //Regex 클래스를 사용하여 문자열 검색 및 검사를 수행
// string input = "123-456-7890";
// string pattern = @"^\d{3}-\d{3}-\d{4}$";
// bool isMatch = Regex.IsMatch(input, pattern);
// Console.WriteLine($"Is valid phone number: {isMatch}");
//
// //클래스시그니처 기본구성
// //C#에서 클래스 시그니처는 클래스의 선언부를 의미한다.
//
// //[접근 지정자] [수정자] class 클래스이름  : 부모클래스 , 인터페이스
// //public       abstract                  : BaseClass  ,IComparable
// //private      sealed
// //protected    static
// //             partial
//
// public class Player
// {
//     public string Name { get; set; }
//     public int Score { get; set; }
// }
// //상속하는 클래스
// public class Warrior : Player
// {
//     public int Strength { get; set; }
// }
// //인터페이스를 구현하는 클래스
// //public class Enemy: IAttackable, IMovable
// //{
// //    public void Attack() { }
// //    public void Move() { }
//
// //}
// //추상 클래스 (abstract)
// public abstract class Animal
// {
//     public abstract void MakeSound();
// }
//
//값 형식은 스택에 저장되고,참조 형식은 힙에 저장
// int valueType = 10;
// object referenceType = valueType;
//
// valueType = 20;
//
// Console.WriteLine($"ValueType : {valueType}");
// Console.WriteLine($"ReferenceType: {referenceType}");

//박싱 언박싱
//값 형식을 참조형식으로 변환(박싱) , 다시 값 형식으로 변환(언박싱)

// int value = 42;
// object boxed = value; //박싱
// int unboxed = (int)boxed; //언방식
//
// Console.WriteLine($"Boxed: {boxed}, Unboxed : {unboxed}");

//is 연산자 형식 비교하기
//객체가 특정 형식인지 확인할수 있다.
//
// object obj = "Hello";
//
// Console.WriteLine(obj is string); //true
// Console.WriteLine(obj is int); //false

//내장 함수 몇 가지
// string greeting = "Hello";
// string name = "Alice";
//
// string message = greeting + "," + name +"!";
// Console.WriteLine(message); //Hello,Alice
//
// Console.WriteLine($"Length of name: {name.Length}"); //문자열 길이
// Console.WriteLine($"To Upper: {name.ToUpper()}"); //대문자 변환
// Console.WriteLine($"Substring: {name.Substring(1)}"); //부분 문자열

// //string 다양한 메서드
// string text = "C# is awesome!";
// Console.WriteLine($"Cotains 'awesome' : {text.Contains("awesome")}");   //True
// Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");       //True
// Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");             // 3
// Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome","great")} ");//Replace 'awesome' with 'great' : C# is great!

//StringBuilder
// StringBuilder sb = new StringBuilder("Hello");
// sb.Append(",");
// sb.Append("World!");
// Console.WriteLine(sb.ToString());

//String과 StringBuilder클래스 성능차이 비교
//반복적으로 문자열을 수정할때 StringBuilder가 효율적이다.
// int iterations = 10000;
//
// Stopwatch sw = Stopwatch.StartNew();
//
// string text = "";
//
// for(int i =0; i<iterations; i++)
// {
//     text += "a";
// }
//
// sw.Stop();
// Console.WriteLine($"String  : {sw.ElapsedMilliseconds}ms");
//
// sw.Restart();
// StringBuilder sb = new StringBuilder();
//
// for(int i =0; i<iterations; i++)
// {
//     sb.Append("a");
// }
//
// sw.Stop();
// Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}ms");

//예외처리하기

//예외는 프로그램실행 중 발생하는 오류입니다. 예외를 처리하면 프로그램이 중단되지않고
//실행을 계속할수있습니다.
//try catch
// while(true)
// {
//
//     try
//     {
//         int[] numbers = { 1, 2, 3 };
//         Console.WriteLine(numbers[5]); //오류 발생
//     }
//     catch (IndexOutOfRangeException ex)
//     {
//         Console.WriteLine($"Error : {ex.Message}");
//     }
// }
//finally = 무조건 실행
// while (true)
// {
//     try
//     {
//         int number = int.Parse("NotANumber"); //오류발생
//     }
//     catch (FormatException ex)
//     {
//         Console.WriteLine($"Format Error: {ex.Message}");
//     }
//     finally
//     {
//         Console.WriteLine("항상실행됩니다.");
//     }
// }

//Exception 클래스 
//모든예외의 기본 클래스입니다.
//
// try
// {
//     int number = int.Parse("abc");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"General Error : {ex.Message}");
// }
// try
// {
//     int age = -5;
//     if(age <0)
//     {
//         throw new ArgumentException("Age cannot be negative");
//     }
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Exception : {ex.Message}");
// } 

//배열과 컬렉션
//배열은 고정된 크기의 데이터를 저장하는 데 사용
// int[] numbers = { 1, 2, 3, 4, 5 };
// foreach (var num in numbers)
// {
//     Console.WriteLine(num);
// }
// //List<T> 는 가변 크기의 데이터를 저장하는 데 사용
// List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
// names.Add("Dave");
// names.Remove("Bob");
// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }

//Stack 은 LIFOLast-In, First-Out) 구조
// Stack stack = new Stack();
// stack.Push(1);
// stack.Push(2);
// stack.Push(3);
// while (stack.Count > 0)
// {
//     Console.WriteLine(stack.Pop());
// }

//Queue 는FIFOFirst-In, First-Out) 구조
// Queue queue = new Queue();
// queue.Enqueue(1);
// queue.Enqueue(2);
// queue.Enqueue(3);
// while (queue.Count > 0);
// {
//     Console.WriteLine(queue.Dequeue());
// }

//ArrayList 는 크기가 동적으로 조정되는 배열로, 다양한 형식의 데이터를 저장할 수 있다
// // ArrayList 생성
// ArrayList arrayList = new ArrayList();
// // 요소추가
// arrayList.Add(1);           // 정수
// arrayList.Add("Hello");     // 문자열
// arrayList.Add(3.14);        // 실수
// // 요소접근
// Console.WriteLine("ArrayList 요소:");
// foreach (var item in arrayList)
// {
//     Console.WriteLine(item);
// }
// // 요소 제거
// arrayList.Remove(1); // 값이 1인요소 제거 Console.WriteLine("\nArrayList )
// Console.WriteLine("\nArrayList 요소 제거 후 :");
// foreach (var item in arrayList)
// {
//     Console.WriteLine(item);
// }

//Hashtable 클래스
//키-값 쌍을 저장하는 컬렉션이다. 
//키를 이용해 값을 빠르게 검색

// Hashtable hashtable = new Hashtable();
//
// //키-값 쌍 추가
// hashtable["Alice"] = 25;
// hashtable["Bob"] = 30;
// hashtable["포션"] = 20;
//
// Console.WriteLine("Hashtable 요소:");
//
// foreach(DictionaryEntry entry in hashtable)
// {
//     Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
// }
//
// //특정 키의 값 가져오기
// Console.WriteLine($"\n Alice의 나이 : {hashtable["Alice"]}");
//
// //요소제거
// hashtable.Remove("Bob");
//
// Console.WriteLine("Hashtable 요소:");
//
// foreach (DictionaryEntry entry in hashtable)
// {
//     Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
// }

//제네릭 사용하기(Generics)
//<T> 제네릭 클래스를 사용하면 특정 타입에 종속되지 않는 범용 클래스를 만들수있습니다.
// Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
// Cup<int> cupOfInt = new Cup<int> { Content = 42 };
//
// Console.WriteLine($"CupOfString: {cupOfString.Content}");
// Console.WriteLine($"cupOfInt: {cupOfInt.Content}");
// class Cup<T>
// {
//     public T Content { get; set; }
// }

// Stack<int> stack = new Stack<int>();
//
// stack.Push(10);
// stack.Push(20);
// stack.Push(30);
//
// while(stack.Count > 0)
// {
//     Console.WriteLine(stack.Pop());
// }

// List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
// names.Add("Dave");
//
//
// foreach(var name in names)
// {
//     Console.WriteLine(name);
// }

//IEnumerator를 사용하는 이유
//✔ 컬렉션을 직접 제어하며 순회할 수 있음
//✔ foreach 없이도 컬렉션 순회 가능
//✔ LINQ나 커스텀 컬렉션을 만들 때 유용함
// public interface IEnumerator
// {
//     bool MoveNext(); // 다음 요소로 이동 (이동할 요소가 있으면 true 반환)
//     object Current { get; } // 현재 요소 반환
//     void Reset(); // 처음 위치로 리셋
// }
//
// ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };
//
// IEnumerator enumerator = list.GetEnumerator(); //열거자 가져오기
//
//
// while(enumerator.MoveNext()) //다음 요소가 있는지 확인
// {
//     Console.WriteLine(enumerator.Current);//현재 요소 출력
// }
//
// class SimpleCollection: IEnumerable<int>
// {
//     private int[] data = { 1, 2, 3, 4, 5 };
//
//     public IEnumerator<int> GetEnumerator()
//     {
//         foreach(var item in data)
//         {
//             yield return item;
//         }
//     }
//     IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
// }
//
//
//
// //
// static void Main(string[] args)
// {
//
//     var collection = new SimpleCollection();
//
//     foreach(var i in collection)
//     {
//         Console.WriteLine(i);
//     } 
// } 
//
// //
// Dictionary<string, int> ages = new Dictionary<string, int>();
//
// ages["금도끼"] = 10;
// ages["은도끼"] = 5;
// ages["돌도끼"] = 1;
//
// foreach(var pair in ages)
// {
//     Console.WriteLine($"{pair.Key} : {pair.Value}");
// }
//
// //
// int? nullableInt = null;
//
// Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");
//
// nullableInt = 10;
//
// Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");
//
// //
// string str = null;
//
// if(str == null)
// {
//     Console.WriteLine( "DefaultValue");
// }
//
// Console.WriteLine(str ?? "DefaultValue");//str이 null이면 "Default Value
//
// //LINQ는 확장메서드 형태로 제공된다. 
// //LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할 수있습니다.
// int[] numbers = { 1, 2, 3, 4, 5 };
//
// var evenNumbers = numbers.Where(n => n % 2 == 0);
//
// foreach(var num in evenNumbers)
// {
//     Console.WriteLine(num);
// }


// class Program{
//     
//
//     static void Main(string[] args)
//     {
//         List<string> fruits = new List<string>()
//         {
//             "apple", "banana", "grape"
//         };
//         Console.WriteLine("fruits:");
//         for (int i = 0; i < fruits.Count; i++)
//         {
//             Console.WriteLine(fruits[i]);
//         }
//         
//         Queue<string> tasks = new Queue<string>();
//         tasks.Enqueue("1작업");
//         tasks.Enqueue("2작업");
//         tasks.Enqueue("3작업");
//         Console.WriteLine("tasks:");
//         foreach (var task in tasks)
//         {
//             Console.WriteLine(task);
//         }
//         
//         Stack<int> stack = new Stack<int>();
//         stack.Push(10);
//         stack.Push(20);
//         stack.Push(30);
//         foreach (var s in stack)
//         {
//             Console.WriteLine(s);
//         }
//     }
// }
// class Program{
//     
//
//     static void Main(string[] args)
//     {
//         string input = Console.ReadLine();
//         input = input.ToUpper();
//         Console.WriteLine(input.Replace("C#","CSharp"));
//     }
// }
class Program{
    

    static void Main(string[] args)
    {
        int[] nums = {1,2,3,4,5,6,7,8,9,10};
        var num1 = nums.Where(n => n % 2 == 0);
        var sum = nums.Sum();
        foreach (var n in num1)
        {
            Console.Write(n+" ");
        }
        Console.WriteLine();
        Console.WriteLine(sum);
    }
}