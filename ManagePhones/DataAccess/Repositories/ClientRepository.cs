using DataAccess.Context;
using DataAccess.Repositories.Interfaces;
using Entities.Entidades;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Repositories
{
    public class ClientRepository : IBaseRepository<Cliente>
    {
        private PhonesContext _context;

        public void Delete(Cliente entity)
        {
            using(_context = new PhonesContext())
            {
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public Cliente FindOneById(int id)
        {
            using (_context = new PhonesContext())
            {
                var cliente = (from c in _context.Clientes where c.Id == id select c).SingleOrDefault();
                return cliente;
            }          
        }

        public IEnumerable<Cliente> GetAll()
        {
            using(_context=new PhonesContext())
            {
                return _context.Clientes.ToList();
            }
        }

        public void Insert(Cliente entity)
        {
            using(_context = new PhonesContext())
            {
                _context.Entry(entity).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Update(Cliente entity)
        {
            using (_context = new PhonesContext())
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
