using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherDataService;

namespace WeatherDataServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Check if user get data service instance 
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull(WeatherDataServiceFactory.getWeatherDataService(WeatherDataServiceFactory.Service.OPEN_WEATHER_MAP));
        }
    }
}
