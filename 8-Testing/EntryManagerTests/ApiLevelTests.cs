using Microsoft.AspNetCore.Mvc.Testing;
using LabDemo.IDesign.EntryManager;

namespace EntryManagerTests;

public class ApiLevelTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _webApplicationFactory;

    public ApiLevelTests(WebApplicationFactory<Program> webApplicationFactory)
    {
        _webApplicationFactory = webApplicationFactory;
    }

    [Fact]
    public async void Ping_ShouldSucceed_WhenNominal()
    {
        var entryApi = _webApplicationFactory.CreateClient();

        var response = await entryApi.GetAsync("/ping");

        Assert.True(response.IsSuccessStatusCode);
        var content = await response.Content.ReadAsStringAsync();
        Assert.Equivalent("hello", content);
    }
}