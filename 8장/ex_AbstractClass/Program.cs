using System;

namespace ex_AbstractClass
{
    abstract class AbstractBase
    { 
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void PublicMethodA() {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractMehodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMehodA()
        {
            Console.WriteLine("Derived.AbstractMehodA()");
            PrivateMethodA();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMehodA();
            Console.WriteLine();
            obj.PublicMethodA();

            /*
            Derived.AbstractMehodA()
            AbstractBase.PrivateMethodA()

            AbstractBase.PublicMethodA()
             */
        }
    }
}
