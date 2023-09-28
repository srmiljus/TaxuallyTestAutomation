using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Configuration
{
    public class BrowserManager
    {
        private IWebDriver _driver;

        public void LaunchBrowser(string browser)
        {
            switch (browser.ToLower())
            {
                case "chrome":
                    _driver = new ChromeDriver();
                    break;
                case "firefox":
                    _driver = new FirefoxDriver();
                    break;
                default:
                    break;
            }

            _driver.Manage().Window.Maximize();
        }

        public IWebDriver GetDriver()
        {
            return _driver;
        }

        public void CloseBrowser()
        {
            _driver?.Quit();
            _driver = null;
        }
    }
}
