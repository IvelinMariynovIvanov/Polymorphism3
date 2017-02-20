using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam10._07
{
    public abstract class Hardware : Component
    {
        private int maximumCapacity;
        private int maximumMemory;
        private int availableCapacity;
        private int availableMemory;
        public List<Software> softwares;

        public Hardware(string name, string type, int maximumCapacity, int maximumMemory) 
            : base(name, type)
        {
            this.MaximumCapacity = maximumCapacity;
            this.MaximumMemory = maximumMemory;
            this.AvailableCapacity = MaximumCapacity;
            this.AvailableMemory = MaximumMemory;
            this.softwares = new List<Software>();
        }

        public virtual int MaximumCapacity
        {
            get
            {
                return maximumCapacity;
            }

        protected    set
            {
                maximumCapacity = value;
            }
        }

        public virtual int MaximumMemory
        {
            get
            {
                return maximumMemory;
            }

       protected     set
            {
                maximumMemory = value;
            }
        }

        public int AvailableCapacity
        {
            get
            {
                return availableCapacity;
            }

            set
            {
                availableCapacity = value;
            }
        }

        public int AvailableMemory
        {
            get
            {
                return availableMemory;
            }

            set
            {
                availableMemory = value;
            }
        }

        public bool CheckSofwareReqiarements(Software software)
        {
            if(this.AvailableCapacity >= software.CapacityConsumtion && 
               this.AvailableMemory >=software.MemoryConsumtion)
            {
                softwares.Add(software);
                this.AvailableCapacity -= software.CapacityConsumtion;
                this.AvailableMemory -= software.MemoryConsumtion;

                return true;
            }
            return false;
        }
    }
}