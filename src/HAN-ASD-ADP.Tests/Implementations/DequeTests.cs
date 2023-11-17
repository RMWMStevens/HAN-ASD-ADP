using HAN_ASD_ADP.Datasets;
using HAN_ASD_ADP.Implementations;
using System.Threading.Tasks;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations;

public class DequeTests : IAsyncLifetime
{
    private DatasetSorteren dataset;

    public async Task InitializeAsync()
        => dataset = await DatasetCache<DatasetSorteren>.GetAsync();

    [Fact]
    public void BasicOperations_Test()
    {
        // Arrange
        var deque = new Deque<string>();
        var value1 = "first";
        var value2 = "second";
        var value3 = "third";

        // Act & Assert
        deque.EnqueueRight(value1);
        deque.EnqueueRight(value2);
        deque.EnqueueRight(value3);
        Assert.Equal(3, deque.Size());

        // Act & Assert
        deque.EnqueueLeft(value1);
        deque.EnqueueLeft(value2);
        deque.EnqueueLeft(value3);
        Assert.Equal(6, deque.Size());

        Assert.False(deque.IsEmpty());
        var itemDequeue = deque.DequeueLeft();
        Assert.Equal(value3, itemDequeue);
        itemDequeue = deque.DequeueLeft();
        Assert.Equal(value2, itemDequeue);
        itemDequeue = deque.DequeueLeft();
        Assert.Equal(value1, itemDequeue);
        itemDequeue = deque.DequeueLeft();
        Assert.Equal(value1, itemDequeue);
        itemDequeue = deque.DequeueRight();
        Assert.Equal(value3, itemDequeue);
        itemDequeue = deque.DequeueRight();
        Assert.Equal(value2, itemDequeue);
        Assert.True(deque.IsEmpty());
    }

    public Task DisposeAsync() => Task.CompletedTask;
}