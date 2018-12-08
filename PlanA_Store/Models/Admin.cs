using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlanA_Store.Models
{
    public class Admin
    {

        public int AdminID { get; set; }
        //public int ID { get; set; }

        [Required(ErrorMessage ="You must enter your First Name")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must enter your Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must enter your Password")]
        public string Password { get; set; }

        public List<Product> _ProductsList { get; set; }

    }
}
