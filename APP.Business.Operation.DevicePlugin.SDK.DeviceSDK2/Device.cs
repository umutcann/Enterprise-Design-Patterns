using APP.Business.Operation.DevicePlugin.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Business.Operation.DevicePlugin.SDK.DeviceSDK2
{
    public class Device : IDevice, IFaceDevice
    {
        public string DeviceName => "DeviceSDK2";

        public string SDKNumber => "2";

        public void Connect()
        {
            Console.WriteLine("Connected to Device which has SDK 2");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected from Device which has SDK 2");
        }

        public void Dispose()
        {
            Disconnect();
        }

        public IEnumerable<IUser> GetUsers()
        {
            //Cihaza git verileri al getir

            List<User> users = new List<User>();

            users.Add(new User() { UserId = "1", Face = "ggg" });
            users.Add(new User() { UserId = "2", Face = "hhh" });
            users.Add(new User() { UserId = "3", Face = "iii" });

            return users.AsEnumerable();
        }
    }
}

