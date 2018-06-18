using APP.Data.Repository.Manager;
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
            var repo = RepositoryContainer.GetRepository();
            var data = repo.GetAllItems();

            foreach (var item in data)
            {
                Console.WriteLine(item.DeviceName);
            }
            Console.ReadLine();
        }
    }
}
