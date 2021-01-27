using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace project.Models
{
    public class Medicine
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Medicine Name is Required"), Display(Name = "Name")]
        public string M_Name { get; set; }

        [Required]
        public string Image{ get; set; }


        [Required(ErrorMessage = "Company Name is Required"), Display(Name = "Company Name")]
        public string M_Company { get; set; }


        [Required(ErrorMessage = "MEDICINE Type is Required"), Display(Name = "Type")]
        public string M_Type { get; set; }

        [Required(ErrorMessage = "Medicine Potency is Required"), Display(Name = "Potency")]
        public string M_Potency { get; set; }

        [Display(Name = "Details"), Required]
        public string M_Details { get; set; }

        [Required(ErrorMessage = "Medicine Price is Required"), Display(Name = "Price")]
        public decimal M_Price { get; set; }
       


    }
}