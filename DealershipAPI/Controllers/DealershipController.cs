using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealershipAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DealershipController : ControllerBase
    {
        public List<string> Make = new List<string>() {"Toyota","Mazda","Nissan","Honda","Cursed"};
        public List<string> Model = new List<string>() { "Corolla", "RX-7", "Ultimate", "Civic", "Sedan" };
        public List<int> Year = new List<int>() { 2002, 1995, 2020, 2015, 666 };
        public List<string> Color = new List<string>() { "Black", "White", "Orange", "Red", "Evil" };

        //[HttpGet]
        //public List<string> GetAllCars(List<string> Make, List<string> Model, List<int> Year, List<string> Color)
        //{
        //    return (Make, Model, Year, Color);
        //}

        [HttpGet("AllMakes")]
        public List<string> GetAllMakes()
        {
            return Make;
        }

        [HttpGet("AllModels")]
        public List<string> GetAllModels()
        {
            return Model;
        }


    }
}
