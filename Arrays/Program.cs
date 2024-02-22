using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "A";
            students[1] = "B";
            students[2] = "C";

            string[] students2 = new string[3]{"A", "B", "C" };
            string[] students3 = { "A", "B", "C" };
            students3[3] = "D";

            foreach (string s in students)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
