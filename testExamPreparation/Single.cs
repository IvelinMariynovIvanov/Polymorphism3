using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testExamPreparation
{
    public abstract class Single : HomeUnit
    {
        public Single(decimal income, int numberOfRooms, decimal roomElectrycity) 
            : base(income, numberOfRooms, roomElectrycity)
        {
        }
    }
}