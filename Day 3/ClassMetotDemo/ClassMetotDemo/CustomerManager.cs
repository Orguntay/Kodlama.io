using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void GetCustomerList()
        {
            foreach (var item in customers) // custumer olmadığı için hata vereceğini düşünüyorum
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Müşteri Adı :" + item.Name);
                Console.WriteLine("Müşteri Soyadı :" + item.Surname);
            }
        }
        public void DeleteCustomer(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine(customer.Name + " " + customer.Surname + " Has been deleted successfully");
        }
        public void UpdateCustomer(Customer customer)
        {
            customer.Surname = customer.Surname + " UPDATED";
            customers.FirstOrDefault(x => x.Id == customer.Id).Surname = customer.Surname;
            Console.WriteLine(customer.Name + " " + customer.Surname + " Has been updated successfully");
        }
    }
}
