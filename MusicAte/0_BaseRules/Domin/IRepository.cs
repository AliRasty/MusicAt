using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace _0_BaseRules.Domin
{
    public interface IRepository<TKey,T> where T : class
    {
        T Get(TKey key);

        void Create(T entity);
        List<T> GetAll();

        bool Exists(Expression<Func<T,bool>> expression);
        void SaveChanges();
    }
}
