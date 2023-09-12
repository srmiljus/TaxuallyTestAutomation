using OpenQA.Selenium;
using TaxuallyTestAutomation.Models;

namespace TaxuallyTestAutomation.PageObjects
{
    internal class CreateAccount
    {
        IWebDriver _driver;

        public CreateAccount(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Locators
        By title => By.XPath("//div[@class='modal-header border-bottom']/h3");
        By labelInput(string label) => By.XPath($"//span[@class='field-required' and contains(.,'{label}')]//..//..//input");
        By checkboxPrivacyPolicy => By.XPath("//span[@class='checkmark']");
        #endregion


        #region Action  
        public string GetTitle()
        {
            return _driver.FindElement(title).Text;
        }
        public void EnterDetails(PersonalDetails data)
        {
            _driver.FindElement(labelInput("First name")).SendKeys(data.FirstName);
            _driver.FindElement(labelInput("Last name")).SendKeys(data.LastName);
            _driver.FindElement(labelInput("Country code")).SendKeys(data.CountryCode);
            _driver.FindElement(labelInput("Country code")).SendKeys(Keys.Enter);
            _driver.FindElement(labelInput("Phone number")).SendKeys(data.PhoneNumber);
            _driver.FindElement(labelInput("Your email")).SendKeys(data.YourEmail);
            _driver.FindElement(labelInput("Password")).SendKeys(data.Password);
        }
        public void CheckCheckboxPrivacyPolicy()
        {
            _driver.FindElement(checkboxPrivacyPolicy).Click();
        }
        #endregion
    }
}
