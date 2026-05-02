using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using Shared;
using Ui.Playwright.Tests.Pages;

namespace Ui.Playwright.Tests.Tests;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public sealed class HomePageTests : PageTest
{
    private readonly TestSettings _settings = TestSettings.FromEnvironment();

    [Test]
    public async Task HomePage_Should_DisplayExpectedHeading()
    {
        var homePage = new HomePage(Page);

        await homePage.OpenAsync(_settings.BaseUrl);

        var heading = await homePage.GetHeadingTextAsync();
        Assert.That(heading, Is.Not.Empty);
    }

    [Test]
    public async Task HomePage_Should_ShowMoreInformationLink()
    {
        var homePage = new HomePage(Page);

        await homePage.OpenAsync(_settings.BaseUrl);

        Assert.That(await homePage.HasMoreInformationLinkAsync(), Is.True);
    }
}
