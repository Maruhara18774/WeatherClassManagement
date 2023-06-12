using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherClassManagement.ViewModels.Weather.CustomerInput;

namespace WeatherClassManagement.ViewModels.Weather
{
    public class WeatherModel
    {
        public int id { get; set; }
        public int dt { get; set; }
        public string name { get; set; } = string.Empty;
        public Coord coord { get; set; } = new Coord();
        public WeatherSys sys { get; set; } = new WeatherSys();
        public List<WeatherItem> weather { get; set; } = new List<WeatherItem>();
        public WeatherMain main { get; set; } = new WeatherMain();
        public int visibility { get; set; }
        public WeatherWind wind { get; set; } = new WeatherWind();
        public WeatherCloud clouds { get; set; } = new WeatherCloud();
    }
}
