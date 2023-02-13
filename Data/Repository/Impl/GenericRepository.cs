using Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository.Impl
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private GastosContext _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new GastosContext();
            table = _context.Set<T>();
        }

        public GenericRepository(GastosContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
