using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherClassManagement.ViewModels.Weather.CustomerInput
{
    public class WeatherMain
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double tempMin { get; set; }
        public double tempMax { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
    }
}
