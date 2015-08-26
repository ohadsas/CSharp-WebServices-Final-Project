using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WeatherDataService
{
    /// <summary>
    /// WeatherData class  - connect to API and returns current location weather data
    /// </summary>


    public class WeatherData : IWeatherDataService
    {
        /// <summary>
        ///weatherData is a Singleton var 
        ///locationWeather is object to download the current location data
        /// </summary>
        private static readonly WeatherData weatherData = new WeatherData(); // singleton

        private Forecast locationForecast; // Forecast object

        private WeatherData()
        {

        } // private contractor

        /// <summary>
        /// Get weather data instance
        /// </summary>
        /// <param name="location">receive location object as parameter</param>
        /// <returns>returns the instance  </returns>
        public WeatherData getWeatherData(Location location)
        {
            if (location != null)
            {
                init(location);// init forecast
            }
            else throw new WeatherDataServiceException("No location set");
            return weatherData;
        }

        /// <summary>
        /// static getWeatherDataService
        /// </summary>
        /// <returns>returns data</returns>
        public static WeatherData getWeatherDataService()
        {
            return weatherData;
        }

        /// <summary>
        /// Forecast property
        /// </summary>

        public Forecast LocationForecast
        {
            get
            {
                return locationForecast;
            }
            private set { }
        }

        /// <summary>
        /// Init database , download from web service API and load data from file database
        /// </summary>
        private void init(Location location) // init data 
        {
            DownloadXmlToDataBase(location.City, location.State);//download from API
            locationForecast = new Forecast(loadData(location.City, location.State));//allocate forecast

        }
        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return locationForecast.ToString();
        }


        #region DownloadXmlToDataBase
        /// <summary>
        /// Download XML file from API
        /// </summary>
        /// <param name="location">city field </param>
        /// <param name="state"> state fields</param>
        private static void DownloadXmlToDataBase(string location, string state)//not finish need to fix
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=" + location + "," + state + "&mode=xml";
            string dirPathOnDataBase = MakeDir(location.ToUpper() + "," + state.ToUpper()); // create city Dir in data base
            string xml;
            Console.WriteLine("Getting data from server...\n");
            try
            {
                using (WebClient web = new WebClient())
                {
                    xml = web.DownloadString(url);//get XML data to string
                }
                WriteToFile(ref xml, ref dirPathOnDataBase, ref location);
            }
            catch (WebException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message + "]\n\nReason: No Internet connection\n");
            }

        }
        #endregion

        #region MakeDir
        /// <summary>
        /// Create Dir for required data 
        /// </summary>
        /// <param name="dirName">contain the folder name in the data base</param>
        /// <returns>returns the path to file in data base</returns>
        private static string MakeDir(string dirName)
        {
            string path = @"Data\City\";
            path += dirName.ToUpper();
            try
            {
                if (Directory.Exists(path) == false)
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Source);
            }
            return path;
        }
        #endregion

        #region WriteToFile
        /// <summary>
        /// Write data to database file
        /// </summary>
        /// <param name="data">data to write in database </param>
        /// <param name="path">data path in data base </param>
        /// <param name="fileName">XML name in data base</param>
        private static void WriteToFile(ref string data, ref string path, ref string fileName)
        {
            string fixedPath = path + "\\" + fileName;
            fixedPath += ".xml";

            try
            {
                File.WriteAllText(fixedPath, data);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Source);
            }
        }
        #endregion

        #region loadData
        /// <summary>
        /// load data from database
        /// </summary>
        /// <param name="location">wanted country city in database</param>
        /// <param name="state">wanted state  in database</param>
        /// <returns></returns>
        private string loadData(string location, string state) // load data from file
        {
            var doc = new XmlDocument();
            var tempCity = location;
            var tempState = state;
            try
            {
                doc.Load(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Data\City\" + tempCity.ToUpper() + "," + tempState.ToUpper() + "\\" + location + ".xml");

            }
            catch (FileNotFoundException e)
            {

                Console.WriteLine(e.Message + "\n");
                Console.ReadLine();
                Environment.Exit(0);

            }
            return doc.InnerXml;
        }
        #endregion
    }

}
