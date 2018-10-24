using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentRoom.ViewModels
{
    public class ListRentsViewModel
    {
        public int Id { get; set; }
        public string DateOfEvent { get; set; }
        public string NameOfRoom { get; set; }
        public string HourEvent { get; set; }

    }
}
