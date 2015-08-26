using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataService
{
    /// <summary>
    /// This class send to data service as object , the fields will send to the data service for current location data
    /// </summary>
    public class Location
    {
        /// <summary>
        /// city and state var for specific location
        /// </summary>
        private string state;
        private string city;
        private string id;


        /// <summary>
        /// Constructor that gets the city and state 
        /// </summary>
        /// <param name="stateVal">parameter for state</param>
        /// <param name="cityVal">parameter for city</param>
        public Location(string stateVal, string cityVal)
        {
            State = stateVal;
            City = cityVal;
            Id = "0000";//I prefer to use Telaviv as default if string empty


        }
        /// <summary>
        /// This constructor is "default" constructor init in case of empty location declaration 
        /// </summary>
        public Location()
        {
            State = "IL";//I prefer to use Israel as default if string empty
            City = "Telaviv";//I prefer to use Telaviv as default if string empty
            Id = "0000";//I prefer to use Telaviv as default if string empty

        }




        /// <summary>
        /// Location properties
        /// </summary>
        #region Location properties
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.state = value;
                }
            }
        }
        /// <summary>
        /// City properties
        /// </summary>
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.city = value;
                }
            }
        }
        /// <summary>
        /// /// Id properties
        /// </summary>
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.id = value;
                }

            }
        }
        #endregion
        /// <summary>
        /// ToString method
        /// </summary>
        /// <returns>String with vars values</returns>
        public override string ToString()
        {
            return "State:    [" + State + "]\n" + "City:     [" + City + "]\n" + "Id        [" + Id + "]\n";
        }
    }
}
