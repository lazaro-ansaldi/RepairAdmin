using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Entidades;
using DataAccess.Repositories.Interfaces;
using DataAccess.Context;
using System.Data.Entity;

namespace DataAccess.Repositories
{
    public class OrderRepository : IBaseRepository<RepairOrder>
    {
        private PhonesContext _context;

        public Task Delete(RepairOrder entity)
        {
            throw new NotImplementedException();
        }

        public Task<RepairOrder> FindOneById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RepairOrder>> GetAll()
        {
            using (_context = new PhonesContext())
            {
                return await _context.RepairOrders.Include(rp => rp.Cliente).Include(rp => rp.Phone.Modelo).ToListAsync();
            }
        }

        public async Task Insert(RepairOrder entity)
        {
            using (_context = new PhonesContext())
            {
                _context.Entry(entity.Phone).State = EntityState.Modified;
                _context.Entry(entity.Cliente).State = EntityState.Modified;
                _context.Entry(entity).State = EntityState.Added;
                await _context.SaveChangesAsync();
            }
        }

        public async Task Update(RepairOrder entity)
        {
            using (_context = new PhonesContext())
            {
                _context.Entry(entity.Phone).State = EntityState.Modified;
                _context.Entry(entity.Cliente).State = EntityState.Modified;
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }
    }
}
