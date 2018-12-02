using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanA_Store.Models
{
    public class Product
    {


        public int ProductID { get; set; }
        //public int ID { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int AdminID { get; set; }

        public Admin _Admin { get; set; }
        //navigation property

        public List<Order> _OrdersList { get; set; }



    }
}
