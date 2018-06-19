using APP.Business.BusinessManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DeviceManager manager = new DeviceManager();
            var list = manager.getMainDevices();

            foreach(var device in list)
            {
                Console.WriteLine("Device Name : " + device.DeviceName);
            }
            Console.ReadLine();
        }
    }
}
