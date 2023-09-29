namespace TaxuallyTestAutomation.StepDefinitions;

[Binding]
internal class SignUpSteps
{

    SignUpPage _signUpPage;

    public SignUpSteps(IObjectContainer objectContainer)
    {
        _signUpPage = objectContainer.Resolve<SignUpPage>();
    }

    [When(@"verify user can see '([^']*)' in URL of the page")]
    [Then(@"verify user can see '([^']*)' in URL of the page")]
    public void ThenVerifyUserCanSeeInURL(string segment)
    {
        Assert.IsTrue(_signUpPage.GetUrl().Contains(segment));
    }

    [When(@"user choose '([^']*)' from '([^']*)' dropdown")]
    [Then(@"user choose '([^']*)' from '([^']*)' dropdown")]
    public void WhenUserChooseFromDropdown(string value, string labelName)
    {
        _signUpPage.ChooseValueFromDropDown(value, labelName);
    }

    [When(@"user select first option from countries")]
    [Then(@"user select first option from countries")]
    public void WhenUserSelectFirstOptionFromCountries()
    {
        _signUpPage.SelectFirstCountry();
    }

    [When(@"user select '([^']*)' from countries")]
    [Then(@"user select '([^']*)' from countries")]
    public void WhenUserSelectFromCountries(string country)
    {
        _signUpPage.SelectSpecificCountry(country);
    }

    [When(@"user select all unselected countries")]
    [Then(@"user select all unselected countries")]
    public void ThenUserSelectAllUnselectedCountries()
    {
        _signUpPage.SelectUnselectedCountries();
    }

    [When(@"user click on all Help me get a VAT number buttons")]
    [Then(@"user click on all Help me get a VAT number buttons")]
    public void WhenUserClickOnAllHelpMeGetAVATNumberButtons()
    {
        _signUpPage.ClickHelpMeGetAVat();
    }

    [When(@"user proceed with Next step")]
    [Then(@"user proceed with Next step")]
    public void WhenUserProceedWithNextStep()
    {
        _signUpPage.ProceedNextStep();
    }
    [When(@"user unselect (.*) random counties")]
    [Then(@"user unselect (.*) random counties")]
    public void ThenUserSelectRandomCounties(int number)
    {
        _signUpPage.SelectRandomCountries(number);
    }

}
