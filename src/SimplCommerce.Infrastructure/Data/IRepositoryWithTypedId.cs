using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Infrastructure.Data
{
    public interface IRepositoryWithTypedId<T, in TId> : 
        Neptrix.Data.IRepositoryV1<T>, Neptrix.Data.IDataQuery<T>
        //where T : IEntityWithTypedId<TId>
    {
        //IQueryable<T> Query();

        void Add(T entity);

        IDbContextTransaction BeginTransaction();

        void SaveChanges();

        Task SaveChangesAsync();

        void Remove(T entity);
    }
}
