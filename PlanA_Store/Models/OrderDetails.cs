using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlanA_Store.Models
{
    public class OrderDetails
    {
        [Required(ErrorMessage ="You must enter Order Quantity")]
        public int Quantity { get; set; }
        
        [Display(Name ="Order ID")]
        public int OrderID { get; set; }

        public Order _Order { get; set; }
        //navigation property

        public int ProductID { get; set; }

        public Product _Product { get; set; }
        //navigation property

    }
}
