using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentRoom.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string NameOfCustomer { get; set; }
        public string EmailOfCustomer { get; set; }
        public string PhoneNumber { get; set; }
        public string NameOfComany { get; set; }
        public string Citi { get; set; }
        public string Street { get; set; }
        public string NIP { get; set; }

        public ICollection<RoomDescriptionModel> DepencyCollectionRoomDescriptionModels { get; set; }
    }
}
