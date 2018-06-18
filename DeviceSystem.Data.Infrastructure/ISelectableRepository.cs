using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Data.Infrastructure
{
    public interface ISelectableRepository<T>  where T : class,IEntity
    {
        IList<T> GetAllItems();

    }
}
