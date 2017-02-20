using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep
{
    class YoungCouple : Couple
    {
        private const int NumberOfRooms = 2;
        private const decimal RoomElectricity = 20;
        private decimal laptopCost;

        public YoungCouple()
        {

        }

        public YoungCouple(decimal income, int numberOfRooms, decimal roomElectricity, decimal tvCost, decimal fridgeCost) 
            : base(income, NumberOfRooms, RoomElectricity, tvCost, fridgeCost)
        {
            this.laptopCost = laptopCost;
        }

        public override decimal Consumation
        {
            get
            {
                return base.Consumation + 2*laptopCost;
            }
        }

        
    }
}
