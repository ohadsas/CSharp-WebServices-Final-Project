using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataService
{
    /// <summary>
    /// WeatherDataServiceFactory 
    /// </summary>
    public class WeatherDataServiceFactory
    {
        /// <summary>
        /// Enumes for wanted service providers
        /// </summary>
        public enum Service
        {
            /// <summary>
            /// OPEN_WEATHER_MAP is Enum var for weather service 
            /// </summary>
            OPEN_WEATHER_MAP
        }
        /// <summary>
        /// This method return instance of the wanted service
        /// </summary>
        /// <param name="service">gets the wanted service</param>
        /// <returns></returns>
        public static WeatherData getWeatherDataService(Service service)
        {

            switch (service)
            {
                case Service.OPEN_WEATHER_MAP:
                    {
                        try
                        {
                            return WeatherData.getWeatherDataService();
                        }
                        catch (WeatherDataServiceException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    break;
            }
            return null;
        }
    }
}
