using System;
using System.Collections.Generic;
using System.Linq;
using Entities.Entidades;
using System.Data.SqlClient;
using System.Data.Entity;

namespace DataAccess.Repositories
{
    class ModelRepository : GenericRepository
    {

        public new IEnumerable<Modelo> GetAll()
        {
            _context = new PhonesContext();
            List<Modelo> listModels = new List<Modelo>();
            try
            {
                 listModels =_context.Modelos.ToList();
            }
            catch(SqlException sqlex)
            {

            }
            catch(Exception ex)
            {

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

            }
            catch(Exception ex)
            {

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

            }
            catch(Exception ex)
            {

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

            }
            catch(Exception ex)
            {

            }
            finally
            {
                _context = null;
            }
        }
    }
}
