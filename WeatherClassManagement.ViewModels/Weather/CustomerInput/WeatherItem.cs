using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherClassManagement.ViewModels.Weather.CustomerInput
{
    public class WeatherItem
    {
        public int id { get; set; }
        public string main { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string icon { get; set; } = string.Empty;
    }
}
