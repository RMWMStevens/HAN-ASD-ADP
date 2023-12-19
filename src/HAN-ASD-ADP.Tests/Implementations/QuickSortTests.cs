using HAN_ASD_ADP.Implementations;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations;

public class QuickSortTests
{
    [Fact]
    public void UnsortedIntArray_High()
    {
        // Arrange
        var array = new int[] { 4, 5, 1, 3, 2 };
        var expected = new int[] { 1, 2, 3, 4, 5 };

        // Act
        QuickSort.SortHigh(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void UnsortedIntArray_Middle()
    {
        // Arrange
        var array = new int[] { 4, 5, 1, 3, 2 };
        var expected = new int[] { 1, 2, 3, 4, 5 };

        // Act
        QuickSort.SortMiddle(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void UnsortedIntArray_Random()
    {
        // Arrange
        var array = new int[] { 4, 5, 1, 3, 2 };
        var expected = new int[] { 1, 2, 3, 4, 5 };

        // Act
        QuickSort.SortRandom(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void UnsortedIntArray_Median()
    {
        // Arrange
        var array = new int[] { 4, 5, 1, 3, 2 };
        var expected = new int[] { 1, 2, 3, 4, 5 };

        // Act
        QuickSort.SortMedian(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void UnsortedStringArray_High()
    {
        // Arrange
        var array = new string[] { "charlie", "alpha", "echo", "bravo", "delta" };
        var expected = new string[] { "alpha", "bravo", "charlie", "delta", "echo" };

        // Act
        QuickSort.SortHigh(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void UnsortedStringArray_Median()
    {
        // Arrange
        var array = new string[] { "charlie", "alpha", "echo", "bravo", "delta" };
        var expected = new string[] { "alpha", "bravo", "charlie", "delta", "echo" };

        // Act
        QuickSort.SortMedian(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void SortedIntArray_High()
    {
        // Arrange
        var array = new int[] { 1, 2, 3, 4, 5 };
        var expected = new int[] { 1, 2, 3, 4, 5 };

        // Act
        QuickSort.SortHigh(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void SortedStringArray_High()
    {
        // Arrange
        var array = new string[] { "alpha", "bravo", "charlie", "delta", "echo" };
        var expected = new string[] { "alpha", "bravo", "charlie", "delta", "echo" };

        // Act
        QuickSort.SortHigh(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void ReverseSortedIntArray_High()
    {
        // Arrange
        var array = new int[] { 5, 4, 3, 2, 1 };
        var expected = new int[] { 1, 2, 3, 4, 5 };

        // Act
        QuickSort.SortHigh(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void ReverseSortedStringArray_High()
    {
        // Arrange
        var array = new string[] { "echo", "delta", "charlie", "bravo", "alpha" };
        var expected = new string[] { "alpha", "bravo", "charlie", "delta", "echo" };

        // Act
        QuickSort.SortHigh(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void SameValueIntArray_High()
    {
        // Arrange
        var array = new int[] { 1, 1, 1, 1, 1 };
        var expected = new int[] { 1, 1, 1, 1, 1 };

        // Act
        QuickSort.SortHigh(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void SameValueStringArray_High()
    {
        // Arrange
        var array = new string[] { "alpha", "alpha", "alpha", "alpha", "alpha" };
        var expected = new string[] { "alpha", "alpha", "alpha", "alpha", "alpha" };

        // Act
        QuickSort.SortHigh(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void SameValueStringArray_Median()
    {
        // Arrange
        var array = new string[] { "alpha", "alpha", "alpha", "alpha", "alpha" };
        var expected = new string[] { "alpha", "alpha", "alpha", "alpha", "alpha" };

        // Act
        QuickSort.SortMedian(array);

        // Assert
        Assert.Equal(expected, array);
    }
}