using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace project.Models
{
    public class Admin
    {
        public int id { get; set; }

        [Display(Name ="Name"), Required]
        public string A_Name { get; set; }

        [Required(ErrorMessage = "Email ID is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "UserName is Required"), Display(Name = "User Name")]
        public string A_UserName { get; set; }
       

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string A_Password { get; set; }

        [DataType(DataType.Password), Display(Name = "Confirm Password"), Compare("A_Password"), NotMapped]
        public string C_Password { get; set; }


        [RegularExpression("^[0-9+]{5}-[0-9+]{7}-[0-9]{1}$")]
        [Required]
        [Display(Name = "CNIC")]
        public string A_Cnic { get; set; }

      

    }
}