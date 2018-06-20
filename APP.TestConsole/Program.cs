using APP.Business.Operation.DevicePlugin.Manager;
using APP.Model.DTO;
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
            List<DeviceDTO> devices = new List<DeviceDTO>();

            devices.Add(new DeviceDTO() { DeviceName = "Device1", SDKNumber = "1" });
            devices.Add(new DeviceDTO() { DeviceName = "Device2", SDKNumber = "2" });

           var users = manager.GetAllUser(devices);

            foreach (var user in users)
            {
                Console.WriteLine(user.UserId);
            }

            Console.ReadLine();

        }
    }
}
