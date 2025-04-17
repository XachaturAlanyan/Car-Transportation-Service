using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTransportationService.Abstraction.Interfaces;

namespace CarTransportationService.Abstraction.Implementation
{
    internal class Repository<T> : IRepository<T> where T : new()
    {
        private readonly List<T> _list = new List<T>();
        public void Add(T entity)
        {
            _list.Add(entity);
        }

        public List<T> GetAll()
        {
            return _list;
        }
        public T GetItem(Func<T, bool> predicate)
        {
            T item = new T();
            _list.ForEach(X => 
            {
                if (predicate(X)) 
                {
                    item = X;
                }
            });
            return item;
        }

        public void Remove(T Entity)
        {
            _list.Remove(Entity);
        }

        public void Update(T OldEntity, T NewEntity)
        {
            _list.ForEach(x => 
            {
                if(x.Equals(OldEntity)) 
                {
                    x = NewEntity;
                }
            });
        }
    }
}
