using DemoProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Delinea_Test_Automation.Steps
{
    [Binding]
    public class GoogleSteps
    {
        private readonly IWebDriver driver;
        private GooglePage google;

        public GoogleSteps(IWebDriver driver)
        {
            this.driver = driver;
            google = new GooglePage(driver);
        }

        [Given(@"Here in Google Page")]
        public void GivenQueEstoyEnLaPaginaDeGoogle()
        {
            google.NavigateTo("https://www.google.com");
        }

        [When(@"busco ""(.*)""")]
        public void WhenBusco(string palabra)
        {
            google.Search(palabra);
        }

        [Then(@"debería ver ""(.*)"" en los resultados")]
        public void ThenDeberiaVerEnLosResultados(string resultado)
        {
            Assert.IsTrue(driver.PageSource.Contains(resultado));
        }
    }
}
