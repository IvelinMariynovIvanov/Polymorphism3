using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExam10._07
{
   public static class ComponentFactory
    {
      public static List<Hardware> Hardwares = new List<Hardware>();

        public static void RegisterComponent(string input)
        {
            string[] info = input.Split('(', ')').ToArray();
            string command = info[0];
            string[] parameters = info[1].Split(new char[] { ' ',  ',' },
                StringSplitOptions.RemoveEmptyEntries).ToArray(); 

                switch (command)
                {
                    case "RegisterPowerHardware":
                        RegisterPowerHardware(parameters[0], int.Parse(parameters[1]), int.Parse(parameters[2]));
                        break;
                    case "RegisterHeavyHardware":
                        RegisterHeavyHardware(parameters[0], int.Parse(parameters[1]), int.Parse(parameters[2]));
                        break;
                    case "RegisterLightSoftware":
                        RegisterLightSoftware(parameters[0], (parameters[1]), 
                            int.Parse(parameters[2]), int.Parse(parameters[3]));
                        break;
                    case "RegisterExpressSoftware":
                        RegisterExpressSoftware(parameters[0], (parameters[1]),
                            int.Parse(parameters[2]), int.Parse(parameters[3]));
                        break;
                }
          
        }

        public static PowerHardware RegisterPowerHardware(string name, int capacity, int memory)
        {
            PowerHardware powerHardware = new PowerHardware(name, capacity, memory);
            Hardwares.Add(powerHardware);
            return powerHardware;
        }

        public static HeavyHardware RegisterHeavyHardware(string name, int capacity, int memory)
        {
            HeavyHardware heavyHardware = new HeavyHardware(name, capacity, memory);
            Hardwares.Add(heavyHardware);
            return heavyHardware;
        }

        public static LightSoftware RegisterLightSoftware(string hardwareName, string softwareName, int capacity, int memory)
        {
            LightSoftware lightSofware = new LightSoftware(softwareName, capacity, memory);
            foreach (var hardware in Hardwares)
            {
                if(hardware.Name == hardwareName)
                {
                    if(!hardware.Softwares.Contains(lightSofware))
                    {
                        hardware.CheckHardwareRequarements(lightSofware);
                        return lightSofware;
                    }
                }
            }
            return null;
        }

        public static ExpressSoftware RegisterExpressSoftware(string hardwareName, string softwareName, int capacity, int memory)
        {
            ExpressSoftware expressSofware = new ExpressSoftware(softwareName, capacity, memory);
            foreach (var hardware in Hardwares)
            {
                if (hardware.Name == hardwareName)
                {
                    if (!hardware.Softwares.Contains(expressSofware))
                    {
                        hardware.CheckHardwareRequarements(expressSofware);
                        return expressSofware;
                    }
                }
            }
            return null;
        }

    }
}
