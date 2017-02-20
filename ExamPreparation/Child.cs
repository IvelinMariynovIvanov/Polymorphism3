using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPreparation
{
    public class Child
    {
        private decimal[] consumtion;   //all - food and toys

        public Child(decimal[] consumtion)
        {
            this.consumtion = consumtion;
        }

        public decimal GetTotalChildConsumtion()
        {
            return this.consumtion.Sum();
        }

         
    }
}