using System;
using System.Collections.Generic;

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
