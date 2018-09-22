using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentRoom.Models
{
    public class RoomRentModel
    {
        public int Id { get; set; }
        public string NameOfEvent { get; set; }
        public string DateOfEvent { get; set; }
        public string HourOfBeginEvent { get; set; }
        public string HourOfEndEvent { get; set; }
        public string CreatedByUser { get; set; }
        public string CreatedByChanel { get; set; }
        public string CreatedDate { get; set; }
        public string OwnerOfEvent { get; set; }
        public string IsConfirm { get; set; }
        public string StateOfReservation { get; set; }
        public string IsSettement { get; set; }  //Czy zostało rozliczone.


    }
}
