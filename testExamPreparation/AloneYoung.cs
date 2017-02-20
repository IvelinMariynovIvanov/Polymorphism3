using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testExamPreparation
{
    public class AloneYoung : Single
    {
        private const int NumberOfRooms = 1;
        private const decimal RoomElectricy = 10;
        private decimal laptopcost;
        public AloneYoung(decimal income, decimal laptopcost) 
            : base(income, NumberOfRooms, RoomElectricy)
        {
            this.laptopcost = laptopcost;
        }

        public override decimal Consumption
        {
            get
            {
                return base.Consumption + laptopcost;
            }
        }
    }
}