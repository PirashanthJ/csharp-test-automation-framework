using System.Net.Http.Json;
using Api.Tests.Models;

namespace Api.Tests.Clients;

public sealed class JsonPlaceholderClient
{
    private readonly HttpClient _httpClient;

    public JsonPlaceholderClient(HttpClient httpClient) => _httpClient = httpClient;

    public async Task<Post?> GetPostAsync(int id, CancellationToken cancellationToken = default)
    {
        using var response = await _httpClient.GetAsync($"/posts/{id}", cancellationToken);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Post>(cancellationToken: cancellationToken);
    }

    public async Task<HttpResponseMessage> GetMissingPostAsync(CancellationToken cancellationToken = default)
    {
        return await _httpClient.GetAsync("/posts/999999", cancellationToken);
    }
}
