using EFTraining2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTraining2.Service
{
    public static class CityService
    {
        public static List<City> GetAll()
        {
            WebUserContext context = new WebUserContext();
            List<City> cities = context.Cities.ToList();

            return cities;

        }
    }
}
