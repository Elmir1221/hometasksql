//using EntityFrameworkConsole.Data;

//AppDbContext context = new AppDbContext();
//void GetAllSettings()
//{
//    var datas = context.Settings.ToList();

//    foreach (var item in datas)
//    {
//        Console.WriteLine(item.Address + " " + item.Email + " " + item.Phone);
//    }
//}

//void GetById(int id)
//{
//    var data = context.Settings.FirstOrDefault(m => m.Id == id);
//    Console.WriteLine(data.Address + " " + data.Email + " " + data.Phone);

//}

//GetAllSettings();
//Console.WriteLine("~~~~~~~~~~~~~~~~~");
//GetById(1);




using EntityFrameworkConsole.Controllers;

//SettingController settingController = new SettingController();

//await settingController.GetAllAsync();

////await settingController.GetByIdAsync();

////await settingController.CreateAsync();


//await settingController.DeleteAsync();

CityController cityController = new CityController();

//await cityController.GetAllByCountryId();

//await cityController.GetAllAsync();

//await cityController.DeleteAsync();

//await cityController.GetByIdAsync();

//await cityController.CreateAsync();





CountryController countryController = new CountryController();

//await countryController.CreateAsync();

//await countryController.GetAllAsync();

//await countryController.DeleteAsync();

//await countryController.GetByIdAsync();







