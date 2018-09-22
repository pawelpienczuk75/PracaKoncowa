using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentRoom.Models
{
    public class RoomDescriptionModel
    {
        public int Id { get; set; }
        public string NameOfRomm { get; set; }
        public string IsAvailable { get; set; }
        public string SizeOfRoom { get; set; }
        public decimal FeePerHour { get; set; }

    }
}
