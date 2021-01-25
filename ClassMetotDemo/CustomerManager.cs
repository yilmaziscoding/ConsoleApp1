using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customers are added !");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customers are deleted!");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Customers are updated !");

        }

        public void ListCustomer(Customer[] customerList)
        {
            foreach (var customer in customerList )
            {
                Console.WriteLine("Customer's First Name:"+ customer.firstName );
                Console.WriteLine("Customer's Last Name:"+ customer.lastName );
                Console.WriteLine("Customer's Id:"+ customer.customerId );
            }
        }
    }
}
