using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherClassManagement.ViewModels.Weather.CustomerInput
{
    public class Weather
    {
        public List<WeatherItem> weather { get; set; } = new List<WeatherItem>();
    }
}
