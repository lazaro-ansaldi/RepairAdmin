using System;
using System.Collections.Generic;
using Entities;
using Util;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    public class GenericRepository : IRepository
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
                throw new AppException("Ocurrió un error al guardar los cambios en la base de datos.", "Error", sqlex);
            }
            catch(Exception ex)
            {
                throw new AppException("Se produjo un error no esperado al intentar guardar los cambios en la base de datos.", "Fatal", ex);
            }
        }
    }
}
