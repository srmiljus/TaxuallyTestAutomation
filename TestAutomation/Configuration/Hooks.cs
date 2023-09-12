using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace TaxuallyTestAutomation.Configuration
{
    [Binding]
    class Hooks
    {
        IWebDriver _driver;

        [BeforeScenario]
        public void LaunchBrowsers(IObjectContainer _container)
        {


            switch (ConfigManager.Browser.ToLower())
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
            _container.RegisterInstanceAs(_driver);

            _driver.Manage().Window.Maximize();


        }

        [AfterScenario]
        public void CloseBrowsers()
        {

            _driver.Dispose();
            _driver.Quit();

        }
    }
}
