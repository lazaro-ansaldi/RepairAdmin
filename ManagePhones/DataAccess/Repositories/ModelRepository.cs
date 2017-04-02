using System;
using Util;
using System.Collections.Generic;
using System.Linq;
using Entities.Entidades;
using System.Data.SqlClient;
using System.Data.Entity;

namespace DataAccess.Repositories
{
    public class ModelRepository : GenericRepository
    {

        public new IEnumerable<Modelo> GetAll()
        {
            _context = new PhonesContext();
            List<Modelo> listModels = new List<Modelo>();
            try
            {
                // Recupero todos los modelos con el objeto marca relacionado //
                 listModels =_context.Modelos.Include(m => m.Marca).ToList();
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch(SqlException sqlex)
            {
                throw new AppException("Se produjo un error al consultar la tabla de modelos.", "Error", sqlex);
            }
            catch(Exception ex)
            {
                throw new AppException("Ocurrió un error no esperado al consultar los modelos.", "Fatal", ex);
            }
            finally
            {
                _context = null;
            }
            return listModels;
        }

        public void Insert(Modelo model)
        {
            _context = new PhonesContext();
            try
            {
                _context.Entry(model).State = EntityState.Added;
                base.SaveChanges();
            }
            catch(SqlException sqlex)
            {
                throw new AppException("Se produjo un error al actualizar la tabla de modelos.", "Error", sqlex);
            }
            catch(Exception ex)
            {
                throw new AppException("Ocurrió un error no esperado al intentar actualizar le modelo.", "Fatal", ex);
            }
            finally
            {
                _context = null;
            }
        }

        public void Update(Modelo model)
        {
            _context = new PhonesContext();
            try
            {
                _context.Entry(model).State = EntityState.Modified;
                base.SaveChanges();
            }
            catch(SqlException sqlex)
            {
                throw new AppException("Se produjo un error al actualizar la tabla de modelos.", "Error", sqlex);
            }
            catch(Exception ex)
            {
                throw new AppException("Ocurrió un error no esperado al intentar actualizar le modelo.", "Fatal", ex);
            }
            finally
            {
                _context = null;
            }
        }

        public void Delete(Modelo model)
        {
            _context = new PhonesContext();
            try
            {
                model = _context.Modelos.Find(model.Id);
                _context.Entry(model).State = EntityState.Deleted;
                base.SaveChanges();
            }
            catch(SqlException sqlex)
            {
                throw new AppException("Se produjo un error al actualizar la tabla de modelos.", "Error", sqlex);
            }
            catch(Exception ex)
            {
                throw new AppException("Ocurrió un error no esperado al intentar actualizar le modelo.", "Fatal", ex);
            }
            finally
            {
                _context = null;
            }
        }
    }
}
