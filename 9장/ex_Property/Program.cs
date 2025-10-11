using System;

namespace ex_Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        { 
            get { return name; } 
            set { name = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public int Age
        {
            get {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            /*
            Name : 서현
            Birthday : 1991-06-28 금
            Age : 35
             */

            /*
            프로퍼티
            : 필드에 접근할 때 메서드처럼 제어할 수 있게 만든 문법적 장치
            
            장점
            : 캡슐화 -> 필드에 접근하지 않고 get/set 로직을 통제할 수 있음
            : 검증 가능 -> set에서 유효성 검사 가능
            : 코드 유지보수 용이 -> 나중에 필드 대신 계산 로직을 넣어도 외부 코드는 안바뀜
            : 데이터 바인딩 / 직렬화 호환성 -> WPF, JSON, EF 등 대부분의 .NET 프레임워크가 프로퍼티를 기준으로 동작
            : 가독성 -> 메서드보다 짧고 자연스러움

            예시 코드
            public class Account
            {
                private int _balance;

                public int Balance
                {
                    get { return _balance; }
                    set
                    {
                        if (value < 0)
                            throw new ArgumentException("잔액은 음수가 될 수 없습니다.");
                        _balance = value;
                    }
                }
            }

            필드(Field)        : 단순히 값을 저장 -> private int age;
            프로퍼티(Property) : 값을 읽고 쓸 때 로직 제어 가능 -> public int Age( get; set; )
            메서드(Method)     : 행동이나 연산 수행 -> public void Run()

            메서드보다 프로퍼티를 많이 사용하는 이유
            : API가 더 안정적이고 변경에 잘함(필드 -> 로직 변경 가능)
            : UI 바인딩 / 직렬화 / ORM / 리플렉션 등과 자연스럽게 연동
            : 코드 가독성 및 의도 전달이 명확함
            : C#의 생태계(.NET, 라이브러리들)가 프로퍼티 중심으로 설계되어 있어 관습적으로 더 자주 쓰임

            언제 메서드를 사용하는가?
            : 작업이 비싸다(I/O, 긴 계산, DB/네트워크)
            : 부작용이 발생한다(상태 변경, 파일/DB 쓰기)
            : 파라미터가 필요하거나 동작이 커스터마이징해야 한다.
            : 호출이 명확히 행동을 의미하거나 API 사용자가 혼동하지 않는다.(Save, Load, Compute, Send 등)

            대략적인 가이드?
            : if / else, 한 두줄 저옫의 연산이면 프로퍼티 O
            : DB, 파일, API, async, loop, try-catch가 들어가면 프로퍼티 X
             */
        }
    }
}
