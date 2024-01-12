using HAN_ASD_ADP.Datasets;
using HAN_ASD_ADP.Implementations;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations;

public class GraphTests : IAsyncLifetime
{
    private DatasetGrafen dataset;

    public async Task InitializeAsync()
        => dataset = await DatasetCache<DatasetGrafen>.GetAsync();

    [Fact]
    public void LoadLijnLijst_Test()
    {
        // Arrange
        var graph = new Graph();

        // Act
        graph.LoadLijnlijst(dataset.Lijnlijst);

        // Assert
        Assert.Equal(7, graph.VertexCount);
        Assert.True(graph.HasEdge("0", "1"));
        Assert.True(graph.HasEdge("0", "2"));
        Assert.True(graph.HasEdge("1", "2"));
        Assert.True(graph.HasEdge("1", "3"));
        Assert.True(graph.HasEdge("2", "4"));
        Assert.True(graph.HasEdge("3", "4"));
        Assert.True(graph.HasEdge("4", "5"));
        Assert.True(graph.HasEdge("5", "6"));
    }

    [Fact]
    public void LoadVerbindingsLijst_Test()
    {
        // Arrange
        var graph = new Graph();

        // Act
        graph.LoadVerbindingslijst(dataset.Verbindingslijst);

        // Assert
        Assert.Equal(7, graph.VertexCount);
        Assert.True(graph.HasEdge("0", "1"));
        Assert.True(graph.HasEdge("0", "2"));
        Assert.True(graph.HasEdge("1", "2"));
        Assert.True(graph.HasEdge("1", "3"));
        Assert.True(graph.HasEdge("2", "4"));
        Assert.True(graph.HasEdge("3", "4"));
        Assert.True(graph.HasEdge("4", "5"));
        Assert.True(graph.HasEdge("5", "6"));
    }

    [Fact]
    public void LoadVerbindingsMatrix_Test()
    {
        // Arrange
        var graph = new Graph();

        // Act
        graph.LoadVerbindingsmatrix(dataset.Verbindingsmatrix);

        // Assert
        Assert.Equal(7, graph.VertexCount);
        Assert.True(graph.HasEdge("0", "1"));
        Assert.True(graph.HasEdge("0", "2"));
        Assert.True(graph.HasEdge("1", "2"));
        Assert.True(graph.HasEdge("1", "3"));
        Assert.True(graph.HasEdge("2", "4"));
        Assert.True(graph.HasEdge("3", "4"));
        Assert.True(graph.HasEdge("4", "5"));
        Assert.True(graph.HasEdge("5", "6"));
    }

    [Fact]
    public void LoadLijnLijstGewogen_Test()
    {
        // Arrange
        var graph = new Graph();

        // Act
        graph.LoadLijnlijstGewogen(dataset.LijnlijstGewogen);

        // Arrange
        Assert.True(graph.HasEdge("0", "1", 99));
        Assert.True(graph.HasEdge("0", "2", 50));
        Assert.True(graph.HasEdge("1", "2", 50));
        Assert.True(graph.HasEdge("1", "3", 50));
        Assert.True(graph.HasEdge("1", "4", 50));
        Assert.True(graph.HasEdge("2", "3", 99));
        Assert.True(graph.HasEdge("3", "4", 75));
    }

    [Fact]
    public void LoadVerbindingslijstGewogen_Test()
    {
        // Arrange
        var graph = new Graph();

        // Act
        graph.LoadVerbindingslijstGewogen(dataset.VerbindingslijstGewogen);

        // Arrange
        Assert.True(graph.HasEdge("0", "1", 99));
        Assert.True(graph.HasEdge("0", "2", 50));
        Assert.True(graph.HasEdge("1", "2", 50));
        Assert.True(graph.HasEdge("1", "3", 50));
        Assert.True(graph.HasEdge("1", "4", 50));
        Assert.True(graph.HasEdge("2", "3", 99));
        Assert.True(graph.HasEdge("3", "4", 75));
    }

    [Fact]
    public void LoadVerbindingsMatrixGewogen_Test()
    {
        // Arrange
        var graph = new Graph();

        // Act
        graph.LoadVerbindingsmatrixGewogen(dataset.VerbindingsmatrixGewogen);

        // Arrange
        Assert.True(graph.HasEdge("0", "1", 99));
        Assert.True(graph.HasEdge("0", "2", 50));
        Assert.True(graph.HasEdge("1", "2", 50));
        Assert.True(graph.HasEdge("1", "3", 50));
        Assert.True(graph.HasEdge("1", "4", 50));
        Assert.True(graph.HasEdge("2", "3", 99));
        Assert.True(graph.HasEdge("3", "4", 75));
    }

    [Fact]
    public void FindShortestPathUnweighted_Test()
    {
        // Arrange
        var graph = new Graph();
        graph.LoadLijnlijst(dataset.Lijnlijst);
        var expectedPath = new List<string> { "0", "1", "3" };

        // Act
        var shortestPath = graph.FindShortestPathUnweighted("0", "3");

        // Assert
        Assert.Equal(expectedPath, shortestPath);
    }

    [Fact]
    public void FindShortestPathDijkstra_Test()
    {
        // Arrange
        var graph = new Graph();
        graph.LoadLijnlijst(dataset.LijnlijstGewogen);
        var expectedPath = new List<string> { "0", "1", "4" };

        // Act
        var shortestPath = graph.FindShortestPathDijkstra("0", "4");

        // Assert
        Assert.Equal(expectedPath, shortestPath);
    }

    public Task DisposeAsync() => Task.CompletedTask;
}