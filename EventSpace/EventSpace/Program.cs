using System;

namespace EventSpace
{


    public class Calculator
    {
        public int addNumbers (int a, int b)
        {
            return a + b;


        }


    }


    public class Program
    {
        static void Main(string[] args)
        {

            var c = new Calculator();
           Console.WriteLine( c.addNumbers(1, 2).ToString());
            

            Console.WriteLine("Hello World!");


            Console.ReadLine();

        }
    }
}
