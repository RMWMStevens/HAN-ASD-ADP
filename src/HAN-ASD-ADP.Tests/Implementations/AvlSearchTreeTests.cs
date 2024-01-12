using HAN_ASD_ADP.Datasets;
using HAN_ASD_ADP.Implementations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations;

public class AvlSearchTreeTests : IAsyncLifetime
{
    private DatasetSorteren dataset;

    public async Task InitializeAsync()
        => dataset = await DatasetCache<DatasetSorteren>.GetAsync();

    [Fact]
    public void Insert_Test()
    {
        // Arrange
        var tree = LoadFromDataset(dataset.LijstOplopend10000);

        // Act
        tree.Insert(10);

        // Assert
        Assert.True(tree.Find(10));
    }

    [Fact]
    public void FindMin_Test()
    {
        // Arrange
        var tree = LoadFromDataset(dataset.LijstOplopend2);

        // Act
        var min = tree.FindMin();

        // Assert
        Assert.Equal(-100324, min);
    }

    [Fact]
    public void FindMax_Test()
    {
        // Arrange
        var tree = LoadFromDataset(dataset.LijstWillekeurig10000);

        // Act
        var max = tree.FindMax();

        // Assert
        Assert.Equal(9999, max);
    }

    [Fact]
    public void Remove_Test()
    {
        // Arrange
        var tree = LoadFromDataset(dataset.LijstWillekeurig3);

        // Act
        tree.Remove(2);

        // Assert
        Assert.False(tree.Find(2));
    }

    private AvlSearchTree<T> LoadFromDataset<T>(IEnumerable<T> list)
        where T : IComparable<T>
    {
        var tree = new AvlSearchTree<T>();

        foreach (var item in list)
        {
            tree.Insert(item);
        }

        return tree;
    }

    public Task DisposeAsync() => Task.CompletedTask;
}