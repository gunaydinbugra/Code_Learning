using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_4___c_
{
    public class task
    {
        public DueDate DueDate { get; set; }
        public int Cost { get; set; }
        public bool Finished { get; set; }
        public task(DueDate duedate, int cost, bool finished) 
        {
            DueDate = duedate ;
            Cost = cost;
            Finished = finished;
        }
        public override string ToString()
        {
            return $"Due Date: {DueDate}, Cost: {Cost}, Finished: {Finished}";
        }
        public bool Equals(object obj)
        {
            if (obj is task othertask)
            {
                return DueDate == othertask.DueDate && Cost == othertask.Cost && Finished == othertask.Finished;
            }
            return false;
        }
    }
}
