using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlanA_Store.Models
{
    public class Customer
    {

        public int CustomerID { get; set; }
        //public int ID { get; set; }

        [Required(ErrorMessage = "You must enter your First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must enter your Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must enter your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must enter your Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You must enter your Address")]
        public string Address { get; set; }

        public List<Order> _ListofOrders { get; set; }

    }
}
