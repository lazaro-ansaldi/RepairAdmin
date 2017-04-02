using System.Collections.Generic;
using Entities;

namespace DataAccess.Repositories
{
    interface IRepository
    {
        IEnumerable<IEntity> GetAll();

        void Insert(IEntity entity);

        void Delete(IEntity entity);

        void Update(IEntity entity);

        IEntity FindOneById(int id);
    }
}
