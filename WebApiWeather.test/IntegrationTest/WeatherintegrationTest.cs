using FluentAssertions;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace WebApiWeather.test.IntegrationTest
{
    public class WeatherintegrationTest : integration
    {[Fact]
        public async Task Check_statuscode_is_ok()
        {
            //Arrange
            ////SetupClient

            //Act
            var response = await _client.GetAsync("WeatherForecast");

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
           

        }
        [Fact]
        public async Task Check_GetAll_ListNotEmpty()
        {
            //Arrange
            ////SetupClient

            //Act
            var response = await _client.GetAsync("WeatherForecast");

            //Assert
            (await response.Content.ReadAsStringAsync()).Should().NotBeEmpty();

        }
    }
}
