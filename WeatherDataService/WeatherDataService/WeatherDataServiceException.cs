using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataService
{
    /// <summary>
    /// WeatherDataService class to  deals with exception
    /// </summary>
    class WeatherDataServiceException : Exception
    {
        /// <summary>
        /// WeatherDataServiceException
        /// </summary>
        /// <param name="str">Exception massage</param>
        public WeatherDataServiceException(string str)
            : base(str) { }
    }
}

