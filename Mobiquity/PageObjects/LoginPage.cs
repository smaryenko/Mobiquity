using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace Mobiquity.PageObjects
{
    public class LoginPage : BasePage
    {
        public const string PageUrl = "http://systemaker.com/angulardemo/#!/login";
        public By InputEmail => NgBy.Model("user.email");
        public By InputPassword => NgBy.Model("user.password");
        public By ButtonLogin => By.ClassName("btn");
        public By MessageContainer => By.ClassName("ng-scope");
        public By ButtonLogout => By.XPath("//a[contains(.,'Logout')]");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateToPage()
        {
            Thread.Sleep(1000);
            Driver.Url = PageUrl;
            ngDriver.WaitForAngular();
        }

        public void Login(string email, string password)
        {
            waitDriver.Until(ExpectedConditions.ElementExists(InputEmail));
            ngDriver.FindElement(InputEmail).SendKeys(email);

            waitDriver.Until(ExpectedConditions.ElementExists(InputPassword));
            ngDriver.FindElement(InputPassword).SendKeys(password);

            var button = ngDriver.FindElements(ButtonLogin)[2];
            button.Click();
        }

        public void Logout()
        {
            waitDriver.Until(ExpectedConditions.ElementExists(ButtonLogout));
            var button = Driver.FindElements(ButtonLogout)[0];
            button.Click();
        }

        public void WaitForSuccess()
        {
            var element = Driver.FindElement(MessageContainer);
            waitDriver.Until(ExpectedConditions.TextToBePresentInElement(element, "successively logged in"));
        }

        public void WaitForError()
        {
            var element = Driver.FindElement(MessageContainer);
            waitDriver.Until(ExpectedConditions.TextToBePresentInElement(element, "invalid credentials"));
        }
    }
}
