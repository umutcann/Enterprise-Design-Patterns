using APP.Business.Operation.DeviceOperation;
using APP.Model.WebModel;
using CF.Cache.Manager;
using CF.Exception.DataException;
using CF.Exception.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Business.BusinessManager
{
    public class DeviceManager
    {
        private void SetDeviceToCache(List<DeviceModel> devices)
        {
            var cacheStrategy = CacheManager.Get();
            cacheStrategy.AddToCache("DeviceList", devices);
        }

        private List<DeviceModel> GetDeviceFromCache()
        {
            var cacheStrategy = CacheManager.Get();
            List<DeviceModel> list = (List<DeviceModel>)cacheStrategy.Get("DeviceList");
            return list;
        }

        private bool ChechCache()
        {
            var cacheStrategy = CacheManager.Get();
            return cacheStrategy.CheckKey("DeviceList");
        }

        public List<DeviceModel> getMainDevices()
        {
            try
            {

                DeviceOperation deviceOperation = new DeviceOperation();
                if (!ChechCache())
                {
              
                     SetDeviceToCache(deviceOperation.GetAllDevices());
                }
                return GetDeviceFromCache();
            }
            catch(BaseException bex)
            {
                if(bex is DatabaseOperationException)
                {
                    //TODO : UI devreye alındığında yazılacak
                    throw;
                }
                else
                {
                    throw;
                }
            }
            catch(Exception ex)
            {

                //TODO : Logla ve bilinen bir hata nesnesi gönder.
                throw;
            }
            }
    }
}
