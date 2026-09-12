using Task5_Linq.DataAccess;
using Task5_Linq.Domain.Entities;

internal class Program
{
    private static readonly Task5DbContext _context = new();

    private static void Main(string[] args)
    {
        CarRepository carRepository = new(_context);

        //carRepository.Add(new Car()
        //{ Marka = "Mercedes-Benz", Model = "G500", Color = Color.Orange, CustomerId = 1, IsNew = true, Price = 99999, Year = 2025 });


        //var cars = carRepository.GetAll();

        //foreach (var item in cars)
        //{
        //    //console.writeline(item.marka);
        //    //console.writeline(item.model);
        //}


        //GetPriceFilter() --
        //var cars1 = carRepository.GetPriceFilter(34000, 13000);

        //foreach (var car in cars1)
        //{
        //    Console.WriteLine(car.Marka);
        //    Console.WriteLine(car.Model);
        //    Console.WriteLine(car.Price);
        //    Console.WriteLine(car.Year);
        //    Console.WriteLine(car.IsNew);
        //    Console.WriteLine("--------------------------");
        //}

        //GetMarkaAndModelSearch()--
        //var cars = carRepository
        //    .GetMarkaAndModelSearch("Mercedes", "C3"); //Contains Method+
        //Console.WriteLine("Found Cars\n");

        //foreach (var car in cars)
        //{
        //    Console.WriteLine(car.Marka);
        //    Console.WriteLine(car.Model);
        //    Console.WriteLine(car.Price);
        //    Console.WriteLine(car.Year);
        //    Console.WriteLine(car.Customer);
        //    Console.WriteLine(car.IsNew);
        //    Console.WriteLine("--------------------------");
        //}

        //GetIsNewCars()
        //var cars2 = carRepository.GetIsNewCars();
        //Console.WriteLine("Found Cars\n");
        //foreach (var car in cars2)
        //{
        //    Console.WriteLine(car.Marka);
        //    Console.WriteLine(car.Model);
        //    Console.WriteLine(car.Price);
        //    Console.WriteLine(car.Year);
        //    //Console.WriteLine(car.Customer);
        //    Console.WriteLine(car.IsNew);
        //    Console.WriteLine("--------------------------");
        //}

        ////GetMarkaGroup()
        //var cars3 = carRepository.GetMarkaGroup();

        //foreach (var group in cars3)
        //{
        //    Console.WriteLine($"Marka: {group.Key}");
        //    foreach (var car in group)
        //    {
        //        Console.WriteLine($"Model: {car.Model}");
        //        Console.WriteLine($"Price: {car.Price}");
        //        Console.WriteLine($"Year: {car.Year}");
        //        Console.WriteLine($"IsNew: {car.IsNew}");
        //        Console.WriteLine("--------------------------");
        //    }
        //    Console.WriteLine("--------------------------");
        //}
        carRepository.SaveChanges();
        Console.ReadKey();
    }
}