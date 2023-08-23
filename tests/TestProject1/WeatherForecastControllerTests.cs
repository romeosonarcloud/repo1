using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class WeatherForecastControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public WeatherForecastControllerTests(WebApplicationFactory<Program> application)
        {
            _client = application.CreateClient();
            var testing = "test string";
        }


        [Fact]
        public async Task GET_retrieves_weather_forecastAsync()
        {
            var response = await _client.GetAsync("/weatherforecast");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
