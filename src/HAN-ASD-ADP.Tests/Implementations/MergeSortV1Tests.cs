using HAN_ASD_ADP.Implementations;
using HAN_ASD_ADP.Tests.TestClasses;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations;

public class MergeSortV1Tests
{
    [Fact]
    public void MergeSortIntsTest()
    {
        // Arrange
        int[] arrayOfInts = { 5, 6, 8, 0, 7, 4, 1, 3, 2, 9 };
        int[] sortedArrayOfInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        MergeSortV1.Sort(arrayOfInts);
        bool theSame = true;
        for (int i = 0; i < arrayOfInts.Length; i++)
        {
            if (arrayOfInts[i] != sortedArrayOfInts[i])
            {
                theSame = false;
            }
        }

        // Assert
        Assert.True(theSame);
    }

    [Fact]
    public void MergeSortIntsTest_Parallel()
    {
        // Arrange
        int[] arrayOfInts = { 5, 6, 8, 0, 7, 4, 1, 3, 2, 9 };
        int[] sortedArrayOfInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        MergeSortV1.SortParallel(arrayOfInts);
        bool theSame = true;
        for (int i = 0; i < arrayOfInts.Length; i++)
        {
            if (arrayOfInts[i] != sortedArrayOfInts[i])
            {
                theSame = false;
            }
        }

        // Assert
        Assert.True(theSame);
    }

    [Fact]
    public void MergeSortIntsTest_Async()
    {
        // Arrange
        int[] arrayOfInts = { 5, 6, 8, 0, 7, 4, 1, 3, 2, 9 };
        int[] sortedArrayOfInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        MergeSortV1.SortAsync(arrayOfInts);
        bool theSame = true;
        for (int i = 0; i < arrayOfInts.Length; i++)
        {
            if (arrayOfInts[i] != sortedArrayOfInts[i])
            {
                theSame = false;
            }
        }

        // Assert
        Assert.True(theSame);
    }

    [Fact]
    public void MergeSortFloatsTest()
    {
        // Arrange
        float[] arrayOfFloats = { 7.5f, 7.6f, 7.8f, 7.0f, 7.7f, 7.4f, 7.1f, 7.3f, 7.2f, 7.9f };
        float[] sortedArrayOfFloats = { 7.0f, 7.1f, 7.2f, 7.3f, 7.4f, 7.5f, 7.6f, 7.7f, 7.8f, 7.9f };

        // Act
        MergeSortV1.Sort(arrayOfFloats);
        bool theSame = true;
        for (int i = 0; i < arrayOfFloats.Length; i++)
        {
            if (arrayOfFloats[i] != sortedArrayOfFloats[i])
            {
                theSame = false;
            }
        }

        // Assert
        Assert.True(theSame);
    }

    [Fact]
    public void MergeSortCharsTest()
    {
        // Arrange
        char[] arrayOfChars = { 'i', 'd', 'c', 'b', 'f', 'g', 'a', 'e', 'h', 'j' };
        char[] sortedArrayOfChars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

        // Act
        MergeSortV1.Sort(arrayOfChars);
        bool theSame = true;
        for (int i = 0; i < arrayOfChars.Length; i++)
        {
            if (arrayOfChars[i] != sortedArrayOfChars[i])
            {
                theSame = false;
            }
        }

        // Assert
        Assert.True(theSame);
    }

    [Fact]
    public void MergeSortStringsTest()
    {
        // Arrange
        string[] arrayOfStrings = { "II", "DD", "CC", "BB", "FF", "GG", "AA", "EE", "HH", "JJ" };
        string[] sortedArrayOfStrings = { "AA", "BB", "CC", "DD", "EE", "FF", "GG", "HH", "II", "JJ" };

        // Act
        MergeSortV1.Sort(arrayOfStrings);
        bool theSame = true;
        for (int i = 0; i < arrayOfStrings.Length; i++)
        {
            if (arrayOfStrings[i] != sortedArrayOfStrings[i])
            {
                theSame = false;
            }
        }

        // Assert
        Assert.True(theSame);
    }

    [Fact]
    public void MergeSortPigsTest()
    {
        // Arrange
        Pig pig0 = new Pig("DL6540", new int[] { 1, 1, 0, 1, 0, 0, 2, 1, 1, 1, 2, 1, 2, 0, 0, 2, 1, 0, 1, 1, 1, 2, 1, 2, 2, 2, 0, 2, 0, 2, 2, 0, 2, 2, 2, 2, 2, 1, 2, 1, 2, 2, 0, 2, 1, 1, 1, 0, 0, 2, 2, 2, 0, 0, 2, 2, 2, 1, 1, 1, 0, 1, 1, 1, 2, 2, 0, 0, 1, 1, 0, 2, 2, 1, 0, 0, 2, 2, 0, 2, 1, 1, 2, 1, 0, 0, 2, 1, 0, 1, 0, 0, 0, 1, 1, 2, 2, 1, 0, 1 });
        Pig pig1 = new Pig("DL6541", new int[] { 2, 1, 0, 1, 0, 0, 2, 1, 1, 1, 2, 1, 2, 0, 0, 2, 1, 0, 1, 1, 1, 2, 1, 2, 2, 2, 0, 2, 0, 2, 2, 0, 2, 2, 2, 2, 2, 1, 2, 1, 2, 2, 0, 2, 1, 1, 1, 0, 0, 2, 2, 2, 0, 0, 2, 2, 2, 1, 1, 1, 0, 1, 1, 1, 2, 2, 0, 0, 1, 1, 0, 2, 2, 1, 0, 0, 2, 2, 0, 2, 1, 1, 2, 1, 0, 0, 2, 1, 0, 1, 0, 0, 0, 1, 1, 2, 2, 1, 0, 1 });
        Pig pig2 = new Pig("DL6542", new int[] { 2, 2, 0, 1, 0, 0, 2, 1, 1, 1, 2, 1, 2, 0, 0, 2, 1, 0, 1, 1, 1, 2, 1, 2, 2, 2, 0, 2, 0, 2, 2, 0, 2, 2, 2, 2, 2, 1, 2, 1, 2, 2, 0, 2, 1, 1, 1, 0, 0, 2, 2, 2, 0, 0, 2, 2, 2, 1, 1, 1, 0, 1, 1, 1, 2, 2, 0, 0, 1, 1, 0, 2, 2, 1, 0, 0, 2, 2, 0, 2, 1, 1, 2, 1, 0, 0, 2, 1, 0, 1, 0, 0, 0, 1, 1, 2, 2, 1, 0, 1 });
        Pig pig3 = new Pig("DL6543", new int[] { 2, 2, 1, 1, 0, 0, 2, 1, 1, 1, 2, 1, 2, 0, 0, 2, 1, 0, 1, 1, 1, 2, 1, 2, 2, 2, 0, 2, 0, 2, 2, 0, 2, 2, 2, 2, 2, 1, 2, 1, 2, 2, 0, 2, 1, 1, 1, 0, 0, 2, 2, 2, 0, 0, 2, 2, 2, 1, 1, 1, 0, 1, 1, 1, 2, 2, 0, 0, 1, 1, 0, 2, 2, 1, 0, 0, 2, 2, 0, 2, 1, 1, 2, 1, 0, 0, 2, 1, 0, 1, 0, 0, 0, 1, 1, 2, 2, 1, 0, 1 });
        Pig pig4 = new Pig("DL6544", new int[] { 2, 2, 1, 1, 1, 0, 2, 1, 1, 1, 2, 1, 2, 0, 0, 2, 1, 0, 1, 1, 1, 2, 1, 2, 2, 2, 0, 2, 0, 2, 2, 0, 2, 2, 2, 2, 2, 1, 2, 1, 2, 2, 0, 2, 1, 1, 1, 0, 0, 2, 2, 2, 0, 0, 2, 2, 2, 1, 1, 1, 0, 1, 1, 1, 2, 2, 0, 0, 1, 1, 0, 2, 2, 1, 0, 0, 2, 2, 0, 2, 1, 1, 2, 1, 0, 0, 2, 1, 0, 1, 0, 0, 0, 1, 1, 2, 2, 1, 0, 1 });

        Pig[] arrayOfPigs = new Pig[5];
        arrayOfPigs[0] = pig3;
        arrayOfPigs[1] = pig0;
        arrayOfPigs[2] = pig1;
        arrayOfPigs[3] = pig2;
        arrayOfPigs[4] = pig4;
        Pig[] sortedArrayOfPigs = new Pig[5];
        sortedArrayOfPigs[0] = pig0;
        sortedArrayOfPigs[1] = pig1;
        sortedArrayOfPigs[2] = pig2;
        sortedArrayOfPigs[3] = pig3;
        sortedArrayOfPigs[4] = pig4;

        // Act
        MergeSortV1.Sort(arrayOfPigs);
        bool theSame = true;
        for (int i = 0; i < arrayOfPigs.Length; i++)
        {
            if (arrayOfPigs[i] != sortedArrayOfPigs[i])
            {
                theSame = false;
            }
        }

        // Assert
        Assert.True(theSame);
    }
}