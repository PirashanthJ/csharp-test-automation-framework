using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shared;
using Ui.Selenium.Tests.Pages;

namespace Ui.Selenium.Tests.Tests;

[TestFixture]
[Parallelizable(ParallelScope.None)]
public sealed class SeleniumHomePageTests
{
    private readonly TestSettings _settings = TestSettings.FromEnvironment();
    private IWebDriver? _driver;

    [SetUp]
    public void SetUp()
    {
        var options = new ChromeOptions();
        if (_settings.Headless)
        {
            options.AddArgument("--headless=new");
        }

        options.AddArgument("--window-size=1440,900");
        options.AddArgument("--disable-gpu");
        options.AddArgument("--no-sandbox");

        _driver = new ChromeDriver(options);
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
    }

    [TearDown]
    public void TearDown()
    {
        _driver?.Quit();
        _driver?.Dispose();
    }

    [Test]
    public void HomePage_Should_DisplayExpectedHeading()
    {
        var page = new SeleniumHomePage(_driver!, TimeSpan.FromSeconds(_settings.DefaultTimeoutSeconds));

        page.Open(_settings.BaseUrl);

        Assert.That(page.GetHeadingText(), Is.EqualTo("Example Domain"));
    }

    [Test]
    public void HomePage_Should_ShowMoreInformationLink()
    {
        var page = new SeleniumHomePage(_driver!, TimeSpan.FromSeconds(_settings.DefaultTimeoutSeconds));

        page.Open(_settings.BaseUrl);

        Assert.That(page.HasMoreInformationLink(), Is.True);
    }
}
