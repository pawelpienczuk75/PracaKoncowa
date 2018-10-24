using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace RentRoom.Classes
{
    public class ConfigHour
    {
        public string StartHour { get; set; }
        public string EndHour { get; set; }

        public string GetStartHours()
        {
            string[] temp = File.ReadAllLines("appsettings.xml");
            string temp1 = temp[5];
            temp1 = temp1.Substring(13, 2);
            return temp1;
        }

        public string GetEndHours()
        {
            string[] temp = File.ReadAllLines("appsettings.xml");
            string temp1 = temp[6];
            temp1 = temp1.Substring(12, 2);
            return temp1;
        }
    }
}
