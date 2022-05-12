using Microsoft.EntityFrameworkCore;
using HW_10.infrastructure.DataBase;
using HW_10.Models;
namespace HW_10.infrastructure.DataAccess
{
    public class EF_Repository
    {
        private LibraryContext _LibraryDB=new LibraryContext();

        public EF_Repository()
        {
           
            _LibraryDB = new LibraryContext();
        }


        public List<QureryModelLibrary> GetAllInfoLibarary()
        {
            var result =
               (from L in _LibraryDB.Librarys
                join C in _LibraryDB.Citys on L.cityId equals C.ID
                select new QureryModelLibrary
                {
                    id = 1,
                    cityname = C.CityName,
                    Libararyaddress = L.LibraryAddress,

                }).ToList();


            return result;
            
        }
    }
}
