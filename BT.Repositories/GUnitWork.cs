using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Data.BT_EDMX;

namespace BT.Repositories
{
    public class GUnitWork
    {
        private DbContext _context;
        public GUnitWork(DbContext context)
        {
            _context = context;
        }

        public Dictionary<Type, object> repository = new Dictionary<Type, object>();

        public IRepository<T> Repository<T>() where T:class
        {
            if(repository.Keys.Contains(typeof(T)) == true)
            {
                return repository[typeof(T)] as IRepository<T>;
            }
            IRepository<T> repo = new EfRepository<T>(_context);
            repository.Add(typeof(T),repo);
            return repo;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public void BulkInsert<T>(IEnumerable<T> objects) where T : class
        {
            _context.Set<T>().AddRange(objects);
            _context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public static implicit operator GUnitWork(BestTravelingEntities v)
        {
            throw new NotImplementedException();
        }
    }
}
