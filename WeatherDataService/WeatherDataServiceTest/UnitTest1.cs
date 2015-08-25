using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherDataService;
namespace WeatherDataServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull(WeatherDataServiceFactory.getWeatherDataService(WeatherDataServiceFactory.OPEN_WEATHER_MAP));
        }
    }
}
