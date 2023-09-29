using Configuration;

namespace TaxuallyTestAutomation.Configuration;

[Binding]
class Hooks
{
    private readonly BrowserManager _browserManager;

    public Hooks(BrowserManager browserManager)
    {
        _browserManager = browserManager;
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        _browserManager.LaunchBrowser(ConfigManager.Browser);
    }

    [AfterScenario]
    public void AfterScenario()
    {
        _browserManager.CloseBrowser();
    }
}
