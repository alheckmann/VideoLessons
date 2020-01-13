using System.IO;
using Microsoft.Extensions.Configuration;

namespace videolessons.testselenium.Tests
{
    public class BaseTest
    {
        protected IConfiguration _configuration;

        public BaseTest () {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            _configuration = builder.Build();
        }
    }
}