﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Test";
            customer.LastName = "Test2";
            customer.City = "Ankara";

            Customer customer2 = new Customer 
            {
                Id = 2, City = "İstanbul", FirstName="A", LastName="B"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
