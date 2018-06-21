using CF.Log.Infrastructure;
using CF.Log.Strategy.DBLogStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Log.Manager
{
    public static class LogShell
    {
        public static void WriteLog(ILogData data)
        {
            LogManager manager = new LogManager(new LogStrategy());
            manager.WriteLog(data);
        }
    }
}
