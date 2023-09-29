namespace TaxuallyTestAutomation.StepDefinitions;

[Binding]
internal class LoginSteps
{
    LoginPage _loginPage;

    public LoginSteps(IObjectContainer objectContainer)
    {
        _loginPage = objectContainer.Resolve<LoginPage>();
    }

    [Given(@"user navigate to login page")]
    [When(@"user navigate to login page")]
    [Then(@"user navigate to login page")]
    public void UserNavigateToLoginPage()
    {
        _loginPage.NavigateToLoginPage();
    }

    [When(@"user click on '([^']*)' button on Manage cookies")]
    [Then(@"user click on '([^']*)' button on Manage cookies")]
    public void WhenUserClickOnButtonOnManageCookies(string buttonName)
    {
        _loginPage.ClickOnButtonOnManageCookies(buttonName);
    }

    [When(@"user click on '([^']*)' button")]
    [Then(@"user click on '([^']*)' button")]
    public void WhenUserClickOnButton(string buttonName)
    {
        _loginPage.ChooseGetStartedOrLogin(buttonName);
    }
}
