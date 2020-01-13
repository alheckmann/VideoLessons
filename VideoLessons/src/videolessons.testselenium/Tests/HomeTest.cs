using videolessons.testselenium.Screens;
using videolessons.testselenium.Utils;
using Xunit;

namespace videolessons.testselenium.Tests
{
    public class HomeTest : BaseTest
    {
        [Theory]
        [InlineData(Browser.Chrome)]

        public void DeveCarregarTelaHomeComSucesso(Browser browser) {

            HomeScreen homeScreen = new HomeScreen(_configuration, browser);
            string response;

            try {
                
                homeScreen.LoadScreen(_configuration.GetSection("Selenium:Urls:Home").Value);
                response = homeScreen.GetServices();
                
            } catch (System.Exception ex) {
                throw ex;
            } finally {
                homeScreen.CloseScreen();    
            }

            Assert.True(!string.IsNullOrEmpty(response));
            
        }
    }
}