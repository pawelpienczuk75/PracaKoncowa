using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RentRoom.Models
{
    public class UserModel : IdentityUser 
    {
        public UserModel() : base()
        {

        }
        public UserModel(string login) : base(login)
        {

        }
        public string Name { get; set; }
        public int? CustomersID { get; set; }
        public int? EmployeesID { get; set; }

        [ForeignKey("CustomersID")]
        public Customers Customers { get; set; }

        [ForeignKey("EmployeesID")]
        public Employees Employees { get; set; }
    }

}
