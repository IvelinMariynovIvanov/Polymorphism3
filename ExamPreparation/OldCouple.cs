using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPreparation
{
    public class OldCouple : Couple
    {
        private const int NumberOfRooms = 3;
        private const decimal RoomElectricity = 15;
        private decimal stoveCost;

        public OldCouple(decimal pencionOne, decimal pentionTwo, decimal income, decimal tvCost, decimal fridgeCost, decimal stoveCost) 
            : base(NumberOfRooms, RoomElectricity, pencionOne+pentionTwo, tvCost, fridgeCost)
        {
            this.stoveCost = stoveCost;
        }

        public override decimal Consumation
        {
            get
            {
                return stoveCost+ base.Consumation;
            }
        }
    }
}