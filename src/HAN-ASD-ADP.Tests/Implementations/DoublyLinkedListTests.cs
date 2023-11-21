using HAN_ASD_ADP.Datasets;
using HAN_ASD_ADP.Implementations;
using System;
using System.Threading.Tasks;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations;

public class DoublyLinkedListTests : IAsyncLifetime
{
    private DatasetSorteren dataset;

    public async Task InitializeAsync()
        => dataset = await DatasetCache<DatasetSorteren>.GetAsync();

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

        var itemGet = list.Get(index: 2);
        Assert.Equal(value3, itemGet);

        list.Remove(value2);
        Assert.Equal(2, list.Count);

        list.Set(0, value3);
        var itemSetFind = list.Get(0);
        Assert.Equal(value3, itemSetFind);
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
        Assert.Equal(expected, list.Get(index));
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
        Assert.Equal(expected, list.Get(index));
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
        Assert.Equal(expected, list.Get(index));
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
        Assert.Equal(expected, list.Get(index));
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

    public Task DisposeAsync() => Task.CompletedTask;
}