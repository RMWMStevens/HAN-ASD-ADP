using HAN_ASD_ADP.Datasets;
using HAN_ASD_ADP.Implementations;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations;

public class DynamicArrayTests : IAsyncLifetime
{
    private DatasetSorteren dataset;

    public async Task InitializeAsync()
        => dataset = await DatasetCache<DatasetSorteren>.GetAsync();

    [Fact]
    public void LijstAflopend2_IndexOutOfRangeException_Test()
    {
        // Arrange
        DynamicArray<int> listOfInts = new DynamicArray<int>();

        // Act
        foreach (var value in dataset.LijstAflopend2)
        {
            listOfInts.Add(value);
        }

        // Assert
        Assert.Throws<IndexOutOfRangeException>(() => listOfInts.Get(5));
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, -10033224)]
    public void LijstAflopend2_Add_Test(int index, int expected)
    {
        // Arrange
        DynamicArray<int> listOfInts = new DynamicArray<int>();

        // Act
        foreach (var value in dataset.LijstAflopend2)
        {
            listOfInts.Add(value);
        }

        // Assert
        Assert.Equal(expected, listOfInts.Get(index));
    }

    [Theory]
    [InlineData(0, -100324)]
    [InlineData(1, 1023)]
    public void LijstOplopend2_Add_Test(int index, int expected)
    {
        // Arrange
        DynamicArray<int> listOfInts = new DynamicArray<int>();

        // Act
        foreach (var value in dataset.LijstOplopend2)
        {
            listOfInts.Add(value);
        }

        // Assert
        Assert.Equal(expected, listOfInts.Get(index));
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
        DynamicArray<float> listOfFloats = new DynamicArray<float>();

        // Act
        foreach (var value in dataset.LijstFloat8001)
        {
            listOfFloats.Add(value);
        }

        // Assert
        Assert.Equal(expected, listOfFloats.Get(index));
    }

    [Theory]
    [InlineData(2379, 10)]
    [InlineData(2211, 1187)]
    [InlineData(8009, 9998)]
    public void LijstWillekeurig10000_IndexOf_Test(int index, int expected)
    {
        // Arrange
        DynamicArray<int> listOfInts = new DynamicArray<int>();

        // Act
        foreach (var value in dataset.LijstWillekeurig10000)
        {
            listOfInts.Add(value);
        }

        var result = listOfInts.IndexOf(index);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 2379)]
    [InlineData(1187, 2211)]
    [InlineData(9998, 8009)]
    public void LijstWillekeurig10000_Set_Test(int index, int expected)
    {
        // Arrange
        DynamicArray<int> listOfInts = new DynamicArray<int>();

        // Act
        foreach (var value in dataset.LijstWillekeurig10000)
        {
            listOfInts.Add(value);
        }

        listOfInts.Set(index, expected);

        // Assert
        Assert.Equal(expected, listOfInts.Get(index));
    }

    [Theory]
    [InlineData(1, 2)]
    [InlineData("string", 2)]
    public void LijstOnsorteerbaar3_Remove_Test(object node, int expected)
    {
        // Arrange
        var list = new DynamicArray<object>();
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
        DynamicArray<object> listOfObjects = new DynamicArray<object>();

        // Act
        foreach (var value in dataset.LijstOnsorteerbaar3)
        {
            listOfObjects.Add(value);
        }

        listOfObjects.RemoveAt(index);

        // Assert
        Assert.Equal(expected, listOfObjects.Count);
    }

    [Theory]
    [InlineData(0, 99980000)]
    public void LijstWillekeurig10000_RemoveAtLast100xSlowerThanRemoveFirst_Test(int lowIndex, int highIndex)
    {
        // Arrange
        DynamicArray<int> listOfInts = new DynamicArray<int>();

        // Act
        for (int i = 0; i < 10000; i++)
        {
            foreach (var value in dataset.LijstWillekeurig10000)
            {
                listOfInts.Add(value);
            }
        }

        Stopwatch stopwatchLast = Stopwatch.StartNew();
        listOfInts.RemoveAt(highIndex);
        stopwatchLast.Stop();

        Stopwatch stopwatchFirst = Stopwatch.StartNew();
        listOfInts.RemoveAt(lowIndex);
        stopwatchFirst.Stop();

        var removeLastSlowerThanRemoveFirst = (stopwatchLast.ElapsedTicks * 100) < stopwatchFirst.ElapsedTicks;

        // Assert
        Assert.True(removeLastSlowerThanRemoveFirst);
    }

    public Task DisposeAsync() => Task.CompletedTask;
}