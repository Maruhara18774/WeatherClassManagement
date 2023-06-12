using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherClassManagement.BAL.Weather;
using WeatherClassManagement.ViewModels.Weather;

namespace WeatherClassManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        public WeatherController(IWeatherService weatherService) { 
            _weatherService = weatherService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _weatherService.getListAsync();
            var response = new CustomerResponse();
            response.data = result;
            return Ok(response);
        }
    }
}
