using APP.Business.Operation.DevicePlugin.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Business.Operation.DevicePlugin.SDK.DeviceSDK1
{
    public class Device : IDevice , IFingerDevice
    {
        public string DeviceName => "DeviceSDK1";

        public string SDKNumber => "1";

        public void Connect()
        {
            Console.WriteLine("Connected to Device which has SDK 1");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected from Device which has SDK 1");
        }

        public void Dispose()
        {
            Disconnect();
        }

        public IEnumerable<IUser> GetUsers()
        {
            //Cihaza git verileri al getir

            List<User> users = new List<User>();

            users.Add(new User() { UserId = "1", FingerPrint = "aaa" });
            users.Add(new User() { UserId = "2", FingerPrint = "bbb" });
            users.Add(new User() { UserId = "3", FingerPrint = "ccc" });

            return users.AsEnumerable();
        }
    }
}
