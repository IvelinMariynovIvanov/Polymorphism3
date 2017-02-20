using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPrepp
{
    public abstract class HomeUnit
    {
        private decimal roomElectricity;
        private int numberOfRooms;
        private decimal income;
        private decimal balance;

        public HomeUnit(decimal income, int numberOfRooms, decimal roomElectricity)
        {
            this.roomElectricity = roomElectricity;
            this.numberOfRooms = numberOfRooms;
            this.income = income;
            this.balance = 0;
        }

        public virtual int Population
        {
            get
            {
                return 1;
            }
 
        }

        public virtual decimal Consumtion
        {
            get
            {
                return numberOfRooms *roomElectricity;
            }

           
        }

        public void GetIncome()
        {
            this.balance += this.income;
        }

        public void PayBills()
        {
            this.balance -= income;
        }

        public bool CanPayBills()
        {
            return this.balance >= this.Consumtion;
                 
        }

    }
}