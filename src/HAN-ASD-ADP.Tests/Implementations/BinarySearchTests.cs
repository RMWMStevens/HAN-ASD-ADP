using HAN_ASD_ADP.Datasets;
using HAN_ASD_ADP.Implementations;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations;


public class BinarySearchTests : IAsyncLifetime
{
    private DatasetSorteren dataset;

    public async Task InitializeAsync()
        => dataset = await DatasetCache<DatasetSorteren>.GetAsync();

    [Theory]
    [InlineData(0, "Kris")]
    [InlineData(1, "Ruud")]
    [InlineData(2, "Stef")]
    [InlineData(3, "Tom")]
    public void ListOfNamesAdd_Test(int index, string name)
    {
        // Arrange
        BinarySearch<string> binarySearch = new BinarySearch<string>();
        List<string> listOfNames = new List<string> { "Stef", "Ruud", "Tom", "Kris" };

        // Act
        foreach (string nameOnList in listOfNames)
        {
            binarySearch.Add(nameOnList);
        }

        // Assert
        Assert.Equal(index, binarySearch.IndexOfLinearSearch(name));
    }

    [Theory]
    [InlineData(0, "Kris")]
    [InlineData(5, "Ruud")]
    [InlineData(9, "Tom")]
    public void ListOfNamesIndexOf_Test(int index, string name)
    {
        // Arrange
        var listOfNames = GetListOfNames();

        // Assert
        Assert.Equal(index, listOfNames.IndexOfLinearSearch(name));
    }

    [Theory]
    [InlineData(0, "Kris")]
    [InlineData(5, "Ruud")]
    [InlineData(9, "Tom")]
    public void ListOfNamesIndexOfBinarySearchRecursive_Test(int index, string name)
    {
        // Arrange
        var listOfNames = GetListOfNames();

        // Assert
        Assert.Equal(index, listOfNames.IndexOfBinarySearchRecursive(name));
    }

    [Theory]
    [InlineData(0, "Kris")]
    [InlineData(2, "Otis")]
    [InlineData(5, "Sophie")]
    public void ListOfNamesRemoveAt_Test(int index, string name)
    {
        // Arrange
        var listOfNames = GetListOfNames();
        listOfNames.RemoveAt(2);

        // Assert
        Assert.Equal(index, listOfNames.IndexOfLinearSearch(name));
    }

    [Theory]
    [InlineData(0, "Kris")]
    [InlineData(2, "Otis")]
    [InlineData(5, "Sophie")]
    public void ListOfNamesSet_Test(int index, string name)
    {
        // Arrange
        var listOfNames = GetListOfNames();
        listOfNames.RemoveAt(2);

        // Assert
        Assert.Equal(index, listOfNames.IndexOfLinearSearch(name));
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(4444, 4443)]
    [InlineData(9999, 9998)]
    public void LijstOplopend10000_Add_Test(int searchFor, int expected)
    {
        // Arrange
        BinarySearch<int> listOfInts = new BinarySearch<int>();

        // Act
        foreach (var value in dataset.LijstOplopend10000)
        {
            listOfInts.Add(value);
        }

        // Assert
        Assert.Equal(expected, listOfInts.IndexOfBinarySearchRecursive(searchFor));
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(4444, 4443)]
    [InlineData(9999, 9998)]
    [InlineData(34, 33)]
    public void LijstWillekeurig10000_Add_Test(int searchFor, int expected)
    {
        // Arrange
        BinarySearch<int> listOfInts = new BinarySearch<int>();

        // Act
        foreach (var value in dataset.LijstWillekeurig10000)
        {
            listOfInts.Add(value);
        }

        // Assert
        Assert.Equal(expected, listOfInts.IndexOfBinarySearchRecursive(searchFor));
    }

    private BinarySearch<string> GetListOfNames()
    {
        BinarySearch<string> binarySearch = new BinarySearch<string>();

        binarySearch.list = new List<string> { "Stef", "Ruud", "Tom", "Kris", "Tim", "Nick", "Otis", "Rosie", "Lola", "Sophie" };
        binarySearch.list.Sort();
        return binarySearch;
    }

    public Task DisposeAsync() => Task.CompletedTask;
}
