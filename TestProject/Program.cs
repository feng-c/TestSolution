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
            while (true)
            {
                Console.WriteLine("Please select the operation :");
                Console.WriteLine("1.Square    2.Cube    9.Exit");

                int option = Int32.Parse(Console.ReadLine());
                int num = 0;

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please input a number :");
                        num = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("The result is : " + Square(num));
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Please input a number :");
                        num = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("The result is : " + Cube(num));
                        Console.WriteLine();
                        break;
                    case 9:
                        Console.WriteLine("End Program");
                        return;
                    default:
                        Console.WriteLine("Operation Error");
                        break;
                }
            }
        }


        public static int Cube(int num)
        {
            return num * num * num;
        }

        public static int Square(int num)
        {
            return num * num;
        }
    }
}
