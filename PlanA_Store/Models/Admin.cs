using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanA_Store.Models
{
    public class Admin
    {

        public int AdminID { get; set; }
        //public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public List<Product> _ProductsList { get; set; }

    }
}
