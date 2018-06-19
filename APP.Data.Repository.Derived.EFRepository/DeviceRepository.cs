using APP.Data.Infrastructure;
using APP.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CF.Data.Infrastructure;
using CF.Exception.DataException;
using System.Reflection;
using APP.Helper.Constant;

namespace APP.Data.Repository.Derived.EFRepository
{
    public class DeviceRepository : IDeviceRepository
    {
        DeviceSystemContext _context;

        public DeviceRepository()
        {
            _context = new DeviceSystemContext();
        }
        public void Delete(Device item)
        {
            throw new NotImplementedException();
        }

        public IList<Device> GetAllItems()
        {
            try
            {
                return _context.Devices.ToList();
            }
            catch (Exception ex)
            {

                throw new DatabaseOperationException(ex.Message, new OperationInfo
                {
                    DataBaseName = _context.Database.Connection.Database,
                    MethodBase = MethodBase.GetCurrentMethod(),
                    OperationType = DatabaseOperationType.Select,
                    OriginalException = ex,
                    TableName = DeviceConstant.DeviceTableName
                });
            }
            
        }

        public Device Insert(Data.Entity.Device item)
        {
            throw new NotImplementedException();
        }

        public Device Update(Data.Entity.Device Item)
        {
            throw new NotImplementedException();
        }
    }
}
