using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion9_3
{
    //C# 인터페이스(Interface)
    //클래스나 구조체에서 구현해야하는 메서드, 속성 등을 정의하는 추상적인 개념
    //즉, 어떤 기능을 반드시 포함하도록 강제하는 역할
    //특징
    //interface 키워드를 사용해서 정의
    //추상 메서드만 포함(구현x) -> 인터페이스를 구현하는 클래승서 반드시 구현해야함
    //다중 상속 가능(c#에서는 클래스 다중상속이 불가능하지만, 인터페이스는 여러개 구현 가능)
    //객체를 생성할수 없음(추상클래스와 유사)

    ////인터페이스 정의
    //interface IAinmal
    //{
    //    void MakeSound();   //인터페이스의 메서드(구현 x)
    //}

    ////인터페이스 구현(클래스에서 반드시 구현해야함)
    //class Dog : IAinmal
    //{
    //    public void MakeSound()
    //    {
    //        Console.WriteLine("멍멍");
    //    }
    //}

    //class Cat : IAinmal
    //{
    //    public void MakeSound()
    //    {
    //        Console.WriteLine("야옹");
    //    }
    //}


    //인터페이스를 활용하면 객체가 어떤 특정한 동작을 보장하면서도 다양한 형태로 사용
    //여러 동물을 공통된 방식으로 다룰수 있다
    //Train(IAnimal animal) 메서드는 Dog, Cat 모두를 받을 수 있음 → 코드 재사용성 증가
    //추가적인 IAnimal을 구현한 새로운 동물이 생기더라도 Train() 메서드는 변경할 필요 없음 → 유지보수 용이

    ////인터페이스 정의
    //interface IAnimal
    //{
    //    void Speak();
    //}

    //class Dog : IAnimal
    //{
    //    public void Speak()
    //    {
    //        Console.WriteLine("멍멍");
    //    }
    //}

    //class Cat : IAnimal
    //{
    //    public void Speak()
    //    {
    //        Console.WriteLine("야옹");
    //    }
    //}

    //class AnimalTrainer
    //{
    //    public void Train(IAnimal animal)
    //    {
    //        Console.WriteLine("동물이 소리를 냅니다");
    //        animal.Speak();
    //    }
    //}


    interface IPayment
    {
        void ProcessPayment();
    }

    class CreditCardPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("신용카드 결제 완료");
        }
    }

    class PayPalPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("PayPal 결제 완료");
        }
    }

    class PaymentProcessor
    {
        public void Pay(IPayment payment)
        { 
            payment.ProcessPayment();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //IAinmal dog = new Dog();
            //IAinmal cat = new Cat();

            //dog.MakeSound();
            //cat.MakeSound();

            //AnimalTrainer trainer = new AnimalTrainer();
            //IAnimal dog = new Dog();
            //IAnimal cat = new Cat();

            //trainer.Train(dog);
            //trainer.Train(cat);

            PaymentProcessor processor = new PaymentProcessor();
            IPayment creditCard = new CreditCardPayment();
            IPayment paypal = new PayPalPayment();

            processor.Pay(creditCard);
            processor.Pay(paypal);
        }
    }
}
