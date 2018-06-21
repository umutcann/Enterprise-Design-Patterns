using CF.Log.Manager;
using CF.Log.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Log.Manager
{
    public static class LogManager
    {
        public static void WriteLog(LogDataModel data)
        {
            LogShell.WriteLog(new DBLogData()
            {

                LogDate = data.LogDate,
                LogMessage = data.Data,
                User = data.User
            });

        }
    }
}
