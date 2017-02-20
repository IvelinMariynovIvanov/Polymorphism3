using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPrepp
{
    public class AloneOld : Single
    {
        private const int NumberOfROOMS = 1;
        private const decimal ROOMElectricity = 15;


        public AloneOld(decimal income) 
            : base(income, NumberOfROOMS, ROOMElectricity)
        {
        }

    }
}