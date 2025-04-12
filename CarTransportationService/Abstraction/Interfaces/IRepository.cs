using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTransportationService.Abstraction.Interfaces
{
    internal interface IRepository<T>
    {
        void Add(T entity);
        void Update(T OldEntity, T NewEntity);
        void Remove(T Entity);

        T GetItem(Func<T,bool> predicate);
        List<T> GetAll();
    }
}
