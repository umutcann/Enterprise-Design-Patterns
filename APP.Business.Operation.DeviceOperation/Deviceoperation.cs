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
using APP.Model.DTO;
using APP.Business.Operation.DevicePlugin.Manager;

namespace APP.Business.Operation.DeviceOperation
{
    public class DeviceOperation
    {

        public List<UserDTO> GetAllUsersFromDevice()
        {
            DeviceManager manager = new DeviceManager();

            List<DeviceDTO> devices = new List<DeviceDTO>();
            devices.Add(new DeviceDTO() { DeviceName = "Device1", SDKNumber = "1" });
            devices.Add(new DeviceDTO() { DeviceName = "Device2", SDKNumber = "2" });

            var users = manager.GetAllUser(devices);
            var userDtos = new List<UserDTO>();
            foreach (var user in users)
            {
                userDtos.Add(new UserDTO() { UserId = user.UserId });
            }

            return userDtos;

        }
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
