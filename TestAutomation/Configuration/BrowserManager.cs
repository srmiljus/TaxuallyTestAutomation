using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Configuration;

public class BrowserManager
{
    private IWebDriver _driver;
    private readonly IObjectContainer _container;

    public BrowserManager(IObjectContainer container)
    {
        _container = container;
    }
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
        _container.RegisterInstanceAs(_driver);
        _driver.Manage().Window.Maximize();
    }

    public void CloseBrowser()
    {
        _driver.Dispose();
        _driver?.Quit();

    }
}
