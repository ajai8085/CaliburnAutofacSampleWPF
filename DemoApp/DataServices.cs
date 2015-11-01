using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public class DataServices
    {
        public List<Customer> GetCustomers()
        {
            return new List<Customer> {
                new Customer { Age=44, FirstName="Joe", LastName="Mrk" },

                new Customer { Age=44, FirstName="Joe", LastName="Mrk" },

                new Customer { Age=44, FirstName="Joe", LastName="Mrk" },

                new Customer { Age=44, FirstName="Joe", LastName="Mrk" }
            };
        }
    }


    public class Customer
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public int Age { get; set; }
    }
}
