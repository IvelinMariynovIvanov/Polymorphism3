using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPrepp
{
    public class AloneYoung : Single
    {
        private decimal laptopCoast;
        private const int NumberOfROOMS = 1;
        private const decimal ROOMElectricity = 10;

        public AloneYoung(decimal income, decimal laptopCoast) 
            : base(income, NumberOfROOMS, ROOMElectricity)
        {
            this.laptopCoast = laptopCoast;
        }

        public override decimal Consumtion
        {
            get
            {
                return base.Consumtion + laptopCoast;
            }
        }
    }
}