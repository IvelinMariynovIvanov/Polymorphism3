using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPreparation
{
    public class YoungCoupleWithChildren : YoungCouple
    {
        private const int NumberOfRooms = 2;
        private const decimal RoomElectricity = 30;

        private Child[] children;

        public YoungCoupleWithChildren(decimal salaryOne, decimal salaryTwo, decimal tvCost, decimal fridgeCost, decimal laptopCost, Child[] children) :
            base(NumberOfRooms, RoomElectricity, salaryOne+ salaryTwo, tvCost, fridgeCost, laptopCost)
        {
            this.children = children;
        }

        public override decimal Consumation
        {
            get
            {
                return children.Sum(x => x.GetTotalChildConsumtion()) 
                    + base.Consumation;
            }
        }

        public override int Population
        {
            get
            {
                return children.Length + base.Population;
            }
        }
    }
}