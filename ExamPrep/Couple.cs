using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep
{
    abstract class Couple : Home
    {
        private decimal tvCost;
        private decimal fridgeCost;
        private const int NumberOfRooms = 2;

        public Couple(decimal income, int numberOfRooms, decimal roomElectricity, decimal tvCost, decimal fridgeCost) 
            : base(income, NumberOfRooms, roomElectricity)
        {
            this.tvCost = tvCost;
            this.fridgeCost = fridgeCost;
        }

        public override decimal Consumation
        {
            get
            {
                return base.Consumation + tvCost + fridgeCost;
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
