using Preon.Context;
using Preon.IService;
using Preon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Preon.Service
{
    public class CityService : ICityService
    {
        private readonly DatabaseContext _context;

        public CityService(DatabaseContext context) 
        {
            _context = context;
        }
        public City GetById(int cityId)
        {
            return _context.Cities.SingleOrDefault(x => x.CityId == cityId);
        }

        public List<City> GetCities()
        {
            return _context.Cities.ToList();
        }
    }
}
