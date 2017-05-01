using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task Insert(T entity);

        Task Delete(T entity);

        Task Update(T entity);

        Task<T> FindOneById(int id);
    }
}
