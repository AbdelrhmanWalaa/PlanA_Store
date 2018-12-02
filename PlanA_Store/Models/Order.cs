using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanA_Store.Models
{
    public class Order
    {

        public int OrderID { get; set; }
        //public int ID { get; set; }

        public int OrderNumber { get; set; }

        public int OrderDate { get; set; }

        public int CustomerID { get; set; }

        public Customer _Customer { get; set; }

        public List<Product> _ProductsList { get; set; }


    }
}
