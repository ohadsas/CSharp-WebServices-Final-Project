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
            Location[] myLocation = { new Location("uk", "london"), new Location("il", "telaviv") };//create locations
            IWeatherDataService service = WeatherDataServiceFactory.getWeatherDataService(WeatherDataServiceFactory.Service.OPEN_WEATHER_MAP);//get instance
            for (int i = 0 ; i < myLocation.Length ; i++)
            {
                Console.WriteLine(service.getWeatherData(myLocation[i]));//print
            }
        }
    }
}
