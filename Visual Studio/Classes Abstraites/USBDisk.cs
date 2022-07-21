using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstraites
{
    class SmartPhone : StorageDevice
    {
        public override void Read()
        {
            Console.WriteLine("Read data on SmartPhone");
        }

        public override void Write()
        {
            Console.WriteLine("Collect data from SmartPhone");
        }
    }
    class USBDisk : StorageDevice
    {
        public override void Read()
        {
            Console.WriteLine("Read data on USBDisk");
        }

        public override void Write()
        {
            Console.WriteLine("Collect data on USBDisk");
        }
    }

    class Computer 
    {
        public  void ReadData(StorageDevice device)
        {
            device.Read();
        }

        public  void WriteData(StorageDevice device)
        {
            device.Write();
        }

        
           
        
    }
}
