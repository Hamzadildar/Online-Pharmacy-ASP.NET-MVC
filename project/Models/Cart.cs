using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace project.Models
{
    public class Cart
    {
        [Key]
        public int id { get; set; }



        public string M_Name { get; set; }



        [Display(Name = "Name"), Required]
        public string U_Name { get; set; }



        [DataType(DataType.PhoneNumber), Display(Name = "Phone No."), Required]
        [RegularExpression(@"^\(?([0-9]{2})[-. ]?([0-9]{3})[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Not a valid Phone number")]
        public string U_Contact { get; set; }


        [Required(ErrorMessage = "Address is Required"), Display(Name = "Address")]
        public string U_Address { get; set; }


        public decimal M_Price { get; set; }

        [Display(Name = "Total BILL"), Required]
        public decimal TotalBill { get; set; }

        [DataType(DataType.DateTime),Display(Name = "Order Date"), Required]
        public DateTime? OrderDate{ get; set; }
        public string PaymentMethod { get; set; }

    }
}