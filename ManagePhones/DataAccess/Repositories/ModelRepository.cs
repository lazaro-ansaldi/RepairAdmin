using System;
using System.Collections.Generic;
using System.Linq;
using Entities.Entidades;
using System.Data.Entity;
using DataAccess.Repositories.Interfaces;
using DataAccess.Context;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ModelRepository : IBaseRepository<Modelo>
    {
        private PhonesContext _context;

        public async Task<IEnumerable<Modelo>> GetAll()
        {
            using (_context = new PhonesContext())
            {
                // Recupero todos los modelos con el objeto marca relacionado //
                return await _context.Modelos.Include(m => m.Marca).ToListAsync();
            }
        }

        public async Task Insert(Modelo model)
        {
            using (_context = new PhonesContext())
            {
                _context.Entry(model.Marca).State = EntityState.Unchanged;
                _context.Entry(model).State = EntityState.Added;
                await _context.SaveChangesAsync();
            }
        }

        public async Task Update(Modelo model)
        {
            using (_context = new PhonesContext())
            {
                _context.Entry(model).State = EntityState.Modified;
                _context.Entry(model.Marca).State = EntityState.Unchanged;            
                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(Modelo model)
        {
           using(_context = new PhonesContext())
            {
                model = _context.Modelos.Find(model.Id);
                _context.Entry(model).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Modelo> FindOneById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
