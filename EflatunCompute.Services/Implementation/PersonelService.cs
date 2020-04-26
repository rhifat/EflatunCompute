using EflatunCompute.Entity;
using EflatunCompute.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EflatunCompute.Services.Implementation
{
    public class PersonelService : IPersonelService
    {
        private readonly ApplicationDbContext _context;
        public PersonelService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task CreateAsync(Personel yeniPersonel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int personelId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Personel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Personel GetById(int personelId)
        {
            throw new NotImplementedException();
        }

        public decimal IsUnvani(int id)
        {
            throw new NotImplementedException();
        }

        public decimal OdemeTipi(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Personel personel)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
