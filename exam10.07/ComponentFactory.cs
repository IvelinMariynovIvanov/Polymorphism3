using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam10._07
{
    public static class ComponentFactory
    {
        public static List<Hardware> Hardwares = new List<Hardware>();

        public static void RegisterComponent(string input)
        {
            string[] info = input.Split('(', ')').ToArray();
            string commandType = info[0];
            string[] parameters = info[1].Split(new char[] { ' ', ',' }, 
                StringSplitOptions.RemoveEmptyEntries).ToArray(); 

            switch (commandType)
            {
                case "RegisterHeavyHardware":
                    RegisterHeavyHardawe(parameters[0], int.Parse(parameters[1]), int.Parse(parameters[2]));
                    break;
                case "RegisterPowerHardware":
                    RegisterPowerHardware(parameters[0], int.Parse(parameters[1]), int.Parse(parameters[2]));
                    break;
                case "RegisterLightSoftware":
                    RegisterLightSoftware(parameters[0], (parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
                    break;
                case "RegisterExpressSoftware":
                    RegisterExpressSoftware(parameters[0], (parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
                    break;    
            }   
        }

        public static HeavyHardware RegisterHeavyHardawe(string type, int maxCapacity,int maxMemory)
        {
            HeavyHardware heavyHardware = new HeavyHardware(type, maxCapacity, maxMemory);
            Hardwares.Add(heavyHardware);
            return  heavyHardware;
        }

        public static PowerHardware RegisterPowerHardware(string type, int maxCapacity, int maxMemory)
        {
            PowerHardware powerHardware = new PowerHardware(type, maxCapacity, maxMemory);
            Hardwares.Add(powerHardware);
            return powerHardware;
        }
        public static LightSoftware RegisterLightSoftware(string hardwareName,string type, int maxCapacity, int maxMemory)
        {
            LightSoftware lightSoftware = new LightSoftware(type, maxCapacity, maxMemory);
            //foraech hardware in hardwarelist
            foreach (var hardware in Hardwares)
            {
                if(hardware.Name == hardwareName)
                {
                    if(!hardware.softwares.Contains(lightSoftware))
                    {
                        if (hardware.CheckSofwareReqiarements(lightSoftware))
                        {
                            return lightSoftware;
                        }
                    }
                   // break;  /// !!!!!!!!!!!!!
                }
            }

            return null;
            

            //if hardware.name == hardwarename
            //foreach var software in hardware.softwareList
            //if software name is unique add the software object to that hardware object's list

        }
        public static ExpressSoftware RegisterExpressSoftware(string hardwareName,string type, int maxCapacity, int maxMemory)
        {
            ExpressSoftware expressSoftware = new ExpressSoftware(type, maxCapacity, maxMemory);
            foreach (var hardware in Hardwares)
            {
                if(hardware.Name == hardwareName)
                {
                    if(!hardware.softwares.Contains(expressSoftware))
                    {
                        if (hardware.CheckSofwareReqiarements(expressSoftware))
                            return expressSoftware;
                    }
                    //break;
                }
            }
            return null;
        }

    }
}