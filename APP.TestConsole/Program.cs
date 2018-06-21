using APP.Business.Operation.DevicePlugin.Manager;
using APP.Model.DTO;
using CF.Log.Manager;
using CF.Log.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            LogShell.WriteLog(new DBLogData()
            {
                LogDate = DateTime.Now,
                LogMessage = "error",
                User = "DKare"
            });

            Console.WriteLine("Eklendi.");
            Console.ReadLine();

        }
    }
}
