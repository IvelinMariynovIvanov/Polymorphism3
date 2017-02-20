using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPreparation
{
    public class AloneOldPerson : Alone
    {
        private const int NumberOfRooms = 1;
        private const decimal RoomElectricity = 15;

        public AloneOldPerson(decimal pension ) 
            : base(pension, NumberOfRooms, RoomElectricity)
        {
        }
    }
}