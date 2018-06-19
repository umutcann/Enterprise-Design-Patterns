using CF.Exception.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Exception.BusinessException
{
    public class BusinessRuleException : BaseException
    {
        public List<string> Rules{ get; set; }
        public BusinessRuleException(string message, List<string> rules) : base(message)
        {
            Rules = rules;
        }

        public String FullMessage
        {
            get
            {
                string full = string.Empty;
                foreach (var item in Rules)
                {
                    full += item + "\n\r";
                }
                return full;
            }
        }
    }
}
