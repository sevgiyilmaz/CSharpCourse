using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface Iperson
    {
        int Id { get; set; }
        int Firstname { get; set; }
        int Lastname { get; set; }
    }

    class Customer : Iperson
    {
        public int Id { get; set; }
        public int Firstname { get; set ; }
        public int Lastname { get; set ; }

        public string Address { get; set ; }
    }

    class Student : Iperson
    {
        public int Id { get; set; }
        public int Firstname { get; set; }
        public int Lastname { get; set; }

        public string Department { get; set; }
    }
}
