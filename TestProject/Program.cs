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

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Operation Square");
                        break;
                    case 2:
                        Console.WriteLine("Operation Cube");
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
    }
}
