using System;

namespace ex_Enum
{
    internal class MainApp
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);   // 0
            Console.WriteLine((int)DialogResult.NO);    // 1
            Console.WriteLine((int)DialogResult.CANCEL);// 2
            Console.WriteLine((int)DialogResult.CONFIRM);// 3
            Console.WriteLine((int)DialogResult.OK);    // 4



        }
    }
}
