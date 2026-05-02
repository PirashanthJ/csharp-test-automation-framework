using Microsoft.Playwright;

namespace Ui.Playwright.Tests.Pages;

public sealed class HomePage
{
    private readonly IPage _page;

    public HomePage(IPage page) => _page = page;

    private ILocator PageHeading => _page.GetByRole(AriaRole.Heading).First;
    private ILocator MoreInformationLink => _page.GetByRole(AriaRole.Link, new() { Name = "More information" });

    public async Task OpenAsync(string baseUrl)
    {
        await _page.GotoAsync(baseUrl, new() { WaitUntil = WaitUntilState.DOMContentLoaded });
    }

    public async Task<string> GetHeadingTextAsync() => await PageHeading.InnerTextAsync();

    public async Task<bool> HasMoreInformationLinkAsync() => await MoreInformationLink.IsVisibleAsync();
}
