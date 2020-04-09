using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class RepositoryBase<T> : Interfaces.IRepositoryBase<T> where T : Model.BaseModel
    {
        private PollContext _context;

        public RepositoryBase(PollContext context)
        {
            this._context = context;
        }

        public T GetById(long id)
        {
            var result = _context.Set<T>().Find(id);

            return result;
        }

        public void Insert(T model)
        {
            _context.Set<T>().Add(model);

            _context.SaveChanges();
        }

        public void Update(T model)
        {
            _context.Entry(model).State = EntityState.Modified;

            _context.SaveChanges();
        }

        public void Delete(T model)
        {
            _context.Set<T>().Remove(model);

            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var model = _context.Set<T>().First(x => x.Id == id);

            _context.Set<T>().Remove(model);

            _context.SaveChanges();
        }

        public IList<T> GetAll()
        {
            var result = _context.Set<T>().ToList();

            return result;
        }

        public IList<T> GetWhere(Func<T, bool> where)
        {
            var result = _context.Set<T>().Where(where).ToList();

            return result;
        }

        public T GetWhereFirst(Func<T, bool> where)
        {
            var result = _context.Set<T>().Where(where).FirstOrDefault();

            return result;
        }
    }
}
