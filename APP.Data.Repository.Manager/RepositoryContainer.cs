using APP.Data.Repository.Derived.EFRepository;
using APP.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Data.Repository.Manager
{
    public static class RepositoryContainer
    {
        /* public static T GetRepository<T>()
         {
             throw new NotImplementedException();
         }*/


        public static IDeviceRepository GetRepository()
        {
            return new DeviceRepository();
        }
    }
}
