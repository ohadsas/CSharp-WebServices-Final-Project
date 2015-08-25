using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeatherDataService
{
    /// <summary>
    /// This class contain all forecast data
    /// </summary>
   public class Forecast
    {

        /// <summary>
        /// Forecast var as API values
        /// </summary>
        private Location location;
        private SunRise sunRise;
        private Temperature temperature;
        private Humidity humidity;
        private Pressure pressure;
        private WindSpeed windSpeed;
        private WindDirection windDirection;
        private Clouds clouds;
        private Precipitation precipitation;
        private Weather weather;
        private Lastupdate lastupdate;

        /// <summary>
        /// Forecast class constructor
        /// </summary>
        /// <param name="xmlData">xmlData contain the XML string and send it to the parsing method</param>
        public Forecast(string xmlData) // get data and location object to fix location as appear in XML doc
        {

            initForecastObjects(); // allocate objects
            parsingXmlData(ref xmlData); // load data 
        }




        /// <summary>
        /// initForecastObjects init and allocate all forecast objects
        /// </summary>
        private void initForecastObjects()
        {
            this.location = new Location();
            this.sunRise = new SunRise();
            this.temperature = new Temperature();
            this.humidity = new Humidity();
            this.pressure = new Pressure();
            this.windSpeed = new WindSpeed();
            this.windDirection = new WindDirection();
            this.clouds = new Clouds();
            this.precipitation = new Precipitation();
            this.weather = new Weather();
            this.lastupdate = new Lastupdate();

        }
       /// <summary>
       /// ToString override
       /// </summary>
       /// <returns>string</returns>
        public override string ToString()
        {
            return ForecastLastupdate.ToString() + "\n\n" + ForecastLocation.ToString() + "\n" + ForecastWeather.ToString() + "\n" + ForecastSunRise.ToString() + "\n" + ForecastTemperature.ToString() + "\n" + ForecastHumidity + "\n" +
ForecastPressure.ToString() + "\n" + ForecastWindSpeed.ToString() + "\n" + ForecastWindDirection.ToString() + "\n" + ForecastClouds.ToString() + "\n" + ForecastPrecipitation.ToString();
        }

     
        #region Forecast inner classes properties
        /// <summary>
        /// ForecastLocation properties
        /// </summary>
        public Location ForecastLocation
        {
            get
            {
                return this.location;
            }
            private set
            {
                this.location = value;
            }
        }
       /// <summary>
        /// ForecastSunRise property
       /// </summary>
        public SunRise ForecastSunRise
        {
            get
            {
                return this.sunRise;
            }
            private set
            {
                this.sunRise = value;
            }
        }

        /// <summary>
        /// ForecastTemperature property
        /// </summary>
        public Temperature ForecastTemperature
        {
            get
            {
                return this.temperature;
            }
            private set
            {
                this.temperature = value;
            }
        }
        /// <summary>
        /// ForecastHumidity property
        /// </summary>
        public Humidity ForecastHumidity
        {
            get
            {
                return this.humidity;
            }
            private set
            {
                this.humidity = value;
            }
        }
        /// <summary>
        /// ForecastPressure property
        /// </summary>
        public Pressure ForecastPressure
        {
            get
            {
                return this.pressure;
            }
            private set
            {
                this.pressure = value;
            }
        }
        /// <summary>
        /// ForecastWindSpeed property
        /// </summary>
        public WindSpeed ForecastWindSpeed
        {
            get
            {
                return this.windSpeed;
            }
            private set
            {
                this.windSpeed = value;
            }

        }
        /// <summary>
        /// ForecastWindDirection property
        /// </summary>
        public WindDirection ForecastWindDirection
        {
            get
            {
                return this.windDirection;
            }
            private set
            {
                this.windDirection = value;
            }
        }
        /// <summary>
        /// ForecastClouds property
        /// </summary>
        public Clouds ForecastClouds
        {
            get
            {
                return this.clouds;
            }
            private set
            {
                this.clouds = value;
            }
        }

        /// <summary>
        /// ForecastPrecipitation property
        /// </summary>
        public Precipitation ForecastPrecipitation
        {
            get
            {
                return this.precipitation;
            }
            private set
            {
                this.precipitation = value;
            }
        }
        /// <summary>
        /// ForecastWeather property
        /// </summary>
        public Weather ForecastWeather
        {
            get
            {
                return this.weather;
            }
            private set
            {
                this.weather = value;
            }
        }
        /// <summary>
        /// ForecastLastupdate property
        /// </summary>
        public Lastupdate ForecastLastupdate
        {
            get
            {
                return this.lastupdate;
            }
            private set
            {
                this.lastupdate = value;
            }
        }
        #endregion

        #region inner class SunRise
        /// <summary>
        /// inner class
        /// </summary>
        public class SunRise
        {
            private string rise, set;
            /// <summary>
            /// SunRise Constructor
            /// </summary>
            public SunRise()
            {
                this.rise = "00";
                this.set = "00";
            }

            /// <summary>
            /// Rise property
            /// </summary>
            public string Rise
            {
                get
                {
                    return this.rise;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.rise = value;
                    }
                }
            }
            /// <summary>
            /// Set property
            /// </summary>
            public string Set
            {
                get
                {
                    return this.set;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.set = value;
                    }
                }
            }
            /// <summary>
            /// ToString override
            /// </summary>
            /// <returns>string</returns>
            public override string ToString()
            {
                return "Sun rise: [" + Rise + "]\nSun Set:  [" + Set + "]\n";
            }

        }
        #endregion

        #region inner class temperature
       /// <summary>
        /// class Temperature
       /// </summary>
        public class Temperature
        {
            private string unit, value, min, max;
            /// <summary>
            /// Temperature constructor
            /// </summary>
            public Temperature()
            {
                Unit = "00";
                Value = "00";
                Min = "00";
                Max = "00";

            }
            /// <summary>
            /// Unit property
            /// </summary>
            public string Unit
            {
                get
                {
                    return this.unit;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.unit = value;
                    }
                }
            }
            /// <summary>
            /// Value property
            /// </summary>
            public string Value
            {
                get
                {
                    return this.value;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.value = value;
                    }
                }
            }
            /// <summary>
            /// Min property
            /// </summary>
            public string Min
            {
                get
                {
                    return this.min;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.min = value;
                    }
                }
            }
            /// <summary>
            /// Max property
            /// </summary>
            public string Max
            {
                get
                {
                    return this.max;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.max = value;
                    }
                }
            }
            /// <summary>
            /// Tostring override
            /// </summary>
            /// <returns>string</returns>
            public override string ToString()
            {
                return "Temperature:\nUnit:     [" + Unit + "]\nValue:    [" + Value + "]\nMin:      [" + Min + "]\nMax:      [" + Max + "]\n";
            }
        }
        #endregion

        #region inner class humidity
       /// <summary>
        ///  class Humidity
       /// </summary>
        public class Humidity
        {
            private string value, unit;
            /// <summary>
            ///   Humidity constructor
            /// </summary>
            public Humidity()
            {
                Unit = "00";
                Value = "00";

            }
            /// <summary>
            /// Unit property
            /// </summary>
            public string Unit
            {
                get
                {
                    return this.unit;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.unit = value;
                    }
                }
            }
            /// <summary>
            /// Value property
            /// </summary>
            public string Value
            {
                get
                {
                    return this.value;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.value = value;
                    }
                }
            }
            /// <summary>
            /// TosTring override
            /// </summary>
            /// <returns>string</returns>
            public override string ToString()
            {
                return "Humidity:\nValue:    [" + Value + "]\nUnit:     [" + Unit + "]\n";
            }
        }
        #endregion

        #region inner class pressure
       /// <summary>
        /// class Pressure
       /// </summary>
        public class Pressure
        {
            private string unit, value;

            /// <summary>
            /// Pressure constructor
            /// </summary>
            public Pressure()
            {
                Unit = "00";
                Value = "00";

            }
            /// <summary>
            /// Unit property
            /// </summary>
            public string Unit
            {
                get
                {
                    return this.unit;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.unit = value;
                    }
                }
            }
            /// <summary>
            /// Value property
            /// </summary>
            public string Value
            {
                get
                {
                    return this.value;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.value = value;
                    }
                }
            }
            /// <summary>
            /// ToString override
            /// </summary>
            /// <returns>string</returns>
            public override string ToString()
            {
                return "Pressure:\nValue:    [" + Value + "]\n" + "Unit:     [" + Unit + "]\n";
            }
        }
        #endregion

        #region inner class windSpeed
       /// <summary>
        /// class WindSpeed
       /// </summary>
        public class WindSpeed
        {
            private string value, name;
            /// <summary>
            /// WindSpeed constructor
            /// </summary>
            public WindSpeed()
            {
                Value = "00";
                Name = "00";

            }
            /// <summary>
            /// Value property
            /// </summary>
            public string Value
            {
                get
                {
                    return this.value;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.value = value;
                    }
                }
            }
            /// <summary>
            /// Name property
            /// </summary>
            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.name = value;
                    }
                }
            }
            /// <summary>
            /// ToString override
            /// </summary>
            /// <returns>string</returns>
            public override string ToString()
            {
                return "WindSpeed:\nName:     [" + Name + "]\nValue     [" + Value + "]\n";
            }
        }
        #endregion

        #region inner class windDirection
       /// <summary>
        /// class WindDirection
       /// </summary>
        public class WindDirection
        {
            private string deg, code, name;
            /// <summary>
            /// WindDirection constructor
            /// </summary>
            public WindDirection()
            {
                Deg = "00";
                Code = "00";
                Name = "00";
            }
            /// <summary>
            /// Deg property
            /// </summary>
            public string Deg
            {
                get
                {
                    return this.deg;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.deg = value;
                    }
                }
            }
            /// <summary>
            /// Code property
            /// </summary>
            public string Code
            {
                get
                {
                    return this.code;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.code = value;
                    }
                }
            }
            /// <summary>
            /// Name property
            /// </summary>
            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.name = value;
                    }
                }
            }
            /// <summary>
            /// ToString override
            /// </summary>
            /// <returns>string</returns>
            public override string ToString()
            {
                return "WindDirection:\nName      [" + Name + "]\nDeg:      [" + Deg + "]\nCode:     [" + Code + "]\n";
            }
        }

        #endregion

        #region inner class clouds

       /// <summary>
        ///  class Clouds
       /// </summary>
        public class Clouds
        {
            private string value, name;
            /// <summary>
            /// Clouds constructor
            /// </summary>
            public Clouds()
            {
                Name = "00";
                value = "00";

            }
            /// <summary>
            /// Name property
            /// </summary>
            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.name = value;
                    }
                }
            }
            /// <summary>
            /// Value property
            /// </summary>
            public string Value
            {
                get
                {
                    return this.value;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.value = value;
                    }
                }
            }
            /// <summary>
            /// ToString override
            /// </summary>
            /// <returns>string</returns>
            public override string ToString()
            {
                return "Clouds:\nName:     [" + Name + "]" + "\nValue:    [" + Value + "]\n";
            }
        }
        #endregion

        #region inner class Precipitation
       /// <summary>
        /// class Precipitation
       /// </summary>
        public class Precipitation
        {
            private string mode;
            /// <summary>
            /// Precipitation constructor
            /// </summary>
            public Precipitation()
            {

                Mode = "00";

            }
            /// <summary>
            /// Mode property
            /// </summary>
            public string Mode
            {
                get
                {
                    return this.mode;
                }
                set
                {
                    this.mode = value;
                }
            }
            /// <summary>
            /// ToString override
            /// </summary>
            /// <returns>string</returns>
            public override string ToString()
            {
                return "Precipitation:\nMode:     [" + Mode + "]";
            }
        }
        #endregion

        #region inner class Weather
       /// <summary>
        /// class Weather
       /// </summary>
        public class Weather
        {
            private string number, value, icon;
            /// <summary>
            /// Weather constructor
            /// </summary>
            public Weather()
            {
                Number = "00";
                Value = "00";
                Icon = "00";

            }
            /// <summary>
            /// Number property
            /// </summary>
            public string Number
            {
                get
                {
                    return this.number;
                }
                set
                {
                    this.number = value;
                }
            }
            /// <summary>
            /// Value property
            /// </summary>
            public string Value
            {
                get
                {
                    return this.value;
                }
                set
                {
                    this.value = value;
                }
            }
            /// <summary>
            /// Icon property
            /// </summary>
            public string Icon
            {
                get
                {
                    return this.icon;
                }
                set
                {
                    this.icon = value;
                }
            }
            /// <summary>
            /// ToString override
            /// </summary>
            /// <returns>string</returns>
            public override string ToString()
            {
                return "Weather:\nValue:    [" + Value + "]\nNumber    [" + number + "]\nIcon      [" + Icon + "]\n";
            }
        }
        #endregion

        #region inner class Last update
       /// <summary>
        /// class Lastupdate
       /// </summary>
        public class Lastupdate
        {
            private string value;

            /// <summary>
            /// Lastupdate constructor
            /// </summary>
            public Lastupdate()
            {

                Value = "00";

            }
            /// <summary>
            /// Value property
            /// </summary>
            public string Value
            {
                get
                {
                    return this.value;
                }
                set
                {
                    this.value = value;
                }
            }
            /// <summary>
            /// ToString override
            /// </summary>
            /// <returns>string</returns>
            public override string ToString()
            {
                return "Last Update: " + Value;
            }
        }
        #endregion


        #region parsingXmlData
        /// <summary>
        /// Parsing data
        /// </summary>
        /// <param name="xmlData">var that contain the XML string</param>

        private void parsingXmlData(ref string xmlData) // set all data to inner object and update the location of weather data object
        {
            try
            {
                XDocument doc = XDocument.Parse(xmlData);
                var list = from x in doc.Descendants("city")
                           select new
                           {
                               ID = x.Attribute("id").Value,
                               CityName = x.Attribute("name").Value,
                               CountryName = x.Descendants("country").First().Value,
                               sunrise = (from y in doc.Descendants("sun")
                                          select new
                                          {
                                              rise = y.Attribute("rise").Value,
                                              set = y.Attribute("set").Value

                                          }),
                               temperature = (from z in doc.Descendants("temperature")
                                              select new
                                              {
                                                  value = z.Attribute("value").Value,
                                                  min = z.Attribute("min").Value,
                                                  max = z.Attribute("max").Value,
                                                  unit = z.Attribute("unit").Value
                                              }),
                               humidity = (from h in doc.Descendants("humidity")
                                           select new
                                           {
                                               value = h.Attribute("value").Value,
                                               unit = h.Attribute("unit").Value
                                           }),
                               pressure = (from p in doc.Descendants("pressure")
                                           select new
                                           {
                                               value = p.Attribute("value").Value,
                                               unit = p.Attribute("unit").Value,
                                           }),
                               wind = (from w in doc.Descendants("speed")
                                       select new
                                       {
                                           value = w.Attribute("value").Value,
                                           name = w.Attribute("name").Value
                                       }),
                               direction = (from d in doc.Descendants("direction")
                                            select new
                                            {
                                                value = d.Attribute("value").Value,
                                                code = d.Attribute("code").Value,
                                                name = d.Attribute("name").Value
                                            }),
                               clouds = (from c in doc.Descendants("clouds")
                                         select new
                                         {
                                             value = c.Attribute("value").Value,
                                             name = c.Attribute("name").Value
                                         }),
                               precipitation = (from P in doc.Descendants("precipitation")
                                                select new
                                                {
                                                    mode = P.Attribute("mode").Value

                                                }),
                               weather = (from p in doc.Descendants("weather")
                                          select new
                                          {
                                              number = p.Attribute("number").Value,
                                              value = p.Attribute("value").Value,
                                              icon = p.Attribute("icon").Value
                                          }),
                               lastupdate = (from l in doc.Descendants("lastupdate")
                                             select new
                                            {
                                                value = l.Attribute("value").Value
                                            })
                           };


                foreach (var ob in list)
                {
                    ForecastLocation.Id = ob.ID;
                    ForecastLocation.City = ob.CityName;
                    ForecastLocation.State = ob.CountryName;
                    foreach (var sun in ob.sunrise)
                    {
                        ForecastSunRise.Rise = sun.rise;
                        ForecastSunRise.Set = sun.set;
                    }
                    foreach (var temp in ob.temperature)
                    {
                        ForecastTemperature.Value = temp.value;
                        ForecastTemperature.Min = temp.min;
                        ForecastTemperature.Max = temp.max;
                        ForecastTemperature.Unit = temp.unit;
                    }
                    foreach (var hum in ob.humidity)
                    {
                        ForecastHumidity.Value = hum.value;
                        ForecastHumidity.Unit = hum.unit;
                    }
                    foreach (var pre in ob.pressure)
                    {
                        ForecastPressure.Value = pre.value;
                        ForecastPressure.Unit = pre.unit;
                    }
                    foreach (var wind in ob.wind)
                    {
                        ForecastWindSpeed.Value = wind.value;
                        ForecastWindSpeed.Name = wind.name;
                    }
                    foreach (var direct in ob.direction)
                    {
                        ForecastWindDirection.Deg = direct.value;
                        ForecastWindDirection.Code = direct.code;
                        ForecastWindDirection.Name = direct.name;
                    }
                    foreach (var cloud in ob.clouds)
                    {
                        ForecastClouds.Value = cloud.value;
                        ForecastClouds.Name = cloud.name;
                    }
                    foreach (var pre in ob.precipitation)
                    {
                        ForecastPrecipitation.Mode = pre.mode;
                    }
                    foreach (var wh in ob.weather)
                    {
                        ForecastWeather.Number = wh.number;
                        ForecastWeather.Value = wh.value;
                        ForecastWeather.Icon = wh.icon;
                    }
                    foreach (var last in ob.lastupdate)
                    {
                        ForecastLastupdate.Value = last.value;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        #endregion

    }
}
