using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataService
{
    class Program
    {
        /// <summary>
        /// Starting application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Location[] myLocations = { new Location("uk", "london"), //Create Location objects
                                         new Location("il", "telaviv"),
                                         new Location("us", "newyork") };
            IWeatherDataService service = WeatherDataServiceFactory.getWeatherDataService(WeatherDataServiceFactory.Service.OPEN_WEATHER_MAP);//get data instance
            Console.WriteLine(service.getWeatherData(myLocations[1]));
        }
    }
}
