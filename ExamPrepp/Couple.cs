using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPrepp
{
    public abstract class Couple : HomeUnit
    {
        private decimal TvCoast;
        private decimal FridgeCoast;

        public Couple(decimal income, int numberOfRooms, decimal roomElectricity, decimal TvCoast, decimal FridgeCoast) 
            : base(income, numberOfRooms, roomElectricity)
        {
            this.TvCoast = TvCoast;
            this.FridgeCoast = FridgeCoast;
        }

        public override int Population
        {
            get
            {
                return base.Population +1;
            }
        }

        public override decimal Consumtion
        {
            get
            {
                return base.Consumtion + TvCoast + FridgeCoast;
            }
        }
    }
}