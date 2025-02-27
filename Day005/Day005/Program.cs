// See https://aka.ms/new-console-template for more information

// Console.WriteLine("==============기본 배열=============");
// string[] fruits = { "apple", "banana", "orange", "strawberry" };
//
// Console.WriteLine("==============배열 선언=============");
// int[] num1 = new int[3];
// int[] num2 = new int[] {1,2,3};
// int[] num3 = {1,2,3};
//
// Console.WriteLine("==============1차원 배열=============");
// int[] score = new int[3];
// score[0] = 90;
// score[1] = 80;
// score[2] = 70;
// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine(score[i]);
// }
//
// Console.WriteLine("==============다차원 배열=============");
// int[,] matrix = new int[3, 2]{
//     {1,2},{3,4},{5,6}
// };
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 2; j++)
//     {
//         Console.WriteLine(matrix[i, j]);
//     }
// }

// int[,] score = new int [3,3];
// int sum = 0;
// int sum2 = 0;
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 3; j++)
//     {
//         score[i,j] = int.Parse(Console.ReadLine());
//     }
// }
//
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 3; j++)
//     {
//         sum += score[i,j];
//     }
// }
//
// sum2 = sum / 9;
// Console.WriteLine(sum);
// Console.WriteLine(sum2);

//배열 
// 0부터시작한다.

//int[] num = new int[3];  //3개 메모리 만들겠다.

//num[0] = 10;
//num[1] = 20;
//num[2] = 30;


//for(int i =0; i<3; i++)
//{
//    Console.WriteLine(num[i]);
//}

//int[] numbers = { 1, 2,3}; //간단한 선언과 초기화
//int[] numbers2 = new int[3];  //크기만 지정
//int[] numbers3 = new int[] { 1, 2,3}; //초기화와 함께 선언


//for(int i =0; i<3; i++)
//{
//    Console.WriteLine(numbers3[i]);
//}


//string[] fruits = { "사과", "바나나", "오렌지" };

//for(int i =0; i<3; i++)
//{
//    Console.WriteLine(fruits[i]);
//}

//3명의 
//국어, 영어, 수학 점수를 입력받고
//총점과 평균을 출력하세요.

// int[] iKor = new int[3];
// int[] iEng = new int[3];
// int[] iMath = new int[3];
//
// int[] sum = new int[3];
// float[] aver = new float[3];
//
//
// //학생입력받기
//
// for(int i =0; i<3; i++)
// {
//     Console.WriteLine("학생 성적입력하세요 : ");
//     Console.Write("국어 : ");
//     iKor[i] = int.Parse(Console.ReadLine());
//     Console.Write("영어 : ");
//     iEng[i] = int.Parse(Console.ReadLine());
//     Console.Write("수학 : ");
//     iMath[i] = int.Parse(Console.ReadLine());
//
//
//     sum[i] = iKor[i] + iEng[i] + iMath[i];
//
//     aver[i] = (float)sum[i] / 3;
//
//
//
// }
//
//
//
// //출력
// for(int i=0; i<3; i++)
// {
//     Console.WriteLine((i+1)+"번학생");
//     Console.WriteLine($"국어 : {iKor[i]} 영어 : {iEng[i]} 수학 : {iMath[i]} ");
//     Console.WriteLine("총점 : " + sum[i]);
//     Console.WriteLine("평균 : " + aver[i].ToString("F2"));
// }

// Console.WriteLine("==============2차원 배열============");
// int[,] matrix = new int[2, 3]{{1,2,3},{4,5,6}};
// for (int i = 0; i < matrix.Length; i++)
// {
//     for (int j = 0; j < 2; j++)
//     {
//         Console.Write(matrix[i, j] + " ");
//     }
// }

// Console.WriteLine("\n=== 가변배열 ===");
// int[][] jaggedArray = new int[3][];
// jaggedArray[0] = new int[] { 1, 2 };
// jaggedArray[1] = new int[] { 3, 4, 5 };
// jaggedArray[2] = new int[] { 6 };
//
// for (int i = 0; i < jaggedArray.Length; i++)
// {
//     for (int j = 0; j < jaggedArray[i].Length; j++)
//     {
//         Console.Write($"{jaggedArray[i][j]} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("\n=== var 키워드사용===");
// var numbers = new[] { 1, 2, 3, 4, 5 };
// Console.WriteLine($"배열 타입: {numbers.GetType()}");

//셔플 하는 법
// int a = 10;
// int b = 20;
// int t =0;
// t=a;
// a = b;
// b=t;
//Console.WriteLine($"a:{a} b: {b}");

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
//
//
//             int[] iArray = new int[25];
//
//            
//             for(int i =0; i<25; i++)
//             {
//                 iArray[i] = i + 1; 
//             }
//
//          
//
//             Random rand = new Random();
//             //셔플
//             for(int i =0; i<100; i++)
//             {
//                 int iA = rand.Next(0, 25);
//                 int iB = rand.Next(0, 25);
//                 int iT = 0;
//
//
//                 iT = iArray[iA];
//                 iArray[iA] = iArray[iB];
//                 iArray[iB] = iT;
//             }
//
//             int input = 0;
//            
//             int iCount = 0;
//             int iBingo = 0;
//             while (true)
//             {
//                 Console.Clear();
//                 
//                 //빙고판
//                 for (int i = 0; i < 5; i++)
//                 {
//                     for (int j = 0; j < 5; j++)
//                     {
//
//                         if (iArray[i * 5 + j] == 0)  //0일경우 체크
//                         {
//                             Console.Write(" * ");
//                         }
//                         else
//                         {
//                             Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
//                         }
//                     }
//                     Console.WriteLine();
//                 }
//                 Console.WriteLine("빙고 숫자 : " + iBingo);
//                 Console.WriteLine("숫자를 입력하세요: ");
//                 input = int.Parse(Console.ReadLine());
//                 iBingo = 0;
//                 for (int i =0; i<25; i++)
//                 {
//                     if (iArray[i] == input)
//                     {
//                         iArray[i] = 0;
//                         break;
//                     }
//                 }
//
//
//                 //빙고 체크 로직
//                 //가로 체크
//                 for (int i = 0; i <5; ++i)
//                 {
//                     for(int j=0; j<5; ++j)
//                     {
//                         if (iArray[i *5 +j] ==  0)
//                         {
//                             ++iCount;
//                         }
//
//                         if(iCount == 5)
//                         {
//                             ++iBingo;
//                         }
//                     }
//                     iCount = 0;
//                 }
//
//                 //세로 체크
//                 for(int i=0; i<5; i++)
//                 {
//                     for(int j=0; j<5; j++)
//                     {
//                         if (iArray[i+5*j] == 0)
//                         {
//                             ++iCount;
//                         }
//
//                         if(iCount == 5)
//                         {
//                             ++iBingo;
//                         }
//                     }
//                     iCount = 0;
//                 }
//
//
//
//                 //대각선 오른쪽체크
//                 //00 01 02 03 04
//                 //05 06 07 08 09
//                 //10 11 12 13 14
//                 //15 16 17 18 19
//                 //20 21 22 23 24
//
//                 for(int i=0; i< 5; i++)
//                 {
//                     if (iArray[i*4+4] == 0)
//                     {
//                         ++iCount;
//                     }
//
//                     if(iCount == 5)
//                     {
//                         ++iBingo;
//                     }
//                 }
//                 iCount = 0;
//
//
//
//
//
//
//
//                 //대각선 왼쪽체크
//                 //00 01 02 03 04
//                 //05 06 07 08 09
//                 //10 11 12 13 14
//                 //15 16 17 18 19
//                 //20 21 22 23 24
//                 for (int i = 0; i < 5; i++)
//                 {
//                     if (iArray[i *6] == 0)
//                     {
//                         ++iCount;
//                     }
//
//                     if (iCount == 5)
//                     {
//                         ++iBingo;
//                     }
//                 }
//                 iCount = 0;
//
//
//                 if(iBingo >= 5)
//                 {
//                     Console.WriteLine("빙고 성공");
//                     break;
//                 }
//             }

//1번
Console.WriteLine("==========================1번==========================");
int[] num = new int[5] { 10, 20, 30, 40, 50 };
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(num[i]);
}
Console.WriteLine("==========================2번==========================");
//2번
int[] num2 = new int[5];
int sum = 0;
for (int i = 0; i < 5; i++)
{
    num2[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    sum += num2[i];
}
Console.WriteLine(sum);
Console.WriteLine("=========================3번===========================");
//3번
int[] num3 = new int[5]{3,8,15,6,2};
int max =0;
for (int i = 0; i < 5; i++)
{
    if (num3[i] > max)
    {
        max = num3[i];
    }
}
Console.WriteLine(max);
Console.WriteLine("==========================4번==========================");
//4번
for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("============================5번========================");
//5번
int[] num4 = new int[10]{1,2,3,4,5,6,7,8,9,10};
while (true)
{
    for (int i = 0; i < 10; i++)
    {
        if (num4[i] % 2 == 0)
        {
            Console.Write(num4[i]);
        }
    }
    Console.WriteLine();
    break;
}
Console.WriteLine("===========================6번=========================");
//6번
int[] num5 = new int[5]{1,2,3,4,5};
foreach (var num6 in num5)
{
    Console.WriteLine(num6);
}
Console.WriteLine("===========================7번=========================");
//7번
void Sum()
{
    int num7 = int.Parse(Console.ReadLine());
    int num8 = int.Parse(Console.ReadLine());
    int num9 = num7 + num8;
    Console.WriteLine("합: "+num9);
}
Sum();
Console.WriteLine("===========================8번=========================");
//8번
string input = (Console.ReadLine());
Console.WriteLine("글자수: "+GetLength(input));

int GetLength(string s)
{
    return s.Length;
}
Console.WriteLine("==========================9번==========================");
//9번
int[] numbers = new int[3];
int max3 = 0; 
result();
void result()
{
    for (int i = 0; i < 3; i++)
    {
        numbers[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < 3; i++)
    {
        if (numbers[i] > max3)
        {
            max3 = numbers[i];
        }
    }
    Console.WriteLine("최대값:"+max3);
}

