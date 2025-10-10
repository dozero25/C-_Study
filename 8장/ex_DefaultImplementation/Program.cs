using System;

namespace ex_DefaultImplementation
{
    interface ILogger
    {
        void WriteLog(string message);

        void WriteError(string error)
        { 
            WriteLog($"Error : {error}");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(
                $"{DateTime.Now.ToLocalTime()}, {message}"
                );
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System Up");       // 2025 - 10 - 10 금 오후 9:19:45, System Up
            logger.WriteError("System Down");   // 2025-10-10 금 오후 9:19:45, Error: System Down

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System Up");      // 2025-10-10 금 오후 9:19:45, System Up
            //clogger.WriteError("System Down"); 컴파일 에러 발생
        }
    }
}


