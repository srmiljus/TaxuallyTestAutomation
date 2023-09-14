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
        By inputField(string labelName) => By.XPath($"//label[contains(.,'{labelName}')]//..//input");
        By selectCountries => By.XPath("(//div[@class='container-fluid row'])[1]//button");
        By selectSpecificCountry(string countryName) => By.XPath($"(//div[@class='container-fluid row'])[1]//button[contains(.,'{countryName}')]");
        By helpMeGetAVatButtons => By.XPath("//button[@class='btn btn-primary add-vatreg-to-cart']");
        By nextStepButton => By.XPath("//button[@class='btn btn-primary d-inline-block']");
        #endregion


        #region Action  
        public string GetUrl()
        {
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());

            return _driver.Url;
        }
        public void ChooseValueFromDropDown(string value, string labelName)
        {
            _driver.FindElement(inputField(labelName)).Click();
            _driver.FindElement(inputField(labelName)).SendKeys(value);
            new Actions(_driver).SendKeys(Keys.Enter).Perform();
        }
        public void SelectFirstCountry()
        {
            var elements = _driver.FindElements(selectCountries);
            elements.FirstOrDefault().Click();

        }
        public void SelectSpecificCountry(string countryName)
        {
            _driver.FindElement(selectSpecificCountry(countryName)).Click();
        }

        public void SelectUnselectedCountries()
        {
            var elements = _driver.FindElements(selectCountries);
            foreach (var item in elements)
            {
                string classAttributeValue = item.GetAttribute("class");

                if (!classAttributeValue.Contains("active"))
                {
                    item.Click();
                }
            }
        }
        public void ClickHelpMeGetAVat()
        {
            var vatButtons = _driver.FindElements(helpMeGetAVatButtons);
            foreach (var button in vatButtons)
            {
                button.Click();
            }
        }
        public void ProceedNextStep()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            IWebElement nextButtonElement = wait.Until(ExpectedConditions.ElementToBeClickable(nextStepButton));

            nextButtonElement.Click();
        }
        public void SelectRandomCountries(int numberOfCountries)
        {
            var elements = _driver.FindElements(selectCountries);

            var randomCountries = elements.OrderBy(x => Guid.NewGuid()).Take(numberOfCountries);

            foreach (var country in randomCountries)
            {
                country.Click();
            }

        }
        #endregion
    }
}
