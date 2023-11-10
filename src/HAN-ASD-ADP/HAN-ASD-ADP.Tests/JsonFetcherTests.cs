using System.Net.Http;
using System.Threading.Tasks;
using HAN_ASD_ADP.Datasets;
using Xunit;

namespace HAN_ASD_ADP.Tests;

public class JsonFetcherTests
{
    [Fact]
    public async Task FetchJsonAsync_DatasetGrafen_Test()
    {
        // Arrange
        var jsonFetcher = new JsonFetcher(new HttpClient());

        // Act
        var result = await jsonFetcher.FetchJsonAsync<DatasetGrafen>();

        // Assert
        Assert.NotNull(result);
    }

    [Fact]
    public async Task FetchJsonAsync_DatasetHashing_Test()
    {
        // Arrange
        var jsonFetcher = new JsonFetcher(new HttpClient());

        // Act
        var result = await jsonFetcher.FetchJsonAsync<DatasetHashing>();

        // Assert
        Assert.NotNull(result);
    }

    [Fact]
    public async Task FetchJsonAsync_DatasetSorteren_Test()
    {
        // Arrange
        var jsonFetcher = new JsonFetcher(new HttpClient());

        // Act
        var result = await jsonFetcher.FetchJsonAsync<DatasetSorteren>();

        // Assert
        Assert.NotNull(result);
    }
}