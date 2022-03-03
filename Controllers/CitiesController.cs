using Microsoft.AspNetCore.Mvc;
using Preon.IService;
using Preon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Preon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        ICityService _cityService = null;

        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }


        // GET: api/<CitiesController>
        [HttpGet("getall")]
        public IEnumerable<City> GetCities()
        {
            return _cityService.GetCities();
        }

        // GET api/<CitiesController>/5
        [HttpGet("{id}", Name = "Get")]
        public City Get(int id)
        {
            return _cityService.GetById(id);
        }



    }
}
