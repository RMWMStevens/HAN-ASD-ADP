using HAN_ASD_ADP.Datasets;
using HAN_ASD_ADP.Implementations;
using System;
using System.Diagnostics;
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
    public void BasicOperations_Test()
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

        var itemGet = list.Get(index: 2);
        Assert.Equal(value3, itemGet.Value);

        list.Remove(value2);
        Assert.Equal(2, list.Count);

        list.Set(0, value3);
        var itemSetFind = list.Get(0);
        Assert.Equal(value3, itemSetFind.Value);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, -10033224)]
    public void LijstAflopend2_Add_Test(int index, int expected)
    {
        // Arrange
        var list = new DoublyLinkedList<int>();

        // Act
        foreach (var value in dataset.LijstAflopend2)
        {
            list.Add(value);
        }

        // Assert
        Assert.Equal(expected, list.Get(index).Value);
    }

    [Theory]
    [InlineData(0, -100324)]
    [InlineData(1, 1023)]
    public void LijstOplopend2_Add_Test(int index, int expected)
    {
        // Arrange
        var list = new DoublyLinkedList<int>();

        // Act
        foreach (var value in dataset.LijstOplopend2)
        {
            list.Add(value);
        }

        // Assert
        Assert.Equal(expected, list.Get(index).Value);
    }

    [Theory]
    [InlineData(0, -0.0)]
    [InlineData(1, 11312312312312.324)]
    [InlineData(2, 1)]
    [InlineData(3, -0.0)]
    [InlineData(7999, -0.0)]
    [InlineData(8000, 0.0)]
    public void LijstFloat8001_Add_Test(int index, float expected)
    {
        // Arrange
        var list = new DoublyLinkedList<float>();

        // Act
        foreach (var value in dataset.LijstFloat8001)
        {
            list.Add(value);
        }

        // Assert
        Assert.Equal(expected, list.Get(index).Value);
    }

    [Theory]
    [InlineData(2379)]
    [InlineData(2211)]
    [InlineData(8009)]
    public void LijstWillekeurig10000_Find_Test(int expected)
    {
        // Arrange
        var list = new DoublyLinkedList<int>();
        foreach (var value in dataset.LijstWillekeurig10000)
        {
            list.Add(value);
        }

        // Act
        var result = list.Find(expected);

        // Assert
        Assert.Equal(expected, result.Value);
    }

    [Theory]
    [InlineData(2379, 10)]
    [InlineData(2211, 1187)]
    [InlineData(8009, 9998)]
    public void LijstWillekeurig10000_IndexOf_Test(int index, int expected)
    {
        // Arrange
        var list = new DoublyLinkedList<int>();

        // Act
        foreach (var value in dataset.LijstWillekeurig10000)
        {
            list.Add(value);
        }

        var result = list.IndexOf(index);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 2)]
    [InlineData("string", 2)]
    public void LijstOnsorteerbaar3_Remove_Test(object node, int expected)
    {
        // Arrange
        var list = new DoublyLinkedList<object>();
        foreach (var value in dataset.LijstOnsorteerbaar3)
        {
            list.Add(value);
        }

        // Act
        list.Remove(node);

        // Assert
        Assert.Equal(expected, list.Count);
    }

    [Theory]
    [InlineData(0, 2)]
    [InlineData(1, 2)]
    public void LijstOnsorteerbaar3_RemoveAt_Test(int index, int expected)
    {
        // Arrange
        var list = new DoublyLinkedList<object>();

        // Act
        foreach (var value in dataset.LijstOnsorteerbaar3)
        {
            list.Add(value);
        }

        list.RemoveAt(index);

        // Assert
        Assert.Equal(expected, list.Count);
    }

    [Theory]
    [InlineData(10, 2379)]
    [InlineData(1187, 2211)]
    [InlineData(9998, 8009)]
    public void LijstWillekeurig10000_Set_Test(int index, int expected)
    {
        // Arrange
        var list = new DoublyLinkedList<int>();
        foreach (var value in dataset.LijstWillekeurig10000)
        {
            list.Add(value);
        }

        // Act
        list.Set(index, expected);

        // Assert
        Assert.Equal(expected, list.Get(index).Value);
    }

    [Fact]
    public void LijstAflopend2_IndexOutOfRangeException_Test()
    {
        // Arrange
        var list = new DoublyLinkedList<int>();
        foreach (var value in dataset.LijstAflopend2)
        {
            list.Add(value);
        }

        // Act && Assert
        Assert.Throws<IndexOutOfRangeException>(() => list.Get(5));
    }

    /// <summary>
    /// The Dataset 'Willekeurig10000' has 9999 items on which a 'Get' can be performed.
    /// As the DoublyLinkedList has both a Head and a Tail, the index could be retrieved from both ends.
    /// For indexes with values under ~5000, the search will be performed from the Head.
    /// For indexes with values over 5000, the search will be performed from the Tail.
    /// In this test the retrieved value is not important, only the time it took to do so.
    /// </summary>
    /// <param name="lowIndex">Low index.</param>
    /// <param name="highIndex">High index.</param>
    /// <param name="expectedLowFaster">Whether retrieving the low index should be faster than the high index.</param>
    [Theory]
    [InlineData(50, 500, true)] // Both search from Head, Low should be faster. 
    [InlineData(100, 1000, true)] // Both search from Head, Low should be faster. 
    [InlineData(40, 4000, true)] // Both search from Head, Low should be faster. 
    [InlineData(5001, 9001, false)] // Both search from Tail, High should be faster. 
    [InlineData(6001, 8001, false)] // Both search from Tail, High should be faster. 
    [InlineData(6999, 7001, false)] // Both search from Tail, High should be faster. 
    [InlineData(1000, 8000, true)] // Low from Head, High from Tail. Low faster because it's closer to Head. 
    [InlineData(2000, 9000, false)] // Low from Head, High from Tail. High faster because it's closer to Tail. 
    public void LijstWillekeurig10000_Get_Performance_Test(int lowIndex, int highIndex, bool expectedLowFaster)
    {
        // Arrange
        var list = new DoublyLinkedList<int>();
        foreach (var value in dataset.LijstWillekeurig10000)
        {
            list.Add(value);
        }
        var stopwatchLow = new Stopwatch();
        var stopwatchHigh = new Stopwatch();

        // Warmup for more accurate results
        list.Get(3500);
        list.Get(6500);

        // Act
        stopwatchLow.Start();
        list.Get(lowIndex);
        stopwatchLow.Stop();

        stopwatchHigh.Start();
        list.Get(highIndex);
        stopwatchHigh.Stop();

        // Assert
        var lowFaster = stopwatchLow.ElapsedTicks < stopwatchHigh.ElapsedTicks;
        Assert.Equal(expectedLowFaster, lowFaster);
    }

    public Task DisposeAsync() => Task.CompletedTask;
}