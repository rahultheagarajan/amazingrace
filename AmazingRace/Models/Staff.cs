using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AmazingRace.Models
{
    public class Staff
    {
        [Required(ErrorMessage ="Staff ID is Mandatory")]
        public int StaffID { get; set; }
        [Required(ErrorMessage = "Staff Name is Mandatory")]
        [DisplayName("Staff Name ")]
        public string StaffName { get; set; }
        [DisplayName("Email ID ")]
        [Required(ErrorMessage = "Email ID is Mandatory")]
        public string EmailID { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        [NotMapped]
        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Re-Enter your Password")]
        [Compare("Password",ErrorMessage ="Password doesn't match, Type Again !!" )]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}