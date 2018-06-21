using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Log.Infrastructure
{
    public interface ILogData
    {
        string User { get; set; }
        string LogMessage { get; set; }
        DateTime LogDate { get; set; }
    }
}
