using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep
{
   public abstract class Home
    {
        private int numberOfRooms;
        private decimal roomElectricity;
        private decimal income;
        private decimal balance;

        public Home(decimal income, int numberOfRooms, decimal roomElectricity )
        {
            this.income = income;
            this.numberOfRooms = numberOfRooms;
            this.roomElectricity = roomElectricity;
            
        }

        public virtual int Population
        {
            get
            {
                return 1;
            }
          
        }

        public virtual decimal Consumation
        {
            get
            {
                return this.numberOfRooms*this.roomElectricity;
            }

        }

        public void GetIncome()
        {
            this.balance += this.income;
        }

        public bool  CanPayBills()
        {
                return balance >=this.Consumation;
        }

        public void PayBills()
        {
            this.balance -= this.Consumation;
        }
    }
}
