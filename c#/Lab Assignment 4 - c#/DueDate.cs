using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_4___c_
{
    public class DueDate
    {
        int day, month, year;
        public DueDate()
        {
            day = 1;
            month = 1;
            year = 1;
        }
        public DueDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            return $"{day} {month} {year}";
        }

        public bool Equals(object obj)
        {
            if (obj is DueDate otherDate)
            {
                return day == otherDate.day && month == otherDate.month && year == otherDate.year;
            }
            return false;
        }
        


}
}
