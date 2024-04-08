using EntityFrameworkConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsole.Services.Interfaces
{
    internal interface ICityService
    {
        Task<List<City>> GetAllByCountryId(int id);

        Task<List<City>> GetAllAsync();

        Task CreateAsync(City city);
        Task DeleteAsync(int? id);

        Task<City> GetByIdAsync(int id);

    }
}
