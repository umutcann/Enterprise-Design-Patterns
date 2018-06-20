using APP.Business.Operation.DevicePlugin.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Business.Operation.DevicePlugin.SDK.DeviceSDK2
{
    public class User : IUser, IHasFace
    {
        public string UserId { get; set; }
        public string Face { get; set; }
    }
}
