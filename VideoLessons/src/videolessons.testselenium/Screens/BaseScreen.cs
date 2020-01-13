using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using videolessons.testselenium.Utils;

namespace videolessons.testselenium.Screens
{
    public class BaseScreen
    {

        protected readonly IConfiguration _configuration;

        protected readonly Browser _browser;

        protected IWebDriver _webdriver;

        public BaseScreen( IConfiguration configuration, Browser browser) {
            _configuration = configuration;
            _browser = browser;

           _webdriver = WebDriverFactory.CreateWebDriver(browser, configuration.GetSection("Selenium:Drivers:Path").Value, false);
        }

        public void LoadScreen(string url){
            _webdriver.LoadPage(TimeSpan.FromSeconds(15), url);
            _webdriver.Manage().Window.Maximize();
        }

        public void CloseScreen(){
            _webdriver.Quit();
            _webdriver = null;
        }

        public void WaitByHtml(TimeSpan secondsToWait, By by) {
            WebDriverWait wait = new WebDriverWait(_webdriver, secondsToWait);
            wait.Until (x => !string.IsNullOrEmpty (x.FindElement (by).GetAttribute ("innerHTML")));
        }
        
    }
}