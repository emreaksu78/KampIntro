using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Emre";
            customer1.LastName = "AKSU";
            customer1.TcNo = "22222222222";

            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "45678";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "444555666";

            Customer customer3 = new Individual();
            customer3.CustomerNumber = "5465446";
            Customer customer4 = new Corporate();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);





            //Gerçek Müşteri - Tüzel Müşteri faklı olduğu için ikisi için farklı class olmalı. Çünkü ileride yanlış veri girişi olduğu zaman tüzel ve gerçek müşteriler karışabilir.

        }
    }
}
