using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_Generics
{
    internal interface IEntity
    {
        int Id { get; }
    }

    internal class Repository<T> where T : IEntity
    {
        private List<T> _values = new List<T>();

        public void Add(T entity)
        {
            _values.Add(entity);
        }
    }
}
