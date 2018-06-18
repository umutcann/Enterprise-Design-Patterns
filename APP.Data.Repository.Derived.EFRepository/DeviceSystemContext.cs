using APP.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Data.Repository.Derived.EFRepository
{
    class DeviceSystemContext : DbContext
    {
        public DeviceSystemContext ()
        {
            Database.SetInitializer<DeviceSystemContext>(null);
        }
        public virtual DbSet<Device> Devices { get; set; }
    }
}
