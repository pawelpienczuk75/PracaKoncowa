using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string StateOfReservation { get; set; }
        public int? CustomersId { get; set; }
        public int? EmployeesId { get; set; }
        public int? RoomWeekScheduleId { get; set; }
        public int? RoomDescriptionModelId { get; set; }

        [ForeignKey("CustomersId")]
        public Customers Customers { get; set; }
        [ForeignKey("EmployeesId")]
        public Employees Employees { get; set; }
        [ForeignKey("RoomWeekScheduleId")]
        public RoomWeekSchedule RoomWeekSchedule { get; set; }
        [ForeignKey("RoomDescriptionModelId")]
        public RoomDescriptionModel RoomDescriptionModel { get; set; }
        



    }
}
