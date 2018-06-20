using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Business.Operation.DevicePlugin.Infrastructure
{
    public interface IDevice :IDisposable 
    {
        string DeviceName { get;  }
        string SDKNumber { get;  }

        void Connect();
        void Disconnect();
        IEnumerable<IUser> GetUsers();

    }
}
