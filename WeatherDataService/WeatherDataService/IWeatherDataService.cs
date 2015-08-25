using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataService
{

    /// <summary>
    /// WeatherDataService interface
    /// </summary>
     public interface IWeatherDataService
    {
        /// <summary>
        /// Interface method 
        /// </summary>
        /// <param name="location">var that contain the wanted location fields</param>
        /// <returns>Instance for weather data</returns>
       WeatherData getWeatherData(Location location);

    }
}
