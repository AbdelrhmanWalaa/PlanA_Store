using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanA_Store.Models
{
    public class Customer
    {

        public int CustomerID { get; set; }
        //public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public List<Order> _ListofOrders { get; set; }

    }
}
