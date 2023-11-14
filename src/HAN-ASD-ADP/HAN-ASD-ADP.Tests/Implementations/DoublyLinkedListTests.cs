using HAN_ASD_ADP.Datasets;
using HAN_ASD_ADP.Implementations;
using System.Threading.Tasks;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations;

public class DoublyLinkedListTests : IAsyncLifetime
{
    private DatasetSorteren dataset;

    public async Task InitializeAsync()
    {
        dataset = await DatasetCache<DatasetSorteren>.GetAsync();
    }

    [Fact]
    public void Test()
    {
        // Arrange
        var list = new DoublyLinkedList<string>();
        var value1 = "first";
        var value2 = "second";
        var value3 = "third";

        // Act & Assert
        list.Add(value1);
        list.Add(value2);
        list.Add(value3);
        Assert.Equal(3, list.Count);

        var itemFind = list.Find(value1);
        Assert.NotNull(itemFind);
        Assert.Equal(value1, itemFind.Value);

        var itemGet = list.Get(index: 1);
        Assert.Equal(value2, itemGet.Value);

        list.Remove(value3);
        Assert.Equal(2, list.Count);

        list.Set(0, value3);
        var itemSetFind = list.Get(0);
        Assert.Equal(value3, itemSetFind.Value);
    }

    public Task DisposeAsync() => Task.CompletedTask;
}