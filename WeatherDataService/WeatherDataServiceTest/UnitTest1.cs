using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherDataService;
using System.Net;

namespace WeatherDataServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Check if on line
        /// </summary>
        [TestMethod]
      [ExpectedException(typeof(WebException))]
        public void TestMethod1()
        {
           
            string url = "http://api.openweathermap.org/data/2.5/weather?q=" + "il" + "," + "telaviv" + "&mode=xml";
            string xml;
            Console.WriteLine("Getting data from server...\n");
          
                using (WebClient web = new WebClient())
                {
                    xml = web.DownloadString(url);//get XML data to string
                }
           
         
        }
    }
}
