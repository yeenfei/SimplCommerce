using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Module.Core.Data
{
    public class RepositoryWithTypedId<T, TId> : IRepositoryWithTypedId<T, TId> 
        where T : class, Neptrix.Data.IDomainObject<long> //IEntityWithTypedId<TId>
    {
        public RepositoryWithTypedId(SimplDbContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        protected DbContext Context { get; }

        protected DbSet<T> DbSet { get; }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public IDbContextTransaction BeginTransaction()
        {
            return Context.Database.BeginTransaction();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }

        public IQueryable<T> Query()
        {
            return DbSet;
        }

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        public T GetById(int? id)
        {
            throw new System.NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public T Create(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Merge(T refObj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public List<T> Create(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }

        public List<T> Update(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }

        public List<T> Merge(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }
    }
}
