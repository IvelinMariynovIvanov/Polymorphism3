using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testExamPreparation
{
    public class YoungCouple : Couple
    {
        private decimal laptopCost;
        private const int NumberOfRooms = 2;
        private const decimal RoomElecricyty = 20;

        public YoungCouple(decimal salaryOne, decimal salaryTwo, decimal tvCost, decimal fridgeCost, decimal laptopCost) 
            : base(salaryOne+salaryTwo, NumberOfRooms, RoomElecricyty, tvCost, fridgeCost)
        {
            this.laptopCost = laptopCost;
        }

        protected YoungCouple(decimal income, int numberOfRooms, decimal roomElectrycity, decimal tvCost, decimal fridgeCost, decimal laptopCost)
            : base(income, numberOfRooms, roomElectrycity, tvCost, fridgeCost)
        {
            this.laptopCost = laptopCost;
        }

        public override decimal Consumption
        {
            get
            {
                return base.Consumption + laptopCost*2;
            }
        }
    }
}