using DataAccess.Context;
using DataAccess.Repositories.Interfaces;
using Entities.Entidades;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace DataAccess.Repositories
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
            throw new NotImplementedException();
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
