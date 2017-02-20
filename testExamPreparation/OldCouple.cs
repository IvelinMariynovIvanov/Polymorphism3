using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testExamPreparation
{
    public class OldCouple : Couple
    {
        private decimal stoveCost;
        private const int NumberOfRooms = 3;
        private const decimal RoomElectricity = 15;

        public OldCouple(decimal income, decimal tvCost, decimal fridgeCost,decimal stoveCost) 
            : base(income, NumberOfRooms, RoomElectricity, tvCost, fridgeCost)
        {
            this.stoveCost = stoveCost;
        }

        public override decimal Consumption
        {
            get
            {
                return base.Consumption;
            }
        }
    }
}