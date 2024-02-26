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
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2] 
            {    
                new SqlServerCustomerDal(), 
                new OracleCustomerDal() 
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, Firstname = "Sevgi", Lastname = "Yılmaz", Address = "İst" });
            manager.Add2(new Customer { Id = 1, Firstname = "Sevgi", Lastname = "Yılmaz", Address = "İst" });

            // ya da bu şekilde yazılabilirdi
            Student student = new Student
            {
                Id = 2,
                Firstname = "Sevgi",
                Lastname = "Yılmaz",
                Department = "Comp Sciences"
            };

            manager.Add2(student);
        }
    }

    interface Iperson
    {
        int Id { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
    }

    class Customer : Iperson
    {
        public int Id { get; set; }
        public string Firstname { get; set ; }
        public string Lastname { get; set ; }

        public string Address { get; set ; }
    }

    class Student : Iperson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add (Customer customer)
        {
            Console.WriteLine(customer.Firstname);
        }   

        public void Add2 (Iperson person) // interface ile hem student hem customer verebilirim
        {
            Console.WriteLine(person.Firstname);
        }
    }
}
