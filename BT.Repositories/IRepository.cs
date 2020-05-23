using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll(Func<T, bool> predicate = null);
        IQueryable<T> AsQuerable();
        T Get(Func<T,bool> predicate);
        void Add(T entity);
        void Attach(T entity);
        void Delete(T entity);
    }
}
