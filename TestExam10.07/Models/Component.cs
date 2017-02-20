using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExam10._07
{
    public abstract class Component:IComparable
    {
        private string name;
        private string type;

        public Component(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name
        {
            get
            {
                return name;
            }

          protected  set
            {
                name = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

         protected   set
            {
                type = value;
            }
        }

        public int CompareTo(object obj)
        {
          return  this.Name.CompareTo(((Component)obj).Name);
        }
    }
}