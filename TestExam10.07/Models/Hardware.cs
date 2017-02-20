using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExam10._07
{
    public abstract class Hardware : Component
    {
        private int maxCapacity;
        private int maxMemory;
        public List<Software> Softwares;
        private int availableCapacity;
        private int availableMemory;

        public Hardware(string name, string type, int maxCapacity, int maxMemory) 
            : base(name, type)
        {
            this.MaxCapacity = maxCapacity;
            this.MaxMemory = maxMemory;
            this.AvailableCapacity = MaxCapacity;
            this.AvailableMemory = MaxMemory;
            this.Softwares = new List<Software>();
        }

        public virtual int MaxCapacity
        {
            get
            {
                return maxCapacity;
            }

          protected  set
            {
                maxCapacity = value;
            }
        }

        public virtual int MaxMemory
        {
            get
            {
                return maxMemory;
            }

          protected  set
            {
                maxMemory = value;
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

        public bool CheckHardwareRequarements(Software software)
        {
            if(this.MaxCapacity >= software.CapacityConsumption &&
               this.MaxMemory >= software.MemoryConsumption)
            {
                this.Softwares.Add(software);
                this.AvailableCapacity = this.MaxCapacity - software.CapacityConsumption;
                this.AvailableMemory = this.MaxMemory - software.MemoryConsumption;

                return true;
            }

            return false;
        }
    }
}