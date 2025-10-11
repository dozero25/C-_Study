using System;

namespace ex_PropertiesInAbstractClass
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return String.Format("{0:d5}", serial++); }
        }
        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate 
        { 
            get; 
            set; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product_1 = new MyProduct() { ProductDate = new DateTime(2023, 1, 10) };
            Console.WriteLine($"Product: {product_1.SerialID}, Product Date: {product_1.ProductDate}");
            // Product: 00000, Product Date: 2023-01-10 화 오전 12:00:00

            Product product_2 = new MyProduct() { ProductDate = new DateTime(2023, 2, 3) };
            Console.WriteLine($"Product: {product_2.SerialID}, Product Date: {product_2.ProductDate}");
            // Product: 00001, Product Date: 2023-02-03 금 오전 12:00:00
        }
    }
}
