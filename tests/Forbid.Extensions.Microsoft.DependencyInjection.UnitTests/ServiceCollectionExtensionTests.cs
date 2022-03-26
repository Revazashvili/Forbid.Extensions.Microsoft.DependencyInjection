using Forbids;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Forbid.Extensions.Microsoft.DependencyInjection.UnitTests;

public class ServiceCollectionExtensionTests
{
    [Fact]
    public void Should_Inject_Without_Exception()
    {
        var services = new ServiceCollection();
        services.AddForbids();
    }

    [Fact]
    public void Should_Inject_And_Resolve_Services()
    {
        var services = new ServiceCollection();
        services.AddForbids();
        
        var serviceProvider = services.BuildServiceProvider();
        var forbid = serviceProvider.GetService<IForbid>();
        Assert.NotNull(forbid);
    }
}