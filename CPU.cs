using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CriticalThinkingWorksheet
{
    class CPU
    {
        //member variables
        public string Manufacturer;
        public string Name;
        //constructor
        public CPU(string manufacturer, string name)
        {
            Manufacturer = manufacturer;
            Name = name;
        }
        //member methods
        public void ProcessInstall(Applications applications, HardDrive hardDrive, RAM ram, Games game, GPU gpu)
        {
            if (CheckingRequirements(applications, hardDrive, ram, game, gpu) == true)
            {
                hardDrive.ApplicationsInHardDrive.Add(applications);
            }

        }

        public bool CheckingRequirements(Applications applications, HardDrive hardDrive, RAM ram, Games game, GPU gpu)
        {
            if (ram.TotalGigabytes > applications.RequiredRam &&
                applications.RequiredStorage < hardDrive.AvailableStorage && game.RequiredEffectiveMemory < gpu.EffectiveMemory)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, you do not have enough RAM or available memory for storage.");
                return false;
            }
        }
    }
}
