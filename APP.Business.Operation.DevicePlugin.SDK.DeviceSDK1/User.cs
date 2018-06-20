using APP.Business.Operation.DevicePlugin.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Business.Operation.DevicePlugin.SDK.DeviceSDK1
{
    public class User : IUser, IHasFingerPrint
    {
        public string UserId { get ; set ; }
        public string FingerPrint { get ; set ; }
    }
}
