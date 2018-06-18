using APP.Data.Entity;
using CF.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Data.Infrastructure
{
    public interface IDeviceRepository : ISelectableRepository<Device>,
        IUpdateableRepository<Device>,IInsertableRepository<Device>,
        IDeletableRepository<Device>
    {
    }
}
