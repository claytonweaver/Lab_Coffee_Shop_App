using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_18_Coffee_Shop.Models
{
    public class User
    {
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Must be between 3 and 30 characters.")]
        public string UserName { get; set; }
        [Required]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]\w{3,14}$")]
        public string Password { get; set; }
    }
}
