using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherClassManagement.BAL.Weather;
using WeatherClassManagement.ViewModels.Weather;

namespace WeatherClassManagement.UnitTest.Weather
{
    public class WeatherServiceTest
    {
        [Fact]
        public async Task GetListAsync_HaveData()
        {

            var weatherService = new WeatherService();

            var result = await weatherService.getListAsync();

            Assert.NotEmpty(result);
        }
        [Fact]
        public async Task GetListAsync_CorrectData()
        {

            var weatherService = new WeatherService();

            var result = await weatherService.getListAsync();

            var sample1 = result.FirstOrDefault();
            Assert.NotEqual(0, sample1!.CityID);
            Assert.NotEmpty(sample1!.CityName);
            Assert.NotEmpty(sample1!.WeatherMain);
            Assert.NotEmpty(sample1!.WeatherDescription);
            Assert.NotEmpty(sample1!.WeatherIcon);
            Assert.NotEqual(0, sample1!.MainTemp);
            Assert.NotEqual(0, sample1!.MainHumidity);
        }
    }
}
