using System.Collections.Generic;

namespace DataAccess.Repositories.Interfaces
{
    interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();

        void Insert(T entity);

        void Delete(T entity);

        void Update(T entity);

        T FindOneById(int id);
    }
}
