using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPrepp
{
    public class Child
    {
        private decimal[] consumption;

        public Child(decimal[] consumption)
        {
            this.consumption = consumption;
        }

        public decimal GetTotalChildrenConsumption()
        {
          return  this.consumption.Sum();
        }
    }
}