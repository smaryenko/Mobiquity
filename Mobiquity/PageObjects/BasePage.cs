using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace Mobiquity.PageObjects
{
    public class BasePage
    {
        public static IWebDriver Driver;
        public static WebDriverWait waitDriver;
        public static NgWebDriver ngDriver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            waitDriver = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            ngDriver = new NgWebDriver(driver);
        }
    }
}
