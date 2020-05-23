using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace BT.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        protected IDbSet<T> _objectSet;

        public EfRepository(DbContext db)
        {
            _objectSet = db.Set<T>();
        }

        public void Add(T entity)
        {
            _objectSet.Add(entity);
        }

        public IQueryable<T> AsQuerable()
        {
            return _objectSet.AsQueryable();
        }

        public void Attach(T entity)
        {
            _objectSet.Attach(entity);
        }

        public void Delete(T entity)
        {
            _objectSet.Remove(entity);
        }

        public T Get(Func<T, bool> predicate)
        {
                return _objectSet.FirstOrDefault(predicate);
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate = null)
        {
            if(predicate!=null)
            {
                return _objectSet.Where(predicate);
            }
            return _objectSet.AsEnumerable();
        }
    }
}
