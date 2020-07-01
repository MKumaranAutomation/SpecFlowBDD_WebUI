using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowWebUIBDD.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowWebUIBDD.Steps
{
    [Binding]
    public sealed class AmazonLandingPageStepDef
    {
        //AmazonLandingPage amazonLandingPage;
        IWebDriver driver = new ChromeDriver();
        AmazonLandingPage amazonLandingPage = null;

        //public AmazonLandingPageStepDef()
        //{
        //   amazonLandingPage = new AmazonLandingPage();
        //}
       

        [Given(@"I launch the  Amazon Site ""(.*)""")]
        public void GivenILaunchTheAmazonSite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"The Page is loaded")]
        public void WhenThePageIsLoaded()
        {
            driver.Manage().Window.Maximize();
        }

        [Then(@"Verify the page")]
        public void ThenVerifyThePage()
        {
            Assert.True(amazonLandingPage.VerifyLogo(), "The Logo is not available");
            driver.Close();
        }


    }
}
