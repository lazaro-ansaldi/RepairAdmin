using System;
using System.Collections.Generic;
using System.Linq;
using Entities.Entidades;
using System.Data.Entity;
using DataAccess.Repositories.Interfaces;
using DataAccess.Context;

namespace DataAccess.Repositories
{
    public class ModelRepository : IBaseRepository<Modelo>
    {
        private PhonesContext _context;

        public IEnumerable<Modelo> GetAll()
        {
            using (_context = new PhonesContext())
            {
                // Recupero todos los modelos con el objeto marca relacionado //
                return _context.Modelos.Include(m => m.Marca).ToList();
            }
        }

        public void Insert(Modelo model)
        {
            using (_context = new PhonesContext())
            {
                _context.Entry(model.Marca).State = EntityState.Unchanged;
                _context.Entry(model).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Update(Modelo model)
        {
            using (_context = new PhonesContext())
            {
                _context.Entry(model).State = EntityState.Modified;
                _context.Entry(model.Marca).State = EntityState.Unchanged;            
                _context.SaveChanges();
            }
        }

        public void Delete(Modelo model)
        {
           using(_context = new PhonesContext())
            {
                model = _context.Modelos.Find(model.Id);
                _context.Entry(model).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public Modelo FindOneById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
