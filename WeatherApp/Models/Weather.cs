using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    public class Weather
    {
        public Object getWeatherForcast(string city)
        {
            string appid = "430586656e3071a2dbe0c0883ff5dbdb";
            string url = "http://api.openweathermap.org/data/2.5/weather?q="+city+"&APPID=" + appid + "&units=metric"; 
           
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            
            return jsonContent;
        }

    }
}