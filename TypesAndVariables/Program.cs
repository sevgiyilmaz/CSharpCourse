﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10; 
            long number2 = 2782973;
            short number3 = 32675;
            byte number4 = 255;
            bool condition = false;
            char character = 'a';
            double number5 = 21.4;
            decimal number6 = 21.4M;
            var number7 = 10;
            number7 = 'A';

            Console.WriteLine("Number is {0} {1} ", number1,number2);
            Console.WriteLine("Character is : {0} ", (int)character);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,Sunday
    }
}
