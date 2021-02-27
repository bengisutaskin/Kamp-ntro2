using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {   //FİELD-değişken
        //Property-özellik
        public int Id { get; set; }
        public string FirstName { get; set; }
        //private string _firstName;
        //public string FirstName 
        //{
        //    get  { return "MRS."+ _firstName; }
        //    set { _firstName = value; }
        //}
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
