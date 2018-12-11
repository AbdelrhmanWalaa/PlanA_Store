using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlanA_Store.Models
{
    public class Order
    {

        public int OrderID { get; set; }
        //public int ID { get; set; }

        [Required(ErrorMessage = "You must enter the Order Number")]
        [Display(Name = "Order Number")]
        public int OrderNumber { get; set; }

        [Display(Name ="Order Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd:yyyy:mm}" , ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        public int CustomerID { get; set; }

        public Customer _Customer { get; set; }

        //public List<Product> _ProductsList { get; set; } something is wrong 

        public ICollection<OrderDetails> ProductsList { get; set; }



    }
}
