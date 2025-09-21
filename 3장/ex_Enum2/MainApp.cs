using System;

namespace ex_Enum2
{
    internal class MainApp
    {

        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

        static void Main(string[] args)
        {
            DialogResult result = DialogResult.YES;

            Console.WriteLine(result == DialogResult.YES);  // True
            Console.WriteLine(result == DialogResult.NO);   // False
            Console.WriteLine(result == DialogResult.CANCEL);   // False
            Console.WriteLine(result == DialogResult.CONFIRM);  // False
            Console.WriteLine(result == DialogResult.OK);   // False
        }
    }
}
