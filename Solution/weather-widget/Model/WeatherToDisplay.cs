﻿using System;
using System.Collections.Generic;
using System.Text;

namespace weather_widget.Model
{
    class WeatherToDisplay
    {
        #region properties
        /// <summary>
        /// Description of current weather
        /// </summary>
        public string WeatherDescription { get; set; }

        /// <summary>
        /// Weathericon --> Weathericon e.g. 04d.png
        /// </summary>
        public string WeatherIcon { get; set; }

        /// <summary>
        /// Max. Temperature in Celsius of a day
        /// </summary>
        public string MaxTemperature { get; set; }


        /// <summary>
        /// Min. Temperature in Celsius of a day
        /// </summary>
        public string MinTemperature { get; set; }


        /// <summary>
        /// Avg. Temperature in Celsius of a day
        /// </summary>
        public string AvgTemperature { get; set; }

        /// <summary>
        /// Max wind speed as string in m/s
        /// </summary>
        public string WindSpeed { get; set; }

        /// <summary>
        /// Wind direction as string (NN, ...), this value depends on max windspeed of a day
        /// </summary>
        public string Winddirection { get; set; }

        /// <summary>
        /// Humidity in %
        /// </summary>
        public string Humidity { get; set; }
        #endregion properties

        public WeatherToDisplay(string weatherdesc, string weathericon, string maxtemperature, string mintemperature,
                string avgtemperature, string winddirection, string windspeed, string humidity)
        {
            WeatherDescription = weatherdesc;
            WeatherIcon = weathericon;
            MaxTemperature = maxtemperature;
            MinTemperature = mintemperature;
            AvgTemperature = avgtemperature;
            Winddirection = winddirection;
            WindSpeed = windspeed;
            Humidity = humidity;
        }

    }
}
