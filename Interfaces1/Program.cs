using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            //İnterface metot
            //PersonManager manager = new PersonManager();
            ////Customer customer = new Customer(); böyle de olur aşağıdaki gibi de
            //manager.Add(new Customer { Id = 1, FirstName = "Bengisu", LastName = "Taşkın", Adress = "Kayseri" });
            //Student student = new Student
            //{
            //    Id = 2,
            //    FirstName = "Nursu",
            //    LastName = "Taşkın",
            //    Department = "Com*puter Science",
            //};
            //manager.Add(student);

            //demo metot
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal(),
            };


            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }
    }

    interface IPerson
    {
         int Id { get; set; }
        string FirstName{ get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
