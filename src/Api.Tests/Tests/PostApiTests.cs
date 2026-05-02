using Api.Tests.Clients;
using FluentAssertions;
using NUnit.Framework;
using Shared;

namespace Api.Tests.Tests;

[TestFixture]
[Parallelizable(ParallelScope.All)]
public sealed class PostApiTests
{
    private readonly TestSettings _settings = TestSettings.FromEnvironment();
    private JsonPlaceholderClient _client = null!;

    [SetUp]
    public void SetUp()
    {
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri(_settings.ApiBaseUrl),
            Timeout = TimeSpan.FromSeconds(_settings.DefaultTimeoutSeconds)
        };

        _client = new JsonPlaceholderClient(httpClient);
    }

    [Test]
    public async Task GetPost_Should_ReturnExpectedPostShape()
    {
        var post = await _client.GetPostAsync(1);

        post.Should().NotBeNull();
        post!.Id.Should().Be(1);
        post.UserId.Should().BeGreaterThan(0);
        post.Title.Should().NotBeNullOrWhiteSpace();
        post.Body.Should().NotBeNullOrWhiteSpace();
    }

    [Test]
    public async Task GetMissingPost_Should_ReturnNotFound()
    {
        using var response = await _client.GetMissingPostAsync();

        ((int)response.StatusCode).Should().Be(404);
    }
}
