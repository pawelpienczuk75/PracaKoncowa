using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentRoom.ViewModels
{
    public class CustomerEditVievModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string NameOfCustomer { get; set; }
        public string PhoneNumber { get; set; }
        public string NameOfComany { get; set; }
        public string Citi { get; set; }
        public string Street { get; set; }
        public string NIP { get; set; }
    }
}
