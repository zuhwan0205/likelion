// See https://aka.ms/new-console-template for more information

// // 이진수를 정수로 변환
// Console.Write("2진수를 입력하세요: ");
// string binaryInput = Console.ReadLine();
// int decimalValue = Convert.ToInt32(binaryInput, 2); // 2진수 -> 10진수 변환
// // 정수를 이진수로 변환
// string binaryOutput = Convert.ToString(decimalValue, 2); // 10진수 -> 2진수
// //변환
// Console.WriteLine($"입력한 이진수: {binaryInput}");
// Console.WriteLine($"10진수로 변환: {decimalValue}");
// Console.WriteLine($"다시 이진수로 변환: {binaryOutput}");

// //var = 변수의 데이터 형식을 자동으로 추론
// // var를 사용하여 변수 선언
// var name = "Alice"; // 문자열로 추론
// var age = 25; // 정수로 추론
// var isStudent = true;
//
// Console.WriteLine($"이름: {name} 나이: {age} 학생 여부 : {isStudent}");

// //default : 데이터 형식에 따라 기본값을 설정
// // default 키워드를 사용한 기본값 설정
// int defaultInt = default; // 기본값: 0
// string defaultString = default; // 기본값: null
// bool defaultBool = default; // 기본값: false
//
//
// Console.WriteLine($"정수 기본값: {defaultInt}"); // 출력: 0
// Console.WriteLine($"문자열 기본값: {defaultString}"); // 출력: (null)
// Console.WriteLine($"논리값 기본값: {defaultBool}"); // 출력: False

//연산자
// int a = 5, b = 3;
// int sum = a + b; // 산술 연산자 사용
// bool isEqual = (a == b); // 관계형 연산자 사용
// Console.WriteLine($"합: {sum}"); // 출력: 8
// Console.WriteLine($"곱: {a*b}");
// Console.WriteLine($"나누기(몫): {a/b}");
// Console.WriteLine($"나누기(나머지): {a%b}");
// Console.WriteLine($"a와 b가 같은가? {isEqual}"); // 출력: False
//
// //단항 연산자 : 피연산자 하나에 적용되는 연산자(+,-,!,~)
// int number = 5;
// Console.WriteLine(+number); // 양수 출력: 5
// Console.WriteLine(-number); // 음수 출력: -5
// bool flag = true;
// Console.WriteLine(!flag); // 논리 부정: False
// int num = 10;
// int result = ~num;
//
// Console.WriteLine(num);
// Console.WriteLine(result);

//( ) 를 사용해 데이터 형식을 명시적으로 변환
//실수에서 정수로 변환 시 소수점이 버려짐!!
// double pi = 3.14;
// int integerPi = (int)pi; // 실수를 정수로 변환
// Console.WriteLine(integerPi); // 출력: 3

//문자열 연결 연산자
//+ 를 사용해 문자열을 연결
// string firstName = "Alice";
// string lastName = "Smith";
// Console.WriteLine(firstName + " " + lastName); // 출력: Alice Smith

//할당 연산자
//값을 변수에 저장합니다.
// int a = 10;
// a += 5; // 5
// a -= 5; // 10
// Console.WriteLine(a);
// a *= 5; //50
// Console.WriteLine(a);
// a /= 5; //10
// Console.WriteLine(a);
// a %= 5; //0
// Console.WriteLine(a);

// Console.WriteLine("수학");
// int MathScore = int.Parse(Console.ReadLine());
// Console.WriteLine("국어");
// int KorScore = int.Parse(Console.ReadLine());
// Console.WriteLine("영어");
// int EngScore = int.Parse(Console.ReadLine());
//
//
// float agScore = (float)(MathScore + KorScore + EngScore) / 3;
// Console.WriteLine($"평균: {agScore.ToString("F2")}");
//
//
// Console.WriteLine("정수 입력");
// int num = int.Parse(Console.ReadLine());
//
// Console.WriteLine($"입력값 {num}");
// Console.WriteLine($"비트 반전 값 {~num}");

//증감 연산자
// int b = 3;
// b++; // 후위 증가
// Console.WriteLine(b); // 출력: 4
// --b; // 전위 감소
// Console.WriteLine(b); // 출력: 3

//비교 연산자
//두 값을 비교하여 평가
// int x = 5, y = 10;
//
// Console.WriteLine(x == y);  // false
// Console.WriteLine(x != y);  // true
// Console.WriteLine(x < y);   // true
// Console.WriteLine(x > y);   // false
// Console.WriteLine(x >= y);  // false
// Console.WriteLine(x <= y);  //true 

//논리 연산자 : 논리값을 결합하거나 반전
// bool a = true, b = false;
// Console.WriteLine(a && b); // AND: False
// Console.WriteLine(a || b); // OR: True
// Console.WriteLine(!a); // NOT: False
//
// //비트 연산자
// //비트 단위로 AND( & ), OR( | ), XOR( ^ ), NOT( ~ )를 수행
// int x = 5; // 0101
// int y = 3; // 0011
// Console.WriteLine(x & y); // AND: 1 (0001)
// Console.WriteLine(x | y); // OR: 7 (0111)
// Console.WriteLine(x ^ y); // XOR: 6 (0110)
// Console.WriteLine(~x); // NOT: -6
//
// //시프트 연산자
// //비트를 좌우로 이동
// int value = 4; // 0100
// Console.WriteLine(value << 1); // 왼쪽 이동: 8 (1000)
// Console.WriteLine(value >> 1); // 오른쪽 이동: 2 (0010)

//기타 연산자
//?: (삼항 연산자): 조건문을 간단히 표현.
//is : 객체가 특정 형식인지 확인.
//?? : null 병합 연산자.

// int a = 10, b = 20;
// int max = (a > b) ? a : b; // 삼항 연산자
// Console.WriteLine(max); // 출력: 20

// int key = 1;
// string str;
// str = (key == 1) ? "문열" : "문닫";

// int score = 85;
// if (score >= 90)
// {
//     Console.WriteLine("A 학점");
// }
// else if (score >= 80)
// {
//     Console.WriteLine("b 학점");
// }
// else if (score >= 70)
// {
//     Console.WriteLine("c 학점");
// }
// else
// {
//     Console.WriteLine("f 학점");
// }

// Console.WriteLine("보유 돈");
// int money = int.Parse(Console.ReadLine());
// Console.WriteLine("캐릭터 이름 입력");
// string name = Console.ReadLine();
// int dmg = 100;
// if (money >= 0 && money <= 100)
// {
//     Console.WriteLine("무한의 대검");
//     dmg += 1;
// }
// else if(101 <= money && money <= 200)
// {
//     Console.WriteLine("카타나");
//     dmg += 1;
// }
// else if(201 <= money && money <= 300)
// {
//     Console.WriteLine("진은검");
//     dmg += 1;
// }
// else if(301 <= money && money <= 400)
// {
//     Console.WriteLine("집판검");
//     dmg += 1;
// }
// else if(401 <= money && money <= 500)
// {
//     Console.WriteLine("엑스칼리버");
//     dmg += 1;
// }
// else
// {
//     Console.WriteLine("유령검");
//     dmg += 1;
// }
//Console.WriteLine($"{name}의 공격력 :{dmg}");

// int num1 = int.Parse(Console.ReadLine());
// int num2 = int.Parse(Console.ReadLine());
// int num3 = int.Parse(Console.ReadLine());
// int max = 0;
//
// if (num1 > num2 && num1 > num3)
// {
//     max = num1;
// }
// else if (num2 > num1 && num2 > num3)
// {
//     max = num2;
// }
// else
// {
//     max = num3;
// }
//
// Console.WriteLine($"최대값은 {max}");

// int score = int.Parse(Console.ReadLine());
// if (score >= 90)
// {
//     Console.WriteLine("A 학점");
// }
// else if (score >= 80 && score < 90)
// {
//     Console.WriteLine("b 학점");
// }
// else if (score >= 70 && score < 80)
// {
//     Console.WriteLine("c 학점");
// }
// else if (score >= 60 && score < 70)
// {
//     Console.WriteLine("d 학점");
// }
// else
// {
//     Console.WriteLine("f 학점");
// }

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
string text = Console.ReadLine();
int result = 0;

if (text == "+")
{
    result = num1 + num2;
}
else if (text == "-")
{
    result = num1 - num2;
}
else if (text == "*")
{
    result = num1 * num2;
}
else if (text == "/")
{
    result = num1 / num2;
    if (num1 == 0)
    {
        Console.WriteLine("num1에 0은 입력 불가능합니다.");
    }
}
Console.WriteLine($"결과: {result}");