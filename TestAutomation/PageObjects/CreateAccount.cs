using Configuration;
using OpenQA.Selenium;
using TaxuallyTestAutomation.Models;

namespace TaxuallyTestAutomation.PageObjects
{
    internal class CreateAccount
    {
        private readonly BrowserManager _browserManager;
        private readonly IWebDriver _driver;

        public CreateAccount(BrowserManager browserManager)
        {
            _browserManager = browserManager;
            _driver = _browserManager.GetDriver();
        }

        #region Locators
        IWebElement title => _driver.FindElement(By.XPath("//div[@class='modal-header border-bottom']/h3"));
        IWebElement labelInput(string label) => _driver.FindElement(By.XPath($"//span[@class='field-required' and contains(.,'{label}')]//..//..//input"));
        IWebElement checkboxPrivacyPolicy => _driver.FindElement(By.XPath("//span[@class='checkmark']"));
        #endregion


        #region Action  
        public string GetTitle()
        {
            return title.Text;
        }
        public void EnterDetails(PersonalDetails data)
        {
            labelInput("First name").SendKeys(data.FirstName);
            labelInput("Last name").SendKeys(data.LastName);
            labelInput("Country code").SendKeys(data.CountryCode);
            labelInput("Country code").SendKeys(Keys.Enter);
            labelInput("Phone number").SendKeys(data.PhoneNumber);
            labelInput("Your email").SendKeys(data.YourEmail);
            labelInput("Password").SendKeys(data.Password);
        }
        public void CheckCheckboxPrivacyPolicy()
        {
            checkboxPrivacyPolicy.Click();
        }
        #endregion
    }
}
