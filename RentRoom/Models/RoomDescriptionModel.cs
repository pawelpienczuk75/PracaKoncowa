using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Newtonsoft.Json.Serialization;

namespace RentRoom.Models
{
    public class RoomDescriptionModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę o podanie nazwy sali")]
        public string NameOfRoom { get; set; }

        [Required(ErrorMessage = "Proszę o podanie statusu sali")]
        public string IsAvailable { get; set; }

        [Required(ErrorMessage = "Proszę o podanie rozmiaru sali")]
        public string SizeOfRoom { get; set; }


       // [Range(1, 1000, ErrorMessage = "Proszę o podanie stawki za wynajem sali")]
        public decimal FeePerHour { get; set; }


        public Customers Customers { get; set; }
        public ICollection<RoomRentModel> DepencyCollectionRoomDescriptionModels { get; set; }
        public ICollection<RoomWeekSchedule> DepencyCollectionRoomWeekSchedules { get; set; }

    }
}
