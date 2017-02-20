using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testExamPreparation
{
    public abstract class HomeUnit
    {
        private int numberOfRooms;
        private decimal roomElectrycity;
        private decimal income;
        private decimal balance;

        public HomeUnit(decimal income, int numberOfRooms, decimal roomElectrycity)
        {
            this.balance = 0;
            this.income = income;
            this.numberOfRooms = numberOfRooms;
            this.roomElectrycity = roomElectrycity;
        }

        public void GetIncome()
        {
            this.balance += income;
        }

        public bool CanPayBills()
        {
            return this.balance >= this.Consumption;
        }

        public void PayBills()
        {
            this.balance -= this.Consumption;
        }

        public virtual int Population
        {
            get
            {
              return 1  ;
            }
        }

        public virtual decimal Consumption
        {
            get
            {
              return this.numberOfRooms * this.roomElectrycity ;
            }
          
        }

    }
}