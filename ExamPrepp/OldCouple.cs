using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPrepp
{
    public class OldCouple : Couple
    {
        private const int NumberOfROOMS = 3;
        private const decimal ROOMelectricity = 15;
        private decimal stoveCoast;

        public OldCouple(decimal pencionOne, decimal pentionTwo, decimal TvCoast, decimal FridgeCoast, decimal stoveCoast) 
            : base(pencionOne+pentionTwo, NumberOfROOMS, ROOMelectricity, TvCoast, FridgeCoast)
        {
            this.stoveCoast = stoveCoast;
        }

        public override decimal Consumtion
        {
            get
            {
                return base.Consumtion + stoveCoast;
            }
        }
    }
}