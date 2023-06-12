using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherClassManagement.ViewModels.Weather;

namespace WeatherClassManagement.BAL.Weather
{
    public interface IWeatherService
    {
        Task<List<WeatherViewModel>> getListAsync();
    }
}
