using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
   public class CustomerCheckManager:IPersonCheckService
    {
     
        public bool CheckIfRealPerson(Customer customer)
        {
            //siteyi yükledikten sonra
            //
        }
    }
}
