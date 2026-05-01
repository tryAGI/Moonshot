namespace Moonshot.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static MoonshotClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MOONSHOT_API_KEY") is { Length: > 0 } moonshotKeyValue
                ? moonshotKeyValue
                : Environment.GetEnvironmentVariable("KIMI_API_KEY") is { Length: > 0 } kimiKeyValue
                ? kimiKeyValue
                : throw new AssertInconclusiveException("MOONSHOT_API_KEY or KIMI_API_KEY environment variable is not found.");

        var client = new MoonshotClient(apiKey);
        
        return client;
    }
}
