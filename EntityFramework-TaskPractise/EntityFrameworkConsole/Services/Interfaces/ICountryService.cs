using EntityFrameworkConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsole.Services.Interfaces
{
    internal interface ICountryService
    {

        Task<Country> GetByIdAsync(int id);

        Task<List<Country>> GetAllAsync();

        Task CreateAsync(Country country);
        Task DeleteAsync(int? id);
    }
}
