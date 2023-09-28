using BoDi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxuallyTestAutomation.Models;
using TaxuallyTestAutomation.PageObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TaxuallyTestAutomation.StepDefinitions
{
    [Binding]
    internal class CreaetAccountSteps
    {

        CreateAccount _createAccount;

        public CreaetAccountSteps(IObjectContainer objectContainer)
        {
            _createAccount = objectContainer.Resolve<CreateAccount>();

        }

        [When(@"user verify '([^']*)' title")]
        [Then(@"user verify '([^']*)' title")]
        public void WhenUserVerifyTitle(string title)
        {
            Assert.AreEqual(title, _createAccount.GetTitle(), $"Page title is not as expected: {title}");
        }

        [When(@"user enter details to create account")]
        [Then(@"user enter details to create account")]
        public void WhenUserEnterDetailsToCreateAccount(Table table)
        {
            var data = table.CreateInstance<PersonalDetails>();
            _createAccount.EnterDetails(data);
        }

        [When(@"user click on checkmark to Accept Privacy Policy")]
        [Then(@"user click on checkmark to Accept Privacy Policy")]
        public void ThenUserClickOnCheckmarkToAcceptPrivacyPolicy()
        {
            _createAccount.CheckCheckboxPrivacyPolicy();
        }
    }
}
