using HAN_ASD_ADP.Datasets;
using HAN_ASD_ADP.Implementations;
using System;
using System.Threading.Tasks;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations;

public class StackTests : IAsyncLifetime
{
    private DatasetSorteren dataset;

    public async Task InitializeAsync()
        => dataset = await DatasetCache<DatasetSorteren>.GetAsync();

    [Fact]
    public void LijstAflopend2_PopEmptyArrayInvalidOperationException_Test()
    {
        // Arrange
        Stack<int> listOfInts = new Stack<int>();

        // Assert
        Assert.Throws<InvalidOperationException>(() => listOfInts.Pop());
    }

    [Fact]
    public void LijstAflopend2_TopEmptyArrayInvalidOperationException_Test()
    {
        // Arrange
        Stack<int> listOfInts = new Stack<int>();

        // Assert
        Assert.Throws<InvalidOperationException>(() => listOfInts.Top());
    }

    [Theory]
    [InlineData("John Doe")]
    [InlineData("Jane Doe")]
    public void Push_Test(String itemToPush)
    {
        // Arrange
        Stack<String> listOfStrings = new Stack<String>();

        // Act
        listOfStrings.Push(itemToPush);

        // Assert
        Assert.Equal(itemToPush, listOfStrings.Top());
    }

    [Theory]
    [InlineData(new object[] { new int[] { 789, 456, 123 }, false })]
    [InlineData(new object[] { new int[] { -10, 555, -68 }, false })]
    [InlineData(new object[] { new int[] { 7885, 1, 7777 }, false })]
    [InlineData(new object[] { new int[] { }, true })]
    public void IsEmpty_Test(int[] itemsToPush, Boolean expected)
    {
        // Arrange
        Stack<int> listOfInts = new Stack<int>();

        // Act
        for (int i = 0; i < itemsToPush.Length; i++)
        {
            listOfInts.Push(itemsToPush[i]);
        }

        // Assert
        Assert.Equal(expected, listOfInts.IsEmpty());
    }

    [Theory]
    [InlineData(new object[] { new int[] { 789, 456, 123 }, 123 })]
    [InlineData(new object[] { new int[] { -10, 555, -68 }, -68 })]
    [InlineData(new object[] { new int[] { 7885, 1, 7777 }, 7777 })]
    [InlineData(new object[] { new int[] { 8, 8, 7, 7, 1, 7, 2, 1, 2, 7 }, 7 })]
    public void Top_Test(int[] itemsToPush, int expected)
    {
        // Arrange
        Stack<int> listOfInts = new Stack<int>();

        // Act
        for (int i = 0; i < itemsToPush.Length; i++)
        {
            listOfInts.Push(itemsToPush[i]);
        }

        // Assert
        Assert.Equal(expected, listOfInts.Top());
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 2)]
    [InlineData(2, 3)]
    public void LijstGesorteerdAflopend3_Pop_Test(int numberOfItemsToPop, int expected)
    {
        // Arrange
        Stack<int> listOfInts = new Stack<int>();

        // Act
        foreach (var value in dataset.LijstGesorteerdAflopend3)
        {
            listOfInts.Push(value);
        }

        for (int i = 0; i < numberOfItemsToPop; i++)
        {
            listOfInts.Pop();
        }

        // Assert
        Assert.Equal(expected, listOfInts.Top());
    }

    public Task DisposeAsync() => Task.CompletedTask;
}
