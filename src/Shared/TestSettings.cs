namespace Shared;

public sealed record TestSettings
{
    public string BaseUrl { get; init; } = "https://example.com";
    public string ApiBaseUrl { get; init; } = "https://jsonplaceholder.typicode.com";
    public int DefaultTimeoutSeconds { get; init; } = 30;
    public bool Headless { get; init; } = true;

    public static TestSettings FromEnvironment() => new()
    {
        BaseUrl = Environment.GetEnvironmentVariable("BASE_URL") ?? "https://example.com",
        ApiBaseUrl = Environment.GetEnvironmentVariable("API_BASE_URL") ?? "https://jsonplaceholder.typicode.com",
        DefaultTimeoutSeconds = int.TryParse(Environment.GetEnvironmentVariable("TIMEOUT_SECONDS"), out var timeout) ? timeout : 30,
        Headless = !bool.TryParse(Environment.GetEnvironmentVariable("HEADLESS"), out var headless) || headless
    };
}
