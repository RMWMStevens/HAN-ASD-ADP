using HAN_ASD_ADP.Datasets;
using HAN_ASD_ADP.Implementations;
using System;
using System.Threading.Tasks;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations;

public class PriorityQueueTests : IAsyncLifetime
{
    private DatasetSorteren dataset;

    public async Task InitializeAsync()
        => dataset = await DatasetCache<DatasetSorteren>.GetAsync();

    [Fact]
    public void BasicOperations_Test()
    {
        // Arrange
        var queue = new PriorityQueueOld<int>();
        var value1 = 1;
        var value2 = 2;
        var value3 = 3;

        // Act & Assert
        queue.Add(value1);
        queue.Add(value2);
        queue.Add(value3);
        Assert.Equal(value1, queue.DeleteMin());
        Assert.Equal(value2, queue.DeleteMin());

        Assert.Equal(value3, queue.FindMin());
        queue.Add(value1);
        Assert.Equal(value1, queue.FindMin());
    }

    [Fact]
    public void LijstAflopend2_Add_Test()
    {
        // Arrange
        var queue = new PriorityQueueOld<int>();

        // Act
        foreach (var value in dataset.LijstAflopend2)
        {
            queue.Add(value);
        }
    }

    [Fact]
    public void LijstGesorteerdAflopend3_DeleteMin_Test()
    {
        // Arrange
        var queue = new PriorityQueueOld<int>();
        foreach (var value in dataset.LijstGesorteerdAflopend3)
        {
            queue.Add(value);
        }

        // Act & Assert
        Assert.Equal(1, queue.DeleteMin());
        Assert.Equal(2, queue.DeleteMin());
        Assert.Equal(3, queue.DeleteMin());
    }

    [Fact]
    public void LijstGesorteerdOplopend3_DeleteMin_Test()
    {
        // Arrange
        var queue = new PriorityQueueOld<int>();
        foreach (var value in dataset.LijstWillekeurig3)
        {
            queue.Add(value);
        }

        // Act & Assert
        Assert.Equal(1, queue.DeleteMin());
        Assert.Equal(2, queue.DeleteMin());
        Assert.Equal(3, queue.DeleteMin());
    }

    [Fact]
    public void LijstWillekeurig10000_DeleteMin_Test()
    {
        // Arrange
        var queue = new PriorityQueueOld<int>();
        foreach (var value in dataset.LijstWillekeurig10000)
        {
            queue.Add(value);
        }

        // Act & Assert
        for (int i = 1; i < dataset.LijstWillekeurig10000.Count; i++)
        {
            Assert.Equal(i, queue.DeleteMin());
        }
    }

    [Fact]
    public void LijstAflopend2_InvalidOperationException_Test()
    {
        // Arrange
        var queue = new PriorityQueueOld<int>();
        foreach (var value in dataset.LijstAflopend2)
        {
            queue.Add(value);
        }

        // Act && Assert
        queue.DeleteMin();
        queue.DeleteMin();
        Assert.Throws<InvalidOperationException>(() => queue.DeleteMin());
    }

    public Task DisposeAsync() => Task.CompletedTask;
}