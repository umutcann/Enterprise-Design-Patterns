using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Exception.Infrastructure
{
    public abstract class BaseException : System.Exception
    {
        protected BaseException(string message) : base(message)
        {

        }
    }
}
