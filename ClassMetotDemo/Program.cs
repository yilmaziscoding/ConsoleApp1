using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.firstName = "Yilmaz";
            customer1.lastName = "Soysal";
            customer1.customerId = 3333;

            Customer customer2 = new Customer();
            customer2.firstName = "Engin";
            customer2.lastName = "Demirog";
            customer2.customerId = 4444;

            Customer[] customerList = new Customer[2];
            customerList[0] = customer1;
            customerList[1] = customer2;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Update(customer1);
            customerManager.Delete(customer1);
            customerManager.ListCustomer(customerList);
        }
    }
}
