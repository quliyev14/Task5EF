namespace Task5_Linq.Domain.Abstract
{
    public interface IRepository<T> where T : class
    {
        void Add(T obj);
        void Delete(T obj);
        void Update(T obj);
        IEnumerable<T> GetAll();
        //5. Qiymətə görə filter
        IEnumerable<T> GetPriceFilter(int maxprice, int mixprice = 0);
        //6. Marka və modelə görə Search
        IEnumerable<T> GetMarkaAndModelSearch(string marka, string model);
        //7. Yeni avtomobillərin filter edilməsi
        //Yalnız yeni(IsNew = true) avtomobilləri göstərin.
        IEnumerable<T> GetIsNewCars();
        //8. Marka üzrə Grouping
        IEnumerable<IGrouping<string, T>> GetMarkaGroup();
        bool SaveChanges();
    }
}