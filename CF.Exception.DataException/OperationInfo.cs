using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CF.Exception.DataException
{
    public class OperationInfo
    {
        public String DataBaseName{ get; set; }
        public String TableName { get; set; }
        public DatabaseOperationType OperationType { get; set; }
        public String Query { get; set; }
        public MethodBase MethodBase{ get; set; }
        public System.Exception OriginalException { get; set; }
    }
    public enum DatabaseOperationType
    {
        Select = 1, Insert =2, Update=3, Delete=4
    }
}
