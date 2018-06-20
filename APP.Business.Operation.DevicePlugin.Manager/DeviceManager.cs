using APP.Business.Operation.DevicePlugin.Infrastructure;
using APP.Model.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace APP.Business.Operation.DevicePlugin.Manager
{
    public class DeviceManager
    {
        public static List<IDevice> RegisteredDevices { get; private set; }
        static DeviceManager()
        {
            RegisteredDevices = new List<IDevice>();
            RegisteredAllDevices();
        }
        public static void RegisteredAllDevices()
        {
            string pluginDirectory = "C:\\Users\\bilginc_user\\Desktop\\Project\\Enterprise-Design-Patterns\\APP.UI.MVCUI\\bin\\SDK";
            String[] pluginFiles = Directory.GetFiles(pluginDirectory, "*.dll");
            foreach (var plugin in pluginFiles)
            {
                Type[] objTypes = null;
                try
                {
                    //Assembly.GetExecutingAssembly().GetName().Name
                    
                    Assembly asm = Assembly.LoadFrom(plugin);
                    if (asm != null)
                    {
                        objTypes = asm.GetTypes();


                        foreach (var objType in objTypes)
                        {
                            var interfaces = objType.GetInterfaces();
                            if (interfaces.Contains(typeof(IDevice)))
                            {

                                IDevice device = (IDevice)Activator.CreateInstance(objType);
                                RegisteredDevices.Add(device);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public IList<IUser> GetAllUser(IList<DeviceDTO> devices)
        {
            List<IUser> users = new List<IUser>();
            foreach(var device in devices)
            {
                var regDevice = RegisteredDevices.
                    FirstOrDefault(x => x.SDKNumber == device.SDKNumber);

                if(regDevice == null)
                {
                    continue;
                }

                regDevice.Connect();
                users.AddRange(regDevice.GetUsers());
                regDevice.Disconnect();
            }
            return users;
            
        }
    }
}
