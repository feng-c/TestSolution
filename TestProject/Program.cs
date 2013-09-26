using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a number :");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The result is : " + Square(num));
        }

        public static int Square(int num)
        {
            return num * num;
        }
    }
}
