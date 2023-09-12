using OpenQA.Selenium;
using TaxuallyTestAutomation.Configuration;


namespace TaxuallyTestAutomation.PageObjects
{
    internal class LoginPage
    {
        IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Locators
        By allowAllCookies(string buttonName) => By.XPath($"//div//button[contains(.,'{buttonName}')]");
        By getStartedOrLogin(string buttonName) => By.XPath($"(//div//a[contains(.,'{buttonName}')])[1]");
        #endregion


        #region Actions
        public void NavigateToLoginPage()
        {
            _driver.Navigate().GoToUrl(ConfigManager.SiteUrl);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        public void ClickOnButtonOnManageCookies(string buttonName)
        {
            _driver.FindElement(allowAllCookies(buttonName)).Click();

        }
        public void ChooseGetStartedOrLogin(string buttonName)
        {
            _driver.FindElement(getStartedOrLogin(buttonName)).Click();
        }
        #endregion
    }
}
