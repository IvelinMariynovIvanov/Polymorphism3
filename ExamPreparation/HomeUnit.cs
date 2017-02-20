using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPreparation
{
    public abstract class HomeUnit
    {
        private decimal roomElectricity;
        private int numberOfRooms;
        private decimal balance;
        private readonly decimal income;

        protected HomeUnit(decimal income, int numberOfRooms, decimal roomElectricity)
        {
            this.balance = 0;
            this.income = income;
            this.numberOfRooms = numberOfRooms;
            this.roomElectricity = roomElectricity;
        }


        public virtual int Population
        {
            get
            {
             return 1   ;
            }
        }

        public virtual decimal Consumation
        {
            get
            {
            return  this.numberOfRooms * this.roomElectricity ;
            }
        }

        public void GetIncome()
        {
            this.balance += this.income;
        }

        public bool  CanPayBills()
        {
            // if money >= this.Consumation;
            return balance >= this.Consumation;

        }

        public void PayBills()
        {
            this.balance -= this.Consumation;
        }
    }
}