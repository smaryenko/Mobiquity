using Mobiquity.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mobiquity.StepDefinitions
{
    [Binding]
    public class TestBase
    {
        public static IWebDriver driver;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            driver = new ChromeDriver();
           
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
