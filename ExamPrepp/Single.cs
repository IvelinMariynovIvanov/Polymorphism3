﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPrepp
{
    public abstract class Single : HomeUnit
    {

        public Single(decimal income, int numberOfRooms, decimal roomElectricity) 
            : base(income, numberOfRooms, roomElectricity)
        {
        }
    }
}