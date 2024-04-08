using EntityFrameworkConsole.Data;
using EntityFrameworkConsole.Helpers.Exceptions;
using EntityFrameworkConsole.Models;
using EntityFrameworkConsole.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsole.Services
{
    internal class CityService : ICityService
    {
        private readonly AppDbContext _context;

        public CityService()
        {
            _context = new AppDbContext();
            
        }

        public async Task CreateAsync(City city)
        {
            await _context.Cities.AddAsync(city);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int? id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            var data = _context.Cities.FirstOrDefault(m => m.Id == id);

            if (data == null)
            {
                throw new NotFoundException("Data not found");
            }

            _context.Cities.Remove(data);

            await _context.SaveChangesAsync();
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await _context.Cities.Include(m => m.Country).ToListAsync();
        }

        public async Task<List<City>> GetAllByCountryId(int id)
        {
           return await _context.Cities.Include(m => m.Country).Where(m=> m.CountryId == id).ToListAsync();
        }

        public async Task<City> GetByIdAsync(int id)
        {
            var data = _context.Cities.Include(m => m.Country).FirstOrDefault(m => m.Id == id);

            if (data == null)
            {
                throw new NotFoundException("Data not found");
            }
            return data;
        }
    }
}
