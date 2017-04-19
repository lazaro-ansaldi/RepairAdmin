using System;
using System.Collections.Generic;
using System.Linq;
using Entities.Entidades;
using DataAccess.Repositories.Interfaces;
using DataAccess.Context;

namespace DataAccess.Repositories
{
    public class MarcaRepository : IBaseRepository<Marca>
    {
        private PhonesContext _context;

        public void Delete(Marca entity)
        {
            throw new NotImplementedException();
        }

        public Marca FindOneById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Marca> GetAll()
        {
            using (_context = new PhonesContext())
            {
                return _context.Marcas.ToList();
            }                      
        }

        public void Insert(Marca entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Marca entity)
        {
            throw new NotImplementedException();
        }
    }
}
