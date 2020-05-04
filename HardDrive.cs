﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CriticalThinkingWorksheet
{
    class HardDrive
    {
        //member variables
        public double TotalStorage;
        public double AvailableStorage;
        public List<Applications> ApplicationsInHardDrive;

        //constructor
        public HardDrive(double totalStorage, double availableStorage)
        {
            TotalStorage = totalStorage;
            AvailableStorage = availableStorage;
            ApplicationsInHardDrive = new List<Applications>();
        }
        //member mehtods
    }
}
