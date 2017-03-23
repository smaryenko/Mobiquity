using System;
using Mobiquity.Helpers;
using Mobiquity.PageObjects;
using TechTalk.SpecFlow;

namespace Mobiquity.StepDefinitions
{
    [Binding]
    public class LoginFeatureSteps : TestBase
    {
        private LoginPage LoginPage;

        [Given(@"Login page is loaded")]
        public void GivenLoginPageIsLoaded()
        {
            LoginPage = new LoginPage(driver);
            LoginPage.NavigateToPage();
        }
        
        [When(@"'(.*)' and '(.*)' are entered and login button pressed")]
        public void WhenValidAndAreEnteredAndLoginButtonPressed(string email, string password)
        {
            LoginPage.Login(email, password);
        }
        
        [Then(@"User is successfully logged in")]
        public void ThenUserIsSuccessfullyLoggedIn()
        {
            LoginPage.WaitForSuccess();
        }

        [Then(@"User sees error message")]
        public void ThenUserSeesErrorMessage()
        {
            LoginPage.WaitForError();
        }

        [Then(@"User can logout")]
        public void ThenUserCanLogout()
        {
            LoginPage.Logout();
        }


        [AfterScenario]
        public void AfterWebTest()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                ScreenshotHelper.TakeScreenshot(driver);
            }
        }
    }
}
