using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity;
using ManagePhones.DataAccess.Repositories.Interfaces;
using ManagePhones.DataAccess.Context;
using ManagePhones.Entities.Entidades;

namespace ManagePhones.DataAccess.Repositories
{
    public class PhoneRepository : IBaseRepository<Phone>
    {
        private PhonesContext _context;

        public async Task Delete(Phone entity)
        {
            using (_context = new PhonesContext())
            {
                _context.Entry(entity).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Phone> FindOneById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Phone>> GetAll()
        {
            using (_context = new PhonesContext())
            {
                return await _context.Phones.Include(p => p.Modelo).ToListAsync();
            }
        }

        public async Task Insert(Phone entity)
        {
            using (_context = new PhonesContext())
            {
                _context.Entry(entity.Modelo).State = EntityState.Modified;
                _context.Entry(entity).State = EntityState.Added;
                await _context.SaveChangesAsync();
            }
        }

        public async Task Update(Phone entity)
        {
            using (_context = new PhonesContext())
            {
                _context.Entry(entity.Modelo).State = EntityState.Modified;
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }
    }
}
