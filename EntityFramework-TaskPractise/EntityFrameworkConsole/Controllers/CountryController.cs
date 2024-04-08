using EntityFrameworkConsole.Services.Interfaces;
using EntityFrameworkConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkConsole.Models;

namespace EntityFrameworkConsole.Controllers
{
    internal class CountryController
    {

        private readonly ICountryService _countryService;
        public CountryController()
        {
            _countryService = new CountryService();
        }


        public async Task GetAllAsync()
        {
            var datas = await _countryService.GetAllAsync();

            foreach (var item in datas)
            {
                string data = $"Name: {item.Name}, Population: {item.Population}";
                Console.WriteLine(data);

            }
        }

        public async Task DeleteAsync()
        {
            try
            {
                Console.WriteLine("Add country Id:");
                int id = Convert.ToInt32(Console.ReadLine());


                await _countryService.DeleteAsync(id);
                Console.WriteLine("Data deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public async Task GetByIdAsync()
        {
            Console.WriteLine("Add country Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            try
            {
                var data = await _countryService.GetByIdAsync(id);


                string result = $"Name: {data.Name}, Population: {data.Population}";
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public async Task CreateAsync()
        {
            Console.WriteLine("Add name:");
            string name = Console.ReadLine();

            Console.WriteLine("Add population:");
            int population = Convert.ToInt32(Console.ReadLine());



            await _countryService.CreateAsync(new Country { Name = name, Population = population });

            Console.WriteLine("Data succesfully added");
        }
    }
}
