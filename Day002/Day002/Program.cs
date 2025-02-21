class Day002
{
    static void Main(string[] args)
    {
        //Console.WriteLine("깃허브 연결하기");

        //변수 선언부
        //int age; //정수형 변수
        //age = 25; //변수에 값 할당

        //리터럴 선언
        // int age = 25;           //정수형 리터럴
        // double pi = 3.14;       //실수형 리터럴
        // char letter = 'a';      //문자 리터럴
        // string name = "name";   //문자열 리터럴
        //
        // Console.WriteLine(age); //age 변수에 저장된 값 25 출력

        // string name = "캐릭터";
        // int hp = 100;
        // double att = 56.7;
        // string chname = "??";
        // char rank = 'S';
        //
        // Console.WriteLine(name);
        // Console.WriteLine("hp : "+ hp);
        // Console.WriteLine("att : "+ att);
        // Console.WriteLine("캐릭터 이름 : "+ chname);
        // Console.WriteLine("등급 : "+ rank);
        //
        // //문자열
        // string greet = "Hello, world!";  //greet에 할당
        // Console.WriteLine(greet);       // 출력
        //
        // //선언과 초기화를 동시에
        // int score = 100; //정수형 변수 선언과 동시에 100으로 초기화
        // double temperature = 36.5; // 실수형 변수 선언과 초기화
        // string city = "seoul"; //문자열 변수 선언과 초기화
        //
        // Console.WriteLine(score);
        // Console.WriteLine(temperature);
        // Console.WriteLine(city);
        //
        // //같은 데이터 타입의 변수는 쉼표로 구분해 선언
        // int x = 10, y = 20, z = 30; //정수형 변수 x,y,z 를 선언하고 초기화
        // Console.WriteLine(x + y+z);

        // const double PI = 3.14159265358979323846; //상수 pi 선언 및 초기화
        // const int MaxScore = 100; //정수형 상수 선언
        //
        // Console.WriteLine(PI);
        // Console.WriteLine(MaxScore);
        //
        // double att = 85047, MaxHp = 261741, str = 1743, dex = 636, lux = 260, Int = 17, www = 34, sss =14;
        //
        // Console.WriteLine($"공격력 : {att}\n 최대 생명력 : {MaxHp}\n 치명 : {str}\n 특화 : {dex} \n 신속 : {lux}\n 제압 : {Int}\n 인내 : {www}\n 숙련 : {sss}");

        //숫자 데이터 형식 : 정수와 실수를 다룰 때 사용하는 방법
        // int integerNum = 10;        //정수 데이터
        // float floatNum = 10.5f;     //단정밀도 실수
        // double doubleNum = 10.51112;
        //
        // Console.WriteLine(integerNum); 
        // Console.WriteLine(floatNum); 
        // Console.WriteLine(doubleNum);
        
        //정수 데이터 형식 : 소수점이 없는 숫자를 표현
        // int intValue = -100;
        // long longValue = 1234567890L;
        //
        // Console.WriteLine(intValue);
        // Console.WriteLine(longValue);
        
        //부호 있는 정수 : 음수와 양수를 모두 표현 가능
        // sbyte signedByte = -50; //1바이트 크기
        // short signedShort = -35; //2바이트 크기
        // int signedInt = -35000000; //4바이트 크기
        //
        // Console.WriteLine(signedByte);
        // Console.WriteLine(signedShort);
        // Console.WriteLine(signedInt);
        
        // //부호없는 정수 데이터 형식
        // byte unsigned = 255;            //1바이트
        // ushort unsignedShort = 65000;   //2바이트
        // uint unsignedInt = 4000000000;  //4바이트
        //
        // Console.WriteLine(unsigned);
        // Console.WriteLine(unsignedShort);
        // Console.WriteLine(unsignedInt);
        
        //실수형 데이터 형식 : 소수점을 포함한 숫자를 표현
        // float singlePrecision = 3.14f;  //단정밀도 실수
        // double doublePrecision = 3.1415926535; //배정밀도 실수 8바이트
        // decimal highPrecision = 3.1415926535123123123m; //고정밀도 16바이트
        //
        // Console.WriteLine(singlePrecision);
        // Console.WriteLine(doublePrecision);
        // Console.WriteLine(highPrecision);
        
        //숫자 형식의 리터럴 값에 접미사 붙이기
        // int a = 11111;
        // float b = 2222f;
        // double d = 333333;
        // decimal e = 444443333333333m;
        //
        // Console.WriteLine(a);
        // Console.WriteLine(b);
        // Console.WriteLine(d);
        // Console.WriteLine(e);
        
        //char 형식 : 단일 문자 표현
        // char letter = 'A';
        // char symbol = '#';
        // char number = '3';
        //
        // Console.WriteLine(letter);
        // Console.WriteLine(number);
        // Console.WriteLine(letter);
        
        //string 형식 : 여러 문자를 저장
    //     string greeting = "Hello";
    //     string name = "Alice";
    //     
    //     Console.WriteLine(greeting);
    //     Console.WriteLine(name);
    //     
    //     Console.WriteLine(greeting + name);
    
    // //bool 형식 : 참(true=1) 거짓(false=0)
    //
    // // bool isRunning = true;
    // // bool isFinished = false;
    // //
    // // Console.WriteLine(isRunning);
    // // Console.WriteLine(isFinished);
    //
    // //변하지 않는 상수
    // const double PI = 3.14159265358979323846;
    // const float PI2 = 3.14159265358979323846f;
    //
    // Console.WriteLine(PI +" "+ PI2);
    
    // //닷넷 형식
    // Int32 Number = 123;             //int의 닷넷 형식
    // String test = "hello world";    //string의 닷넷 형식
    // Boolean flag = true;            //bool의 닷넷 형식
    //
    // Console.WriteLine(test);
    // Console.WriteLine(flag);
    // Console.WriteLine(Number);
    
    //int,bool 래퍼 형식의 메서드 활용
    // int number = 123;
    //
    // string numberStr = number.ToString();
    //
    // bool flag = true;
    // string flagStr = flag.ToString();
    //
    // Console.WriteLine(numberStr);
    // Console.WriteLine(flagStr);
    
    //특수문자
    // Console.WriteLine("👌👌👌👌👌👌👌👌");
    // Thread.Sleep(3000);
    // Console.WriteLine("                  ");
    // Console.WriteLine("🤞🏿🤞🏿🤞🏿🤞🏿🤞🏿🏿🤞🏿🤞🏿");
    
    // Console.WriteLine($"이름 입력");
    // string name = Console.ReadLine();       //문자열 입력 받기
    // Console.WriteLine("나이 입력");
    // int age = int.Parse(Console.ReadLine());//정수 입력 받기
    //
    // Console.WriteLine($"안녕하세요 {name}님, 반갑습니다. \n 올해 나이는 {0}살입니다. \n 내년 나이는 {age+1}", age);
    
    
    // Console.WriteLine("루인 스킬 피해 입력");
    // float skill = float.Parse(Console.ReadLine());
    // Console.WriteLine("카드 게이지");
    // float card = float.Parse(Console.ReadLine());
    // Console.WriteLine("각성기 딜");
    // float ult = float.Parse(Console.ReadLine());
    // Console.WriteLine("최대 마나");
    // int Maxmp = int.Parse(Console.ReadLine());
    // Console.WriteLine("전투 중 마나 회복량");
    // int hillmp = int.Parse(Console.ReadLine());
    // Console.WriteLine("비전투 중 마나 회복량");
    // int hillmp2 = int.Parse(Console.ReadLine());
    // Console.WriteLine("이속");
    // float move2 = float.Parse(Console.ReadLine());
    // Console.WriteLine("탈 속");
    // float move3 = float.Parse(Console.ReadLine());
    // Console.WriteLine("운속");
    // float move = float.Parse(Console.ReadLine());
    // Console.WriteLine("스킬 쿨");
    // float cooltime = float.Parse(Console.ReadLine());
    // Console.WriteLine("활동");
    // Console.WriteLine("==========================================");
    // Console.WriteLine($"루인 스킬 피해 {skill}% \n 카드 게이지 획득량 {card}% \n 각성기 피해 {ult}% \n 최대 마나 {Maxmp} \n 전투중 마나 회복량 {hillmp} \n 비전투 중 마나 회복량 {hillmp2} \n " +
    //                   $"이동 속도 {move2}% \n 탈것 속도 {move3}% \n 운반속도 {move}% \n 스킬 재사용 대기시간 {cooltime}%");
    
    
    //과제 
    //로딩바 시작화면
    //겜임스토리1
    int total = 20; // 로딩바의 길이
    Console.Write("Loading: [");
        
    for (int i = 0; i <= total; i++)
    {
        Console.Write("#"); 
        Thread.Sleep(100); 
    }
        
    Console.WriteLine("] Done!");
    
    Console.WriteLine("엔터를 치면 스토리가 시작됩니다.");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("눈을 떠보니 생전 처음보는 곳에서 깨어났다.");
    Console.ReadLine();
    Console.WriteLine("주변 거울을 보니 내가 마네킹으로 변해있고 몇몇 움직이는 마네킹들이 보인다.");
    Console.ReadLine();
    Console.WriteLine("잠시 모여 말을 들어보니 다들 원래 사람이었지만 눈을 떠보니 여기였고 마네킹으로 변해있었다고 한다.");
    Console.ReadLine();
    Console.WriteLine("일단 밤이 되어 숙면을 취하기로 했다.");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("다음 날 아침");
    Console.ReadLine();
    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! \n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! \n" +
                      "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! \n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! ");
    Console.Clear();
    Console.ReadLine();
    Console.WriteLine("창고에 어제 본 사람이었던 마네킹이 부서져 있다....");
    Console.ReadLine();
    Console.WriteLine("여기 사람이 아니였던 마네킹이 하나 있는 거 같다...");
    Console.ReadLine();
    Console.WriteLine("충격을 받은 사람들은 주변을 수색해 탈출구를 찾았지만 키가 필요한 것 같다.");
    Console.ReadLine();
    Console.WriteLine("방법을 찾아 여기서 탈출해야 한다...!");
    Console.ReadLine();
    Console.WriteLine("\t\t\t|SOLVIVE|\t\t\t");
    Console.WriteLine("                      ");
    Console.WriteLine("                      ");
    Console.WriteLine("                      ");
    Console.WriteLine("                      ");
    Console.WriteLine("\t\t\t|게임시작|\t\t\t");
    Console.WriteLine("게임 시작을 원하시면 1, 아니면 2");
    int gamestart = int.Parse(Console.ReadLine());
    if (gamestart == 1)
    {
        Console.Clear();
        Console.WriteLine("창고를 뒤지다 컴퓨터를 발견했습니다. \n 컴퓨터를 켜기 위해선 전기를 연결해야 했습니다. 그때 저기서 발전기를 발견했다는 소리를 들었습니다.");
        Console.ReadLine();
        Console.WriteLine("발전기에는 연료가 필요해 당신으 구하러 가기로 했다. \n 함께 갈 사람을 구해야 한다. 1번 알렉스, 2번 듀크, 3번 알리");
        int findfriend = int.Parse(Console.ReadLine());
        if (findfriend == 1)
        {
            Console.Clear();
            Console.WriteLine("당신과 함께간 알렉스는 인간이 되고 싶은 마네킹이였습니다. 당신은 연료를 구하러 가는 길에 알렉스에게 머리가 깨져 사망했습니다.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("연료를 성공적으로 구해 돌아왔습니다. \n 컴퓨터를 켜 탈출 방법을 알게되었습니다. 열쇠를 찾아 문을 열면 탈출 가능했습니다.");
            Console.ReadLine();
            Console.WriteLine("당신은 차고에서 열쇠를 찾았습니다. \n 하지만 탈출구로 가니 한 번에 2명 밖에 탈출하지 못하는 걸 알게 되었습니다.");
            Console.ReadLine();
            Console.WriteLine("누구와 함께 가시겠습니까. 1번 니나브, 2번 카단, 3번 카마인");
            int ending = int.Parse(Console.ReadLine());
            if (ending == 1 || ending == 2)
            {
                Console.Clear();
                Console.WriteLine("당신은 사람으로 돌아가 탈출에 성공하셨습니다.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("당신이 고른 카마인은 인간인 척하는 마네킹이였습니다. 카마인은 열쇠를 들고 있는 당신을 죽여 열쇠를 뺏고 탈출 후 더욱 강해져 다시 돌아가 모든 사람들을 죽일 것 입니다.");
                
            }
        }
    }
    else if (gamestart == 2)
    {
        Console.WriteLine("게임 종료합니다");
        Environment.Exit(0);
    }
    
    }
}