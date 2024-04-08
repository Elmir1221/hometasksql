using EntityFrameworkConsole.Models;
using EntityFrameworkConsole.Services;
using EntityFrameworkConsole.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsole.Controllers
{
    internal class CityController 
    {
        private readonly ICityService _cityService;

        public CityController()
        {
            _cityService = new CityService();
        }

        public async Task GetAllByCountryId()
        {
            Console.WriteLine("Add country id:");
            int  countryId = int.Parse(Console.ReadLine());


            var cities = await _cityService.GetAllByCountryId(countryId);

            foreach (var item in cities)
            {
                string data = $"Name: {item.Name}, Country: {item.Country.Name}";
                Console.WriteLine(data);

            }
        }

        public async Task GetAllAsync()
        {
            var datas = await _cityService.GetAllAsync();

            foreach (var item in datas)
            {
                string data = $"Name: {item.Name}, Country: {item.Country.Name}";
                Console.WriteLine(data);

            }
        }

        public async Task CreateAsync()
        {
            Console.WriteLine("Add name:");
            string name = Console.ReadLine();

            Console.WriteLine("Add Country Id:");
            int countryId = int.Parse(Console.ReadLine());

            await _cityService.CreateAsync(new City { Name = name, CountryId= countryId });
            Console.WriteLine("Data created");
        }


        public async Task DeleteAsync()
        {
            try
            {
                Console.WriteLine("Add city Id:");
                int id = Convert.ToInt32(Console.ReadLine());


                await _cityService.DeleteAsync(id);
                Console.WriteLine("Data deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public async Task GetByIdAsync()
        {
            Console.WriteLine("Add city Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            try
            {
                var data = await _cityService.GetByIdAsync(id);


                string result = $"Name: {data.Name}, Country: {data.Country.Name}";
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

    }
}
