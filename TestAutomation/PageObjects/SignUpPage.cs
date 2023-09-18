using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TaxuallyTestAutomation.PageObjects
{
    internal class SignUpPage
    {
        IWebDriver _driver;

        public SignUpPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Locators
        IWebElement inputField(string labelName) => _driver.FindElement(By.XPath($"//label[contains(.,'{labelName}')]//..//input"));
        IList<IWebElement> selectCountries => _driver.FindElements(By.XPath("(//div[@class='container-fluid row'])[1]//button"));
        IWebElement selectSpecificCountry(string countryName) => _driver.FindElement(By.XPath($"(//div[@class='container-fluid row'])[1]//button[contains(.,'{countryName}')]"));
        IList<IWebElement> btnsHelpMeGetAVat => _driver.FindElements(By.XPath("//button[@class='btn btn-primary add-vatreg-to-cart']"));
        IWebElement btnNextStep => _driver.FindElement(By.XPath("//button[@class='btn btn-primary d-inline-block']"));
        #endregion


        #region Action  
        public string GetUrl()
        {
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());

            return _driver.Url;
        }
        public void ChooseValueFromDropDown(string value, string labelName)
        {
            inputField(labelName).Click();
            inputField(labelName).SendKeys(value);
            inputField(labelName).SendKeys(Keys.Enter);
        }
        public void SelectFirstCountry()
        {

            selectCountries.FirstOrDefault().Click();

        }
        public void SelectSpecificCountry(string countryName)
        {
            selectSpecificCountry(countryName).Click();
        }

        public void SelectUnselectedCountries()
        {
            foreach (var item in selectCountries.Where(item => !item.GetAttribute("class").Contains("active")))
            {
                item.Click();
            }
        }
        public void ClickHelpMeGetAVat()
        {
            foreach (var button in btnsHelpMeGetAVat)
            {
                button.Click();
            }
        }
        public void ProceedNextStep()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            wait.Until(ExpectedConditions.ElementToBeClickable(btnNextStep));

            btnNextStep.Click();
        }
        public void SelectRandomCountries(int numberOfCountries)
        {

            var randomCountries = selectCountries.OrderBy(x => Guid.NewGuid()).Take(numberOfCountries);

            foreach (var country in randomCountries)
            {
                country.Click();
            }

        }
        #endregion
    }
}
