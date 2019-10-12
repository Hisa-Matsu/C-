using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.swap_2_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, swap;
            Console.Write("Enter the First Number: ");
            string s = Console.ReadLine();
            num1 = int.Parse(s);

            Console.Write("Enter the Second Number: ");
            string s2 = Console.ReadLine();
            num2 = int.Parse(s2);

            swap = num1;
            num1 = num2;
            num2 = swap;

            Console.WriteLine("First Number: {0}", num1);
            Console.WriteLine("Second Number: {0}", num2);
        }
    }
}
