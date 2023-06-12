using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherClassManagement.ViewModels.Weather
{
    public class CustomerResponse
    {
        public List<WeatherViewModel> data { get; set; } = new List<WeatherViewModel>();
        public int statusCode { get; set; } = 200;
        public string Message { get; set; } = "Current weather information of cities";
    }
}
