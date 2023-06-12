using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherClassManagement.ViewModels.Weather.CustomerInput
{
    public class WeatherSys
    {
        public string country { get; set; } = string.Empty;
        public int timezone { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }
}
