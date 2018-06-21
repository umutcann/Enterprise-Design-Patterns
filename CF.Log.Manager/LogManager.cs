using CF.Log.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Log.Manager
{
    public class LogManager
    {
        private readonly ILogStrategy _strategy;

        public LogManager(ILogStrategy strategy)
        {
            _strategy = strategy; 
        }
        public void WriteLog(ILogData logData)
        {
            _strategy.WriteLog(logData);
        }
    }
}
