using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using videolessons.testselenium.Utils;

namespace videolessons.testselenium.Screens
{
    public class HomeScreen : BaseScreen
    {
        public HomeScreen(IConfiguration configuration, Browser browser) : base(configuration, browser) { } 

        public string GetServices() {
            WaitByHtml(TimeSpan.FromSeconds(10), By.Id("serviços"));
            string response = _webdriver.GetHtml(By.Id("serviços"));
            return response;
        }
        
    }
}