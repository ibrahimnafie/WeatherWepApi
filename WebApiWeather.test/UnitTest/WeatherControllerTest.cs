using System;
using WebApiWeather.Model;
using Xunit;

namespace WebApiWeather.test.UnitTest
{
    public class WeatherControllerTest
    {

        [Fact]
        public void Check_Type_Of_Response()
        {
            //Arrange
            int DayOrder = 1;

            //Act
            var response = WeatherBusiness.GetDayWeather(DayOrder);

            //Assert

            Assert.IsType<WeatherForecast>(response);
        }



    }
}
