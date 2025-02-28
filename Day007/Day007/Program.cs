using System.Runtime.InteropServices;

namespace study21
{

    // class Person
    // {
        //private string name; //내부 변수
        // //값 설정하기 (Setter)
        // public void SetName(string newName)
        // {
        //     name = newName;
        // }
        //
        // //값 가져오기 (Getter)
        // public string GetName()
        // {
        //     return name;
        // }
        //C#프로퍼티
        // public string Name
        // {
        //     get { return name; }
        //     set { name = value; }
        // }
        // public string Name { get; set; }
        // private int count = 100;
        // public int Count { get { return count; }}
        // public float Balance { get; private set; }
        //
        // public void AddBal()
        // {
        //     Balance += 100;
        // }
    //}
    // public class Marin
    // {
    //     public string name{get; private set;} = "마린";
    //     public int mineral{get; private set;} = 50;
    // }
    //
    public class Bullet
    {
        public int x;
        public int y;
        public bool fire;
    }

    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();
        public int playerX;
        public int playerY;
        public Bullet[] playerBullet = new Bullet[20];

        public Player()
        {
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++)
            {
                playerBullet[i] = new Bullet();
                playerBullet[i].x =0;
                playerBullet[i].y =0;
                playerBullet[i].fire = false;
            }
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            //C#에서 get/set 방식의 함수와 프로퍼티 비교
            //C#에서는 객체의 값을 읽고(get), 설정(set)하는
            //방식으로 함수(get/set 메서드) 또는
            //**프로퍼티(Property)**를 사용할 수 있습니다.
            // Person p = new Person();
            //
            // p.Name="홍길동";
            //
            // Console.WriteLine($"이름 :  + {p.Name} Count : {p.Count} Balance : {p.Balance}");
            //
            // Marin m = new Marin();
            // Console.WriteLine($"이름:{m.name} 미네랄: {m.mineral}");
        }
    }
}