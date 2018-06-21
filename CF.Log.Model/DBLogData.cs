using CF.Log.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Log.Model
{
    public class DBLogData : ILogData
    {
        
        public string User { get ; set ; }
        public string LogMessage { get ; set ; }
        public DateTime LogDate { get ; set ; }
    }
}
