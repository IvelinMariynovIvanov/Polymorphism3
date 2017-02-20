using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testExamPreparation
{
    public abstract class Couple : HomeUnit
    {
        private decimal tvCost;
        private decimal fridgeCost;

        public Couple(decimal income, int numberOfRooms, decimal roomElectrycity, decimal tvCost, decimal fridgeCost) 
            : base(income, numberOfRooms, roomElectrycity)
        {
            this.tvCost = tvCost;
            this.fridgeCost = fridgeCost;
        }

        public override int Population
        {
            get
            {
                return base.Population + 1;
            }
        }

        public override decimal Consumption
        {
            get
            {
                return base.Consumption + tvCost + fridgeCost;
            }
        }
    }
}