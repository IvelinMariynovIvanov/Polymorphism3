using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPreparation
{
    public abstract class Couple : HomeUnit
    {
        private decimal tvCost;
        private decimal fridgeCost;

        protected Couple(int numberOfRooms, decimal roomElectricity, decimal income, decimal tvCost, decimal fridgeCost) 
            : base(income, numberOfRooms, roomElectricity)
        {
            this.tvCost = tvCost;
            this.fridgeCost = fridgeCost;
        }

        public override decimal Consumation
        {
            get
            {
                return fridgeCost+tvCost + base.Consumation;
            }
        }

        public override int Population
        {
            get
            {
                return base.Population +1;
            }
        }
    }
}