using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPrepp
{
    public class YoungCoupleWithChildren : YoungCouple
    {
        private const int numberOfROOMS = 2;
        private const decimal ROOMelectricity = 30;
        private Child[] children;

        public YoungCoupleWithChildren(decimal income,  decimal TvCoast, decimal FridgeCoast, decimal laptopCoast, Child[] children) 
            : base(income, numberOfROOMS, ROOMelectricity, TvCoast, FridgeCoast, laptopCoast)
        {
            this.children = children;
        }

        public override decimal Consumtion
        {
            get
            {
                return base.Consumtion + children.Sum(x=> x.GetTotalChildrenConsumption());
            }
        }

        public override int Population
        {
            get
            {
                return base.Population + children.Length;
            }
        }
    }
}