﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExam10._07
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "System Split")
            {
                if (input.StartsWith("Register"))
                {
                    ComponentFactory.RegisterComponent(input);
                }
                else if (input.StartsWith("Analyze"))
                {
                    Analyze.PrintAnalyze();
                }
                else
                {
                    ReleaseSoftwareComponent.Release(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
