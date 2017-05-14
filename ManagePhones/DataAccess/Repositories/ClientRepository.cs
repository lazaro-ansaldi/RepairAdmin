using System.Collections.Generic;
using System.Data.Entity;
using System;
using System.Threading.Tasks;
using ManagePhones.DataAccess.Repositories.Interfaces;
using ManagePhones.DataAccess.Context;
using ManagePhones.Entities.Entidades;

namespace ManagePhones.DataAccess.Repositories
{
    public class ClientRepository : IBaseRepository<Cliente>
    {
        private PhonesContext _context;

        public async Task Delete(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Cliente> FindOneById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            using (_context = new PhonesContext())
            {
                return await _context.Clientes.ToListAsync();
            }
        }

        public async Task Insert(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
