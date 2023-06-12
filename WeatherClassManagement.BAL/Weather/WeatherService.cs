using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherClassManagement.ViewModels.Weather;

namespace WeatherClassManagement.BAL.Weather
{
    public class WeatherService : IWeatherService
    {
        public async Task<List<WeatherViewModel>> getListAsync()
        {
            var list = new List<WeatherViewModel>();
            var customerInput = new WeatherCustomerInput();


            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://api.openweathermap.org/data/2.5/group?id=1580578,1581129,1581297,1581188,1587923&units=metric&appid=91b7466cc755db1a94caf6d86a9c788a"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    customerInput = JsonConvert.DeserializeObject<WeatherCustomerInput>(apiResponse);
                }
            }

            foreach (var item in customerInput!.list) {
                var obj = new WeatherViewModel();
                obj.CityID = item.id;
                obj.CityName = item.name;
                if(item.weather.FirstOrDefault() != null)
                {
                    var weather = item.weather.FirstOrDefault();
                    obj.WeatherMain = weather!.main;
                    obj.WeatherDescription = weather!.description;
                    obj.WeatherIcon = "http://openweathermap.org/img/wn/" + weather.icon + "@2x.png";
                }
                obj.MainTemp = item.main.temp;
                obj.MainHumidity = item.main.humidity;
                list.Add(obj);
            }

            return list;
        }
    }
}
