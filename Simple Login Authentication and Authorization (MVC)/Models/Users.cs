using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Simple_Login_Authentication_and_Authorization__MVC_.Models
{
     [Table("Users")]
    public class Users
    {
        [Key]
        [Required]
        [Display(Name ="Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string UserEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
    }
}