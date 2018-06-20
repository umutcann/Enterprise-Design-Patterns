using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Business.Operation.DevicePlugin.Infrastructure
{
    public interface IHasFingerPrint
    {
        string FingerPrint { get; set; }
    }
}
