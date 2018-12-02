using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanA_Store.Models
{
    public class OrderDetails
    {

        public int OrderDetailsID { get; set; }
        //public int ID { get; set; }

        public int Quantity { get; set; }

        public int OrderID { get; set; }

        public Order _Order { get; set; }
        //navigation property

        public int ProductID { get; set; }

        public Product _Product { get; set; }
        //navigation property

    }
}
