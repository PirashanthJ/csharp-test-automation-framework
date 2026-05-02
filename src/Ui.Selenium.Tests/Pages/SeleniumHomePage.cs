using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Ui.Selenium.Tests.Pages;

public sealed class SeleniumHomePage
{
    private readonly IWebDriver _driver;
    private readonly WebDriverWait _wait;

    public SeleniumHomePage(IWebDriver driver, TimeSpan timeout)
    {
        _driver = driver;
        _wait = new WebDriverWait(driver, timeout);
    }

    private By Heading => By.CssSelector("h1");
    private By MoreInformationLink => By.CssSelector("a[href*='iana.org/domains/example']");

    public void Open(string baseUrl)
    {
        _driver.Navigate().GoToUrl(baseUrl);
        _wait.Until(driver => driver.FindElement(Heading).Displayed);
    }

    public string GetHeadingText() => _driver.FindElement(Heading).Text;

    public bool HasMoreInformationLink() => _wait.Until(driver => driver.FindElement(MoreInformationLink).Displayed);
}
