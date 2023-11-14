using HAN_ASD_ADP.Datasets;
using System.Threading.Tasks;
using Xunit;

namespace HAN_ASD_ADP.Tests.Datasets;

public abstract class DatasetCacheTests<T> : IAsyncLifetime
    where T : IDataset
{
    private T dataset;

    public async Task InitializeAsync()
    {
        dataset = await DatasetCache<T>.GetAsync();
    }

    public Task DisposeAsync() => Task.CompletedTask;

    [Fact]
    public void GetAsync_Test()
    {
        Assert.NotNull(dataset);
    }
}