using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTransportationService.Abstraction.Interfaces
{
    internal interface IDataBaseRepository<T>
    {
        void Add(T entity);
        void Update(int id, T NewEntity);
        void Remove(int id);
        T GetItem(int id);
        List<T> GetAll();
    }
}
