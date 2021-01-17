using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Oluiturulan müşteriler
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Atakan Cevat";
            customer1.Surname = "COŞKUNDERE";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Aleyna";
            customer2.Surname = "Tilki";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Ben";
            customer3.Surname = "FERO";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Killa";
            customer4.Surname = "HAKAN";

            CustomerManager customerManager = new CustomerManager();

            // Müşterilerin eklendiği methodlar
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);
            customerManager.AddCustomer(customer4);


            // Müşterilerin silindiği metodlar
            //customerManager.DeleteCustomer(customer2);

            ////Müşterilerin Güncellendiği metodlar
            customerManager.UpdateCustomer(customer3);

            //Tüm müşterilerin gösterilmesi
            customerManager.GetCustomerList();

        }
    }
}
