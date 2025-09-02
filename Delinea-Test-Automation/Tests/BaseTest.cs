using NUnit.Framework;
using OpenQA.Selenium;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace Delinea_Test_Automation.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }
        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}