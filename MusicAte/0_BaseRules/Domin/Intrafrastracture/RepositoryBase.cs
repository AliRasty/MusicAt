using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace _0_BaseRules.Domin.Intrafrastracture
{
    internal class RepositoryBase<TKey, T> : IRepository<TKey, T> where T : class
    {

        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }
      



        public T Get(TKey key)
        {
            return _context.Find<T>(key);
        }

        public void Create(T entity)
        {
             _context.Add<T>(entity);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
