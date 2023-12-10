using HAN_ASD_ADP.Implementations;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations;

public class InsertionSortTests
{
    [Fact]
    public void UnsortedIntArray()
    {
        // Arrange
        var array = new int[] { 4, 5, 1, 3, 2 };
        var expected = new int[] { 1, 2, 3, 4, 5 };

        // Act
        InsertionSort.Sort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void SortOpenAiUnsortedIntArray()
    {
        // Arrange
        var array = new int[] { 4, 5, 1, 3, 2 };
        var expected = new int[] { 1, 2, 3, 4, 5 };

        // Act
        InsertionSort.SortOpenAi(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void UnsortedStringArray()
    {
        // Arrange
        var array = new string[] { "charlie", "alpha", "echo", "bravo", "delta" };
        var expected = new string[] { "alpha", "bravo", "charlie", "delta", "echo" };

        // Act
        InsertionSort.Sort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void SortedIntArray()
    {
        // Arrange
        var array = new int[] { 1, 2, 3, 4, 5 };
        var expected = new int[] { 1, 2, 3, 4, 5 };

        // Act
        InsertionSort.Sort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void SortedStringArray()
    {
        // Arrange
        var array = new string[] { "alpha", "bravo", "charlie", "delta", "echo" };
        var expected = new string[] { "alpha", "bravo", "charlie", "delta", "echo" };

        // Act
        InsertionSort.Sort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void ReverseSortedIntArray()
    {
        // Arrange
        var array = new int[] { 5, 4, 3, 2, 1 };
        var expected = new int[] { 1, 2, 3, 4, 5 };

        // Act
        InsertionSort.Sort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void ReverseSortedStringArray()
    {
        // Arrange
        var array = new string[] { "echo", "delta", "charlie", "bravo", "alpha" };
        var expected = new string[] { "alpha", "bravo", "charlie", "delta", "echo" };

        // Act
        InsertionSort.Sort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void SameValueIntArray()
    {
        // Arrange
        var array = new int[] { 1, 1, 1, 1, 1 };
        var expected = new int[] { 1, 1, 1, 1, 1 };

        // Act
        InsertionSort.Sort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void SameValueStringArray()
    {
        // Arrange
        var array = new string[] { "alpha", "alpha", "alpha", "alpha", "alpha" };
        var expected = new string[] { "alpha", "alpha", "alpha", "alpha", "alpha" };

        // Act
        InsertionSort.Sort(array);

        // Assert
        Assert.Equal(expected, array);
    }
}