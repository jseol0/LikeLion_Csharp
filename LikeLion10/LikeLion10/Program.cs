using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion10
{
    class Character
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        //이벤트 정의 - 캐릭터가 데미지를 입었을때 발생
        //EventGandler는 C#에서 제공하는 기본 델리게이트 타입
        //이벤트는 외부에서 직접 호출할수 없고 +=, -= 연산자로만 접근 가능
        public event EventHandler OnDamaged;
        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name}이 {amount}의 데미지를 입었습니다. 남은 체력 : {Health}");

            //이벤트 발생
            //?. 연산자는 OnDamaged 가 null이 아닐때만 Invoke 메서드 호출
            //EvantArgs.Empty는 추가 데이터가 없을때 사용하는 빈 이벤트 인자
            OnDamaged?.Invoke(this, EventArgs.Empty);
        }

    }
    internal class Program
    {
        ////delegate - 메시지 출력을 위한 메서드 참조
        ////string 매개변수를 받고 반환값이 없는 (void)메서드를 참조할 수 있는 타입
        //delegate void MessageHandler(string message);

        //static void DisplayMessage(string message)
        //{
        //    Console.WriteLine($"메시지 : {message}");
        //}

        //static void DisplayUpperMessage(string message)
        //{
        //    Console.WriteLine($"대문자 메시지 : {message.ToUpper()}");
        //}


        //이벤트핸들러 메서드
        //EventHandler 데리게이트와 일치하는 시그니처를 가져야함
        //sender : 이벤트를 발생시킨 객체(여기서는 Characterr객체)
        //e: 이벤트와 관련된 추가 데이터
        static void Hero_OnDamaged(object sender, EventArgs e)
        {
            //sender를 character 타입으로 형변환
            Character character = (Character)sender;

            Console.WriteLine($"이벤트 알림 : {character.Name}이 데미지를 입었습니다. 현재 체력 : {character.Health}");
        }


        //델리게이트와 이벤트를 더쉽게 만드는 Action
        static void SayHello()
        {
            Console.WriteLine("안녕하세요");
        }

        static void ShowNotification()
        {
            Console.WriteLine("중요한 알림이 있습니다");
        }

        static void HelloWorld(string message)
        {
            Console.WriteLine($"신규메시지 {message}");
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("간단한 델리게이트와 이벤트 예제");

            ////1.
            ////델리게이트 변수 선언 및 메서드 연결
            ////DisplayMessage 메서드를 messageHandler 변수에 할당
            //MessageHandler messageHandler = DisplayMessage;
            //messageHandler("안녕하세요");

            ////2.
            ////델리게이트에 다른 메서드 추가 (멀티캐스트 델리게이트)
            ////+=연산자로 메서드 추가
            //messageHandler += DisplayUpperMessage;

            ////여러 메서드가 연결된 델리게이트 호출
            ////등록된 모든 메서드가 순서대로 호출됨
            //Console.WriteLine("여러 메서드 호출 : ");
            //messageHandler("Hello");

            //Character hero = new Character("용사", 100);

            ////이벤트 구독 +=
            ////이벤트가 발생했을때 실행될 메서드 등록
            //hero.OnDamaged += Hero_OnDamaged;
            //hero.TakeDamage(30);

            ////이벤트 구독 취소 -=
            //hero.OnDamaged -= Hero_OnDamaged;
            //hero.TakeDamage(30);

            //Action은 매개변수가 없고 반환값이 없는 메서드를 참조
            Action sayHello = SayHello;
            sayHello += ShowNotification;
            sayHello?.Invoke();
            /*
            sayHello?.Invoke(); 를 풀어쓰면
            if (sayHello != null)
            {
                sayHello();
            }
            */

            Action<string> h = null;
            h += HelloWorld;
            h?.Invoke("이게 액션이다");

            Action noti = null;
            noti += () => Console.WriteLine("인자없는 액션이다.");
            noti?.Invoke();

            Action<int> Square = number => Console.WriteLine(number * number);
            Square(5);
        }
    }
}
