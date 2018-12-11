using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlanA_Store.Models
{
    public class Product
    {


        public int ProductID { get; set; }
        //public int ID { get; set; }

        [Required(ErrorMessage = "You must enter the Product Name")]
        [Display(Name = "Product Name")]
        [StringLength(50,ErrorMessage ="Product Name is too large")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "You must enter the Unit Price")]
        [Display(Name = "Unit Price")]
        [Column(TypeName ="decimal(5,2)")]
        public decimal UnitPrice { get; set; }

        public int AdminID { get; set; }

        public Admin _Admin { get; set; }
        //navigation property

       // public List<Order> _OrdersList { get; set; } something is wrong 

        public ICollection<OrderDetails> OrdersList { get; set; }



    }
}
