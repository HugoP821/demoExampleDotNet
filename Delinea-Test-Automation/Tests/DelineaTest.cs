using NUnit.Framework;
using DemoProject.Pages;

namespace Delinea_Test_Automation.Steps
{
    public class GoogleSteps : BaseTest
    {
        [Test]
        public void SeachDelineaSite()
        {
            var google = new GooglePage(driver);
            google.NavigateTo("https://www.google.com");
            google.Search("Delinea");

            Assert.IsTrue(driver.PageSource.Contains("delinea.com/es"));
        }
    }
    {
        
    }
}