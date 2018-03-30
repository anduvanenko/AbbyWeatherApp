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
            
            var url = string.Format("http://api.wunderground.com/api/{0}/conditions/q/{1}/{2}.json", apiID, state, city);
            string urlDaily = string.Format("http://api.wunderground.com/api/{0}/forecast/q/{1}/{2}.json", apiID, state, city);
            string urlHourly = string.Format("http://api.wunderground.com/api/{0}/hourly/q/{1}/{2}.json", apiID, state, city);
            string urlMultiDay = string.Format("http://api.wunderground.com/api/{0}/forecast10day/q/{1}/{2}.json", apiID, state, city);
            
            using (WebClient client = new WebClient())
            {
                var json = client.DownloadString(url);
                var jsonDaily = client.DownloadString(urlDaily);
                var jsonMultiDay = client.DownloadString(urlMultiDay);
                var jsonHourly = client.DownloadString(urlHourly);
                
                JSONWeatherClass.RootObject weatherInfo = JsonConvert.DeserializeObject<JSONWeatherClass.RootObject>(json);
                DailyWeatherForecast.RootObject dailyWeatherInfo = JsonConvert.DeserializeObject<DailyWeatherForecast.RootObject>(jsonDaily);
                HourlyForecastWeather.RootObject hourlyWeatherInfo = JsonConvert.DeserializeObject<HourlyForecastWeather.RootObject>(jsonHourly);
                MultiDayForecast.RootObject weeklyWeatherInfo = JsonConvert.DeserializeObject<MultiDayForecast.RootObject>(jsonMultiDay);
                 
                conditions.Text = "Weather Conditions: " + weatherInfo.current_observation.weather;

                DailyWeatherCondition.Text = "Daily weather condition: " + dailyWeatherInfo.forecast.simpleforecast.forecastday[0].conditions;
                DailyTemp.Text = "Daily High and Low temp: " + "(1)High: " + dailyWeatherInfo.forecast.simpleforecast.forecastday[0].high.fahrenheit + "  (2)Low: " + dailyWeatherInfo.forecast.simpleforecast.forecastday[0].low.fahrenheit;
                CurrentTemp.Text = "Current Temperature: " + hourlyWeatherInfo.hourly_forecast[0].temp.english;

                Hourly.Text = "";
                for (int i = 0; i < 12; i++)
                {
                    var hour = hourlyWeatherInfo.hourly_forecast[i].FCTTIME.hour;
                    var temp = hourlyWeatherInfo.hourly_forecast[i].temp.english;
                    var condition = hourlyWeatherInfo.hourly_forecast[i].condition;
                    Hourly.Text += hour + ":" + temp + ":" + condition + ", <br />";
                }

                MultiDay.Text = "";
                for (int f = 0; f < 14; f++)
                {
                    var day = weeklyWeatherInfo.forecast.txt_forecast.forecastday[f].title;
                    var weatherCondition = weeklyWeatherInfo.forecast.txt_forecast.forecastday[f].fcttext;
                    MultiDay.Text += day + ":" + weatherCondition + ", <br /><br />";
                }

                DailyTemperatures.Text = "";
                for (int t = 0; t < 8; t++)
                {
                    var highTemp = weeklyWeatherInfo.forecast.simpleforecast.forecastday[t].high.fahrenheit;
                    var lowTemp = weeklyWeatherInfo.forecast.simpleforecast.forecastday[t].low.fahrenheit;
                    DailyTemperatures.Text += highTemp + ":" + lowTemp + ", <br />";
                }
            }
        }
    }
}