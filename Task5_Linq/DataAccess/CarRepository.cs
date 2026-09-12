using Task5_Linq.Domain.Abstract;
using Task5_Linq.Domain.Entities;

namespace Task5_Linq.DataAccess
{
    public class CarRepository : ICarRepository
    {
        private readonly Task5DbContext _context;

        public CarRepository(Task5DbContext context)
        {
            _context = context;
        }

        public void Add(Car obj) => _context.Cars.Add(obj);

        public void Delete(Car obj)
        {
            if (obj is not null)
                _context.Cars.Remove(obj);
        }

        public IEnumerable<Car> GetIsNewCars() => from c in _context.Cars
                                                  where c.IsNew == true
                                                  select c;

        public IEnumerable<Car> GetAll() => from c in _context.Cars
                                            select c;

        public IEnumerable<Car> GetMarkaAndModelSearch(string marka, string model)
        {
            var cars = from c in _context.Cars
                       where c.Marka.Contains(marka) && c.Model.Contains(model)
                       select c;
            return cars.ToList();
        }

        public IEnumerable<Car> GetPriceFilter(int maxprice, int minprice = 0)
        {
            if (minprice < 0 || maxprice < 0)
                Console.WriteLine("MinPrice ve ya MaxPrice 0-dan kicik ola bilmez");

            if (maxprice < minprice)
                Console.WriteLine("Deyerler duzgun verilmeyib.");

            var cars = from c in _context.Cars
                       where c.Price >= minprice && c.Price <= maxprice
                       select c;
            return cars.ToList();
        }

        public IEnumerable<IGrouping<string?, Car>> GetMarkaGroup() => from c in _context.Cars
                                                                       group c by c.Marka into myGroup
                                                                       select myGroup;

        public bool SaveChanges() => _context.SaveChanges() > 0;

        public void Update(Car obj) => _context.Cars.Update(obj);
    }
}


//SEHVNEN BELE YAZMISDIM GITHUB DA YENILIK ETDIM SONRA BILDIM !!! SILMEDIM YENI BELEDE YAZMISAM





//public IEnumerable<Car> GetIsNewCars() => _context.Cars
//                        .Where(c => c.IsNew == true);
//public IEnumerable<Car> GetAll() => _context.Cars;
//public IEnumerable<Car> GetMarkaAndModelSearch(string marka, string model) => _context.Cars
//                                           .Where(c => c.Marka == marka && c.Model == model)
//                                           .ToList();
//public IEnumerable<Car> GetPriceFilter(int maxprice, int minprice = 0)
//{
//    if (minprice < 0 || maxprice < 0)
//        Console.WriteLine("MinPrice ve ya MaxPrice 0-dan kicik ola bilmez");
//    if (maxprice < minprice)
//        Console.WriteLine("Deyer ler duzgun verilmeyib.");

//    return _context.Cars
//         .Where(c => c.Price >= minprice && c.Price <= maxprice)
//         .ToList();
//}
//public IEnumerable<IGrouping<string?, Car>> GetMarkaGroup() => _context.Cars
//                                           .GroupBy(c => c.Marka);