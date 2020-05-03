using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingWorksheet
{
    class Motherboard
    {
        //member variables
        public string Manufacturer;
        public RAM TemporaryMemory;
        public CPU Processor;
        public HardDrive Storage;
        public GPU Graphics;
        
        //constructor
        public Motherboard(string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturer;
            TemporaryMemory = ram;
            Processor = cpu;
            Storage = hardDrive;
            Graphics = gpu;

        }


        //member methods
    }
}
