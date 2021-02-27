using System;

namespace Classes
{
    class Program
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
            customer.City = "Kayseri";
            customer.Id = 1;
            customer.FirstName = "Bengisu";
            customer.LastName = "Taşkın";
            //SET BLOĞU
            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Fatmanur",
                LastName = "Taşkın"

            };
            Console.WriteLine(customer2.FirstName);
            //GET BLOĞU
            Console.ReadLine();
        }
    }

  
 
    

    
}
