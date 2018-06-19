using CF.Exception.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Exception.DataException
{
    public class DatabaseOperationException : BaseException
    {

        public OperationInfo OperationInfo { get; private set; }

        public DatabaseOperationException(string message,OperationInfo operationInfo) : base(message)
        {
            OperationInfo = operationInfo;
        }
    }
}
