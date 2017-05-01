using System;
using System.Collections.Generic;
using System.Linq;
using Entities.Entidades;
using DataAccess.Repositories.Interfaces;
using DataAccess.Context;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccess.Repositories
{
    public class MarcaRepository : IBaseRepository<Marca>
    {
        private PhonesContext _context;

        public Task Delete(Marca entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Marca> FindOneById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Marca>> GetAll()
        {
            using (_context = new PhonesContext())
            {
                return await _context.Marcas.ToListAsync();
            }                      
        }

        public async Task Insert(Marca entity)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Marca entity)
        {
            throw new NotImplementedException();
        }
    }
}
