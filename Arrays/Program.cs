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
            // students3[3] = "D"; // error

            foreach (string s in students)
            {
                Console.WriteLine(s);
            }

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) // 0. olan 5 kısmı
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++) // 1. olan 3 kısmı
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("********");

            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
