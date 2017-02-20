using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPrepp
{
    public class YoungCouple : Couple
    {
        private const int NumberOfROOMS = 2;
        private const decimal ROOMelectricity = 20;
        private decimal laptopCoast;

        public YoungCouple(decimal salariOne, decimal salaryTwo, decimal TvCoast, decimal FridgeCoast, decimal laptopCoast) 
            : base(salariOne+salaryTwo, NumberOfROOMS, ROOMelectricity, TvCoast, FridgeCoast)
        {
            this.laptopCoast = laptopCoast;
        }

        protected YoungCouple(decimal income, int numberOfRooms, decimal roomElectricity, decimal TvCoast, decimal FridgeCoast, decimal laptopCoast)
            :base( income,  numberOfRooms,  roomElectricity,  TvCoast,  FridgeCoast)
        {
            this.laptopCoast = laptopCoast;
        }
      

        public override decimal Consumtion
        {
            get
            {
                return base.Consumtion + 2*laptopCoast;
            }
        }
    }
}