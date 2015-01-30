using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BuenaHealth.Core.Services;

namespace BuenaHealth.Infrastructure.Stubs
{
    public class InMemoryRepository<T> : IRepository<T> where T : class
    {
        private readonly List<T> _list;

        public InMemoryRepository(List<T> list)
        {
            _list = list;
        }

        public IQueryable<T> AsQueryable()
        {
            return _list.AsQueryable();
        }

        public IEnumerable<T> GetAll()
        {
            return _list;
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _list.AsQueryable().Where(predicate);
        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            return _list.AsQueryable().Single(predicate);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _list.AsQueryable().SingleOrDefault(predicate);
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return _list.AsQueryable().First(predicate);
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            _list.Add(entity);

        }

        public void Delete(T entity)
        {
            _list.Remove(entity);
        }

        public void Attach(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
