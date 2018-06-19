using APP.Data.Repository.Derived.EFRepository;
using APP.Model.WebModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP.Data.Repository.Manager;
using CF.Data.Infrastructure;
using APP.Data.Infrastructure;

namespace APP.Business.Operation.DeviceOperation
{
    public class DeviceOperation
    {
        public List<DeviceModel> GetAllDevices()
        {

            var repository = RepositoryContainer.GetRepository();

            var list = from d in((DeviceRepository)repository).GetAllItems()
                       select new DeviceModel()
                       {
                           DeviceId = d.DeviceId,
                           DeviceName = d.DeviceName
                       };
            return list.ToList();
          
        }
    }
}
