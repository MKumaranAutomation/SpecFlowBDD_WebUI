using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace SpecFlowWebUIBDD.Pages
{
	public class AmazonLandingPage
	{
		public IWebDriver WebDriver { get; }

		public AmazonLandingPage(IWebDriver webDriver)
		{
			WebDriver = webDriver;
		}

		public AmazonLandingPage()
		{
		}

		[FindsBy(How = How.Id, Using = "nav-logo")]
		IWebElement _logo;

		[FindsBy(How = How.Id, Using = "nav-search-field ")]
		IWebElement _searchField;

		public bool VerifyLogo() => _logo.Displayed;

		public bool VerifySearchField() => _searchField.Displayed;

	}
}
