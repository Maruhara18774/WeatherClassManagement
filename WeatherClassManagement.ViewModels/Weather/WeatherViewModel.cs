using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherClassManagement.ViewModels.Weather
{
    public class WeatherViewModel
    {
        public int CityID { get; set; }
        public string CityName { get; set; } = string.Empty;
        public string WeatherMain { get; set; } = string.Empty;
        public string WeatherDescription { get; set; } = string.Empty;
        public string WeatherIcon { get; set; } = string.Empty;
        public double MainTemp { get; set; }
        public double MainHumidity { get; set; }
    }
}
