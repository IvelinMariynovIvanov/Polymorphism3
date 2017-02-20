using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPreparation
{
    public abstract class Alone : HomeUnit
    {
        public Alone(decimal income, int numberOfRooms, decimal roomElectricity) 
            : base(income, numberOfRooms, roomElectricity)
        {
        }
    }
}