using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentRoom.ViewModels
{
    public class RegisterViewModel
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

        public string NameOfCustomer { get; set; }
        public string PhoneNumber { get; set; }
        public string NameOfComany { get; set; }
        public string Citi { get; set; }
        public string Street { get; set; }
        public string NIP { get; set; }
    }
}
