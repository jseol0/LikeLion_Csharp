using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1
            Console.WriteLine("clone test"); // 변수에 저장된 값을 출력
            */

            /*2
            // 문자열
            string greeting;
            greeting = "Hello, World";

            // 변수의 값을 사용
            Console.WriteLine(greeting);
            */

            /*3
            //캐릭터
            //hp : 100
            //att : 56.7
            //캐릭터이름 : ??
            //등급 : s;

            string name = "Alice";
            int hp = 100;
            double att = 56.7;
            char grade = 's';

            // 1. 문자열 보간법
            // 연산이 더 빠르고 효율적
            Console.WriteLine("status");

            Console.WriteLine($"name : {name}");
            Console.WriteLine($"hp : {hp}");
            Console.WriteLine($"att : {att}");
            Console.WriteLine($"grade : {grade}");

            Console.Write("\n\n\n");

            // 2. + 연산자
            // + 연산자는 문자열을 계속 새로운 문자열로 할당하기 때문에, 성능이 조금 떨어짐
            Console.WriteLine("status");

            Console.WriteLine("name : " + name);
            Console.WriteLine("hp : " + hp);
            Console.WriteLine("att : " + att);
            Console.WriteLine("grade : " + grade);
            */

            /*4
            // 문자열
            string greeting;
            greeting = "Hello, World";

            // 변수의 값을 사용
            Console.WriteLine(greeting);

            //변수 선언과 초기화를 한번에 수행
            int score = 100;
            double temperature = 36.5;
            string city = "Seoul";

            Console.WriteLine(score);
            Console.WriteLine(temperature);
            Console.WriteLine(city);

            // 같은 데이터 타입의 변수 선언
            int x = 10, y = 20, z = 30;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


            // 상수 사용하기
            // 고정된 값으로, 중요한 값이 변경되는 것을 방지
            // 선언과 동시어 초기화 해야함!

            const double Pi = 3.141592;
            const int MaxScore = 100;

            // Pi = 1.1; X 수정 불가
            Console.WriteLine($"Pi : {Pi}");
            Console.WriteLine($"Max Score : {MaxScore}");
            */

            /*
            int att = 16755;
            int maxHp = 78103;

            int c1 = 36;
            int c2 = 1017;
            int c3 = 41;
            int c4 = 611;
            int c5 = 22;
            int c6 = 39;

            Console.WriteLine("기본 특성");
            Console.WriteLine($"공격력 : {att}");
            Console.WriteLine($"최대 생명력 : {maxHp}");
            Console.WriteLine("전투 특성");
            Console.WriteLine($"치명 : {c1}");
            Console.WriteLine($"특화 : {c2}");
            Console.WriteLine($"제압 : {c3}");
            Console.WriteLine($"신속 : {c4}");
            Console.WriteLine($"인내 : {c5}");
            Console.WriteLine($"숙련 : {c6}");
            */



            /* 숫자데이터 형식
            int intergerNum = 10;        // 정수 데이터
            float floatNum = 3.14f;     // 단정밀도 실수
            double doubleNum = 3.14159; // 배정밀도 실수

            Console.WriteLine($"{intergerNum} {floatNum} {doubleNum}");

            // 정수 데이터
            int intValue = -100;    // 4byte 크기의 정수
            long longValue = 1234L;  // x64 에서는 8byte

            Console.WriteLine(intValue);
            Console.WriteLine(longValue);

            // 부호 있는 정수
            sbyte signedByte = -50; // 1byte
            short signedShort = -32000; // 2byte
            int signedInt = -2000000000; // 4byte

            Console.WriteLine(signedByte);
            Console.WriteLine(signedShort);
            Console.WriteLine(signedInt);

            // 부호 없는 정수
            byte unsignedByte = 255; // 1byte
            ushort unsignedShort = 65000; // 2byte
            uint unsignedInt = 4000000000; // 4byte

            Console.WriteLine(unsignedByte);
            Console.WriteLine(unsignedShort);
            Console.WriteLine(unsignedInt);


            //실수 데이터
            float singlePrecision = 3.14f; // 단정밀도 실수 4byte
            double doublePrecision = 3.1415926535; // 배정밀도 실수 8byte
            decimal highPrecision = 3.1415926535897932384626433833m; // 고정밀도 16byte
            
            Console.WriteLine(singlePrecision);
            Console.WriteLine(doublePrecision);
            Console.WriteLine(highPrecision);
            */

            ////숫자 형식의 리터럴 값에 접미사 붙이기
            //int intergerValue = 100;
            //long longValue = 100L;
            //float floatValue = 3.14f;
            //double doubleValue = 3.14;
            //decimal decimalValue = 3.14m;

            //Console.WriteLine(intergerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);


            /*
            // 문자 데이터 형식
            char letter = 'A';
            char symbol = '#';
            char number = '9'; // 숫자x 문자'9'

            Console.WriteLine(letter);
            Console.WriteLine(symbol);
            Console.WriteLine($"{number} {number.GetTypeCode()}");

            string greeting = "Hello World";
            string name = "Alice";

            Console.WriteLine($"{greeting} {name}");

            // 논리 데이터 형식
            bool isRunning = true;
            bool isFinished = false;

            Console.WriteLine(isRunning);
            Console.WriteLine(isFinished);


            // 상수 데이터
            const double PI = 3.141592;
            const int MAXSCORE = 100;

            Console.WriteLine(PI);
            Console.WriteLine(MAXSCORE);
            //MAXSCORE = 200; error
            */


            // wrapper 형식의 메서드 활용
            //래퍼 형식은 기본 데이터 형식을 클래스 형태로 감싸서 객체로 취급할 수 있게 한다
            //int number = 123;
            //string numberAsString = number.ToString();

            //bool flag = true;
            //string flagAsString = flag.ToString();

            //Console.WriteLine($"{numberAsString} {numberAsString.GetType()}");
            //Console.WriteLine($"{flagAsString} {flagAsString.GetType()}");


            //문자열 입력
            //Console.ReadLine();
            //Console.Write("이름을 입력하세요 : ");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"안녕하세요, {userName}님");

            //Console.Write("나이를 입력하세요 : ");
            //int age = int.Parse( Console.ReadLine() );
            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요");

            /* 스테이터스 입력받아 출력하기
            Console.WriteLine("정보를 입력해 주세요");
            Console.Write("루인 스킬 피해 : ");
            double input1 = double.Parse(Console.ReadLine());
            Console.Write("카드 게이지 획득량 : ");
            double input2 = double.Parse(Console.ReadLine());
            Console.Write("각성기 피해 : ");
            double input3 = double.Parse(Console.ReadLine());
            Console.Write("최대 마나 : ");
            int input4 = int.Parse(Console.ReadLine());
            Console.Write("전투 중 마나 회복량 : ");
            int input5 = int.Parse(Console.ReadLine());
            Console.Write("비전투 중 마나 회복량 : ");
            int input6 = int.Parse(Console.ReadLine());
            Console.Write("이동 속도 : ");
            double input7 = double.Parse(Console.ReadLine());
            Console.Write("탈 것 속도 : ");
            double input8 = double.Parse(Console.ReadLine());
            Console.Write("운반 속도 : ");
            double input9 = double.Parse(Console.ReadLine());
            Console.Write("스킬 재사용 대기시간 감소 : ");
            double input10 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("활동");
            Console.WriteLine($"루인 스킬 피해 : {input1}%");
            Console.WriteLine($"카드 게이지 획득량 : {input2}%");
            Console.WriteLine($"각성기 피해 : {input3}%");
            Console.WriteLine($"최대 마나 : {input4}");
            Console.WriteLine($"전투 중 마나 회복량 : {input5}");
            Console.WriteLine($"비전투 중 마나 회복량 : {input6}");
            Console.WriteLine($"이동 속도 : {input7:F1}%");
            Console.WriteLine($"탈 것 속도 : {input8:F1}%");
            Console.WriteLine($"운반 속도 : {input9:F1}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 : {input10}%");
            */


        }
    }
}
