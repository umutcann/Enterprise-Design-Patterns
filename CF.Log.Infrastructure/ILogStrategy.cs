using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Log.Infrastructure
{
    public interface ILogStrategy
    {
        void WriteLog(ILogData logData);
    }
}
