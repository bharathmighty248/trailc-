using System;

namespace trail
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;
            Console.WriteLine("please enter the Number1");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the Number2");
            Num2 = Convert.ToInt32(Console.ReadLine());
            int Product;
            Product = Num1 * Num2;
            Console.WriteLine("Product of two numbers:" + Product.ToString());
        }
    }
}
