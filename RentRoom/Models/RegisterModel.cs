using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentRoom.Models
{
    public class RegisterModel
    {
        public int Id { get; set; }

        [Required]
        public string Login { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Hasła muszą być identyczne")]
        public string RepeatPassword { get; set; }
    }
}
