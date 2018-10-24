using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace RentRoom.Classes
{
    public class DateTimeManage
    {
        //public string[] fourWeeks = new string[28];
        //public DateTime Day { get; set; }
        //public DateTime Tem = DateTime.Today;


        public string[] FourWeeksTable(int cont)
        {
            DateTime Day = DateTime.Today;
            int dayWeek = (int)Day.DayOfWeek;
            string[] fourWeek = new string[7];
            DateTime Temporary = new DateTime();
            if (cont == 0)
            {
                Temporary = Day.AddDays(-dayWeek + 1);
                fourWeek[0] = Temporary.ToString("d");
                for (int i = 0; i < 6; i++)
                {
                    fourWeek[i + 1] = Temporary.AddDays(i + 1).ToString("d");
                }
            }
            else if (cont == 1)
            {
                Temporary = Day.AddDays(-dayWeek + 1 + 7);
                fourWeek[0] = Temporary.ToString("d");
                for (int i = 0; i < 6; i++)
                {
                    fourWeek[i + 1] = Temporary.AddDays(i + 1).ToString("d");
                }
            }
            else if (cont == 2)
            {
                Temporary = Day.AddDays(-dayWeek + 1 + 14);
                fourWeek[0] = Temporary.ToString("d");
                for (int i = 0; i < 6; i++)
                {
                    fourWeek[i + 1] = Temporary.AddDays(i + 1).ToString("d");
                }
            }
            else if (cont == 3)
            {
                Temporary = Day.AddDays(-dayWeek + 1 + 21);
                fourWeek[0] = Temporary.ToString("d");
                for (int i = 0; i < 6; i++)
                {
                    fourWeek[i + 1] = Temporary.AddDays(i + 1).ToString("d");
                }
            }

            return fourWeek;
        }
    }
}
