using System;
using System.Collections.Generic;
using Entities;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    class GenericRepository : IRepository
    {
        protected PhonesContext _context;

        public virtual void Delete(IEntity entity)
        {                     
        }

        public virtual IEntity FindOneById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<IEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual void Insert(IEntity entity)
        {
        }

        public virtual void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch(SqlException sqlex)
            {

            }
            catch(Exception ex)
            {

            }
        }
    }
}
