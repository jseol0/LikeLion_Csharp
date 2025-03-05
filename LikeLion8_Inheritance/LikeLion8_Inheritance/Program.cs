using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion8_Inheritance
{
    ////부모 클래스
    //class Animal
    //{ 
    //    public string Name { get; set; }

    //    public void Eat()
    //    {
    //        Console.WriteLine($"{Name}이(가) 음식을 먹고 있습니다.");
    //    }
    //}

    ////자식 클래스
    //class Dog : Animal
    //{
    //    public void Bark()
    //    {
    //        Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Dog myDog = new Dog();
    //        myDog.Name = "춘식이";    // 부모클래스의 속성 사용
    //        myDog.Eat();             // 부모클래스의 메서드 호출 가능
    //        myDog.Bark();
    //    }
    //}


    //class Player
    //{
    //    public string name;

    //    public void Render()
    //    {
    //        Console.WriteLine($"플레이어: {name}");
    //    }
    //}

    //class Wizard : Player
    //{
    //    public string job;

    //    public void Render2()
    //    {
    //        Console.WriteLine($"직업: {job}");
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Player p = new Player();

    //        p.name = "jseol";
    //        p.Render();
    //        //p.Render2();    Error 부모클래스가 자식클래스 사용 불가능

    //        Wizard w = new Wizard();

    //        w.name = "jseol";
    //        w.job = "마법사";
    //        w.Render();
    //        w.Render2();
    //    }
    //}



    ////메서드 오버라이딩(OverRiding)
    ////부모 클래스의 메서드를 자식 클래스에서 재정의하여 다른 동작을 수행하는것
    //public class Animal
    //{ 
    //    public string Name { get; set; }

    //    //가상(virtual)메서드 : 자식 클래스에서 재정의 가능
    //    public virtual void Speak()
    //    {
    //        Console.WriteLine("동물이 소리를 냅니다.");
    //    }
    //}

    //public class Dog : Animal
    //{
    //    //부모 클래스의 메서드를 오버라이딩
    //    public override void Speak()
    //    {
    //        Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Animal myAnmial = new Animal();
    //        myAnmial.Name = "일반동물";
    //        myAnmial.Speak();

    //        Dog myDog = new Dog();
    //        myDog.Name = "춘식이";
    //        myDog.Speak();
    //    }
    //}


    /*
    //업캐스팅(Upcasting)
    //자식 클래스->부모클래스로 변환하는것
    //암시적 변환이 가능(컴파일러가 자동변환)
    //안전: 데이터 손실 없이 변환가능
    //다운캐스팅 
    //명시적변환이 필요 (타입)
    //불완전함 ->실행중 InvalidCastException발생가능
    //as is키워드로 안전하게 변환가능

    class Animal //부모 클래스
    {
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Dog myDog = new Dog();  //자식 클래스 객체 생성
            //Animal myAnimal = myDog; //업캐스팅(Dog->animal)

            //myAnimal.Speak(); //사용가능 

            ///myAnimal.Bark()  오류 업캐스팅후 자식 클래스의 메서드는 접근 불가
            ///

            Animal myAnimal = new Dog(); //업캐스팅
            //Dog myDog = (Dog)myAnimal; //다운캐스팅 (명시적 변환)

            Dog myDog = myAnimal as Dog;

            if (myDog != null)
            {
                myDog.Bark();
            }
            else
            {
                Console.WriteLine("변환 실패!");
            }

            //Animal myAnimal2 = new Animal();
            //Dog myDog = (Dog)myAnimal2;

            if (myAnimal is Dog myDog1)
            {
                myDog1.Bark(); //실행
            }
            else
            {
                Console.WriteLine("변환할수 없습니다.");
            }
        }
    }
    */


    /*
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("멍멍!");
        }
        public void WagTail()
        {
            Console.WriteLine("꼬리를 흔든다.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Dog(); //업캐스팅

            myAnimal.Speak(); //멍멍! 오버라이드된 메서드 실행

            Dog d = (Dog)myAnimal;

            d.WagTail();

            Animal myAni = new Animal();

            myAni.Speak();


        }
    }
    */

    ////base 부모 호출하기
    //public class Parent
    //{
    //    public virtual void ShowMessage()
    //    {
    //        Console.WriteLine("부모클래스의 메시지");
    //    }
    //}

    //public class Child : Parent
    //{
    //    public override void ShowMessage()
    //    {
    //        Console.WriteLine("자식클래스의 메시지");
    //        base.ShowMessage();
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Child child = new Child();
    //        child.ShowMessage();
    //    }
    //}



    //class Player
    //{
    //    protected string Name;  // 부모 자식 상속관계에서만 사용

    //    public Player()
    //    {
    //        Name = "플레이어";
    //        Console.WriteLine("생성자입니다");
    //    }

    //    public void Show()
    //    {
    //        Console.WriteLine(Name);
    //    }
    //}

    //class Wizard : Player
    //{ 
    //    public Wizard()
    //    {
    //        Name = "마법사";
    //        Console.WriteLine("자식생성자입니다");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Player player = new Player();
    //        player.Show();

    //        Wizard wizard = new Wizard();   // 부모클래스 생성자 실행 후 자식클래스 생성자 실행
    //        wizard.Show();
    //    }
    //}



    class Unit
    {
        public string Name;
        protected int Health;

        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이 기본공격을 합니다.");
        }

        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}은 치료할 수 없습니다.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다.");
        }
    }

    class SCV : Unit
    {
        public SCV()
        {
            Name = "SCV";
            Health = 60;
        }

        public override void Attack()
        {
            Console.WriteLine("SCV가 용접기로 공격합니다");
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"SCV가 {target.Name}을 수리합니다"); ;
        }
    }

    class Marine : Unit
    {
        public Marine()
        {
            Name = "Marine";
            Health = 40;
        }

        public override void Attack()
        {
            Console.WriteLine("Marine이 소총으로 공격합니다");
        }
    }

    class Medic : Unit
    {
        public Medic()
        {
            Name = "Medic";
            Health = 50;
        }

        public override void Attack()
        {
            
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"Medic이 {target.Name}을 치료합니다");
        }
    }

    class Tank : Unit
    {
        public Tank()
        {
            Name = "Tank";
            Health = 150;
        }

        public void SeigeMode()
        {
            Console.WriteLine("시즈모드");
        }

        public override void Attack()
        {
            Console.WriteLine("Tank가 시즈모드로 공격합니다");
        }

        public override void Move()
        {
            Console.WriteLine("Tank가 천천히 움직입니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();

            units.Add(new SCV());
            units.Add(new Marine());
            units.Add(new Medic());
            units.Add(new Tank());

            foreach (var unit in units)
            { 
                unit.Move();
                unit.Attack();
                Console.WriteLine();
            }

            SCV scv = new SCV();
            scv.Heal(units[3]);

            Medic medic = new Medic();
            medic.Heal(units[1]);

            Tank t = (Tank)units[3];
            t.SeigeMode();

            if (units[3] is Unit)
                Console.WriteLine("!!!");
        }
    }
}
