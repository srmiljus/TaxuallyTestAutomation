using TaxuallyTestAutomation.Configuration;


namespace TaxuallyTestAutomation.PageObjects;

internal class LoginPage
{
    private readonly IWebDriver _driver;

    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
    }

    #region Locators
    IWebElement allowAllCookies(string buttonName) => _driver.FindElement(By.XPath($"//div//button[contains(.,'{buttonName}')]"));
    IWebElement getStartedOrLogin(string buttonName) => _driver.FindElement(By.XPath($"(//div//a[contains(.,'{buttonName}')])[1]"));
    #endregion


    #region Actions
    public void NavigateToLoginPage()
    {
        _driver.Navigate().GoToUrl(ConfigManager.SiteUrl);
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

    }

    public void ClickOnButtonOnManageCookies(string buttonName)
    {
        allowAllCookies(buttonName).Click();

    }
    public void ChooseGetStartedOrLogin(string buttonName)
    {
        getStartedOrLogin(buttonName).Click();
    }
    #endregion
}
