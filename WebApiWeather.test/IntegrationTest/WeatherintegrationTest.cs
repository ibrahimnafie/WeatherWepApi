using FluentAssertions;
using Newtonsoft.Json;
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
            var response = await _client.GetAsync("WeatherForecast/alldays");

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
           

        }
        [Fact]
        public async Task Check_GetAll_ListNotEmpty()
        {
            //Arrange
            ////SetupClient

            //Act
            var response = await _client.GetAsync("WeatherForecast/alldays");

            //Assert
            (await response.Content.ReadAsStringAsync()).Should().NotBeEmpty();

        }

        [Fact]
        public async Task Check_GetAll_MoreThan_One()
        {
            //Arrange
            ////SetupClient

            //Act
            var response = await _client.GetAsync("WeatherForecast/alldays");

            //Assert
            var strContent = await response.Content.ReadAsStringAsync();
            var resList = JsonConvert.DeserializeObject<List<WeatherForecast>>(strContent);
            resList.Count.Should().Be(5);

        }
    }
}
