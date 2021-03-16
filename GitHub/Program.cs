using System;

namespace example1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;
            
            Console.WriteLine("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());
            
 multiplicationBranch
            Console.WriteLine($"Processing the multiplication of: {a} times {b} = {multiplyNumbers (a,b)}");
 master
        }
        
        public static int multiplyNumbers(int a, int b)
        {

            return a * b;
        }
    }
}
