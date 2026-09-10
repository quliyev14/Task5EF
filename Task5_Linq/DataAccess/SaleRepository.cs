//TASK DA CAR DAN SOHBET GEDIR DEYE BUNLARI YAZMADIM


using Task5_Linq.Domain.Abstract;
using Task5_Linq.Domain.Entities;

namespace Task5_Linq.DataAccess
{
    public class SaleRepository : ICarRepository
    {
        public void Add(Car obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetIsNewCars()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetMarkaAndModelSearch(string marka, string model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IGrouping<string, Car>> GetMarkaGroup()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetPriceFilter(int maxprice, int mixprice = 0)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Car obj)
        {
            throw new NotImplementedException();
        }
    }
}

