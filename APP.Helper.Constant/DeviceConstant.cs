using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Helper.Constant
{
    public class DeviceConstant
    {
        static DeviceConstant()
            { 
            DeviceTableName = "Device";
            }
    public readonly static string DeviceTableName;
    }
}
