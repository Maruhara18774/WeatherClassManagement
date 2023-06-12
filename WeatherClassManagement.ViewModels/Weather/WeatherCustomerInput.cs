using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherClassManagement.ViewModels.Weather
{
    public class WeatherCustomerInput
    {
        public int cnt { get; set; }
        public List<WeatherModel> list { get; set; } = new List<WeatherModel>();
    }
}
