using HAN_ASD_ADP.Datasets;
using HAN_ASD_ADP.Implementations;
using System;
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

    [Fact]
    public void LijstAflopend2_EnqueueLeft_Test()
    {
        // Arrange
        var deque = new Deque<int>();

        // Act
        foreach (var value in dataset.LijstAflopend2)
        {
            deque.EnqueueLeft(value);
        }

        // Assert
        Assert.Equal(dataset.LijstAflopend2.Count, deque.Size());
    }

    [Fact]
    public void LijstAflopend2_EnqueueRight_Test()
    {
        // Arrange
        var deque = new Deque<int>();

        // Act
        foreach (var value in dataset.LijstAflopend2)
        {
            deque.EnqueueRight(value);
        }

        // Assert
        Assert.Equal(dataset.LijstAflopend2.Count, deque.Size());
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(3, 4)]
    public void LijstOplopend10000_DequeueLeft_Test(int dequeueCount, float expected)
    {
        // Arrange
        var deque = new Deque<float>();

        // Act
        foreach (var value in dataset.LijstOplopend10000)
        {
            deque.EnqueueRight(value);
        }

        for (int index = 0; index < dequeueCount; index++)
        {
            deque.DequeueLeft();
        }

        // Assert
        Assert.Equal(dataset.LijstOplopend10000.Count - dequeueCount, deque.Size());
        Assert.Equal(expected, deque.DequeueLeft());
    }

    [Theory]
    [InlineData(0, 9999)]
    [InlineData(3, 9996)]
    public void LijstOplopend10000_DequeueRight_Test(int dequeueCount, float expected)
    {
        // Arrange
        var deque = new Deque<float>();

        // Act
        foreach (var value in dataset.LijstOplopend10000)
        {
            deque.EnqueueRight(value);
        }

        for (int index = 0; index < dequeueCount; index++)
        {
            deque.DequeueRight();
        }

        // Assert
        Assert.Equal(dataset.LijstOplopend10000.Count - dequeueCount, deque.Size());
        Assert.Equal(expected, deque.DequeueRight());
    }

    [Theory]
    [InlineData(0, 5824)]
    [InlineData(3, 4138)]
    public void LijstWillekeurig10000_DequeueLeft_Test(int dequeueCount, float expected)
    {
        // Arrange
        var deque = new Deque<float>();

        // Act
        foreach (var value in dataset.LijstWillekeurig10000)
        {
            deque.EnqueueRight(value);
        }

        for (int index = 0; index < dequeueCount; index++)
        {
            deque.DequeueLeft();
        }

        // Assert
        Assert.Equal(dataset.LijstWillekeurig10000.Count - dequeueCount, deque.Size());
        Assert.Equal(expected, deque.DequeueLeft());
    }

    [Theory]
    [InlineData(0, 8009)]
    [InlineData(3, 2821)]
    public void LijstWillekeurig10000_DequeueRight_Test(int dequeueCount, float expected)
    {
        // Arrange
        var deque = new Deque<float>();

        // Act
        foreach (var value in dataset.LijstWillekeurig10000)
        {
            deque.EnqueueRight(value);
        }

        for (int index = 0; index < dequeueCount; index++)
        {
            deque.DequeueRight();
        }

        // Assert
        Assert.Equal(dataset.LijstWillekeurig10000.Count - dequeueCount, deque.Size());
        Assert.Equal(expected, deque.DequeueRight());
    }

    [Fact]
    public void Left_InvalidOperationException_Test()
    {
        // Arrange
        var deque = new Deque<int?>();

        // Act
        deque.EnqueueLeft(1); // Put something in
        deque.DequeueLeft();  // Take elements out so that queue is empty

        // Assert
        Assert.Throws<InvalidOperationException>(() => deque.DequeueLeft());
    }

    [Fact]
    public void Right_InvalidOperationException_Test()
    {
        // Arrange
        var deque = new Deque<int?>();

        // Act
        deque.EnqueueRight(1); // Put something in
        deque.DequeueRight();  // Take elements out so that queue is empty

        // Assert
        Assert.Throws<InvalidOperationException>(() => deque.DequeueRight());
    }

    public Task DisposeAsync() => Task.CompletedTask;
}