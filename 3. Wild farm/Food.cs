using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Wild_farm
{
    abstract public class Food
    {
        private int quantity;

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}
