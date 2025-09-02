using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Delinea_Test_Automation.Pages
{
    public class GooglePage : BasePage
    {
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement searchBox;

        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement searchButton;

        public void Search(string query)
        {
            searchBox.SendKeys(query);
            searchButton.Click();
        }
    }
}