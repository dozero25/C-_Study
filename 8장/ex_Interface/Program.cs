using System;
using System.IO;

namespace ex_Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(
                "{0} {1}",
                DateTime.Now.ToLocalTime(), message
                );
        }
    }

    class FileLogger : ILogger 
    {
        private StreamWriter writer;

        public FileLogger(string path)
        { 
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    { 
        private ILogger logger;

        public ClimateMonitor(ILogger logger)
        { 
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력해주세요. : ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;
                logger.WriteLog("현재 온도 : " + temperature);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor( new FileLogger("MyLog.txt"));

            monitor.start();
            /*
            온도를 입력해주세요. : 34
            온도를 입력해주세요. : 28
            온도를 입력해주세요. : 77
            온도를 입력해주세요. :
             */

            /*
            MyLog.txt 파일 내용
            온도를 입력해주세요. : 34
            온도를 입력해주세요. : 28
            온도를 입력해주세요. : 77
             */

            /*
            인터페이스
            : 클래스가 어떤 동작을 반드시 제공해야하는지 약속하는 설계서
            : 클래스나 구조체가 특정 기능을 반드시 제공하도록 형태만 정의한 추상적인 계약서

            특징
            : 다중 상속 가능 - 클래스는 단일 상속만 가능하지만, 인터페이스는 여러 개를 한 번에 구현 가능
            : 구현 강제 - 인터페이스에 정의된 모든 멤버를 반드시 구현해야 함
            : 접근 제한자 불가 - 인터페이스의 멤버는 기본적으로 전부 public 이다
            : 상태(필드) 가질 수 없음 - 인터페이스에는 필드를 선언할 수 없다 (단, C# 8 이후 일부 예외 존재)
            : 객체 생성 불가 - 인터페이스 자체로는 객체를 만들 수 없다 (new 불가)
             
            구현 예시
            public interface IAttackable
            {
                void Attack();
            }

            public class Warrior : IAttackable
            {
                public void Attack()
                {
                    Console.WriteLine("전사가 검으로 공격한다!");
                }
            }

            public class Archer : IAttackable
            {
                public void Attack()
                {
                    Console.WriteLine("궁수가 화살을 쏜다!");
                }
            }

             
             */

        }
    }
}


