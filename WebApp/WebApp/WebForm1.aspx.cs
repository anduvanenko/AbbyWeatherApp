using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Net;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string apiID = "329b96046e478a01";
            string state = TextBox2.Text;
            string city = TextBox1.Text;
            
            string url = string.Format("http://api.wunderground.com/api/{0}/conditions/q/{1}/{2}.json", apiID, state, city);
            string urlMultiDay = string.Format("http://api.wunderground.com/api/{0}/forecast10day/q/{1}/{2}.json", apiID, state, city);
            string urlHourly = string.Format("http://api.wunderground.com/api/{0}/hourly/q/{1}/{2}.json", apiID, state, city);
            string urlDaily = string.Format("http://api.wunderground.com/api/{0}/forecast/q/{1}/{2}.json", apiID, state, city);

            using (WebClient client = new WebClient())
            {
                var json = client.DownloadString(url);
                var jsonMultiDay = client.DownloadString(urlMultiDay);
                var jsonHourly = client.DownloadString(urlHourly);
                var jsonDaily = client.DownloadString(urlDaily);
                JSONWeatherClass.RootObject weatherInfo = JsonConvert.DeserializeObject<JSONWeatherClass.RootObject>(json);
                MultiDayForecast.RootObject weeklyWeatherInfo = JsonConvert.DeserializeObject<MultiDayForecast.RootObject>(jsonMultiDay);
                HourlyForecastWeather.RootObject hourlyWeatherInfo = JsonConvert.DeserializeObject<HourlyForecastWeather.RootObject>(jsonHourly);
                DailyWeatherForecast.RootObject dailyWeatherInfo = JsonConvert.DeserializeObject<DailyWeatherForecast.RootObject>(jsonDaily);

                conditions.Text = "weather: " + weatherInfo.current_observation.weather;
                Daily.Text = "Daily: " + dailyWeatherInfo.forecast.simpleforecast.forecastday[0].conditions;
                Hourly.Text = "Hourly: " + "Hour: " + hourlyWeatherInfo.hourly_forecast[0].FCTTIME.hour + " Temp: " + hourlyWeatherInfo.hourly_forecast[0].temp.english + " Condition: "
                    + hourlyWeatherInfo.hourly_forecast[0].condition;
                MultiDay.Text = "Weather for the week: " + weeklyWeatherInfo.forecast.txt_forecast.forecastday[0].fcttext;

            }
        }
    }
}