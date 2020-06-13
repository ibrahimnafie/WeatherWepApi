using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace WebApiWeather.test.IntegrationTest
{
    public class integration
    {
        public readonly HttpClient _client;

        public integration()
        {
            var webFactory = new WebApplicationFactory<Startup>();
            _client = webFactory.CreateClient();
        }
    }
}
