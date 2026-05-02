namespace Shared;

public static class WaitExtensions
{
    public static async Task UntilAsync(
        Func<Task<bool>> condition,
        TimeSpan timeout,
        TimeSpan? pollingInterval = null,
        string? failureMessage = null)
    {
        var interval = pollingInterval ?? TimeSpan.FromMilliseconds(250);
        var deadline = DateTimeOffset.UtcNow.Add(timeout);

        while (DateTimeOffset.UtcNow < deadline)
        {
            if (await condition())
            {
                return;
            }

            await Task.Delay(interval);
        }

        throw new TimeoutException(failureMessage ?? $"Condition was not met within {timeout.TotalSeconds} seconds.");
    }
}
