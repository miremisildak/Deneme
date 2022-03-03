using Preon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Preon.IService
{
    public interface ICityService
    {
        List<City> GetCities();
        City GetById(int CityId);

        //void Save(City oCity);
    }
}
