using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testExamPreparation
{
    public class YoungCoupleWithChildren:YoungCouple
    {
        public YoungCoupleWithChildren(decimal income, int numberOfRooms, decimal roomElectrycity, decimal tvCost, decimal fridgeCost, decimal laptopCost)
            : base(income, numberOfRooms, roomElectrycity, tvCost, fridgeCost, laptopCost)
        {

        }
    }
}