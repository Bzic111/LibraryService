using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Services.impl
{
    public interface IRepository<T,TId>
    {
        int? Add(T item);
        int Update(T item);
        int Delete(T item);
        IList<T> GetAll();
        T GetById(TId id);
    }
}
