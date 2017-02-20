using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPreparation
{
    public class AloneYoungPerson : Alone
    {
        private const int NumberOfRooms = 1;
        private const decimal RoomElectricity = 10;
        private decimal laptopCost;

        public AloneYoungPerson(decimal income, decimal laptopCost) 
            : base(income, NumberOfRooms, RoomElectricity)
        {
            this.laptopCost = laptopCost;
        }

        public override decimal Consumation
        {
            get
            {
                return laptopCost+ base.Consumation;
            }
        }
    }
}