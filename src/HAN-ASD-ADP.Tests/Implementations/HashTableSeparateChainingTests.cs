using HAN_ASD_ADP.Datasets;
using HAN_ASD_ADP.Implementations;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations;

public class HashTableSeparateChainingTests : IAsyncLifetime
{
    private DatasetHashing dataset;

    public async Task InitializeAsync()
        => dataset = await DatasetCache<DatasetHashing>.GetAsync();

    [Fact]
    public void BasicOperationsAdd_Test()
    {
        // Arrange
        var sut = new HashTableChaining<string, int[]>();
        string name = "Roel";
        int[] ints = { 1, 2, 3 };

        // Act
        sut.Add(name, ints);

        // Assert
        Assert.Equal(ints, sut.Get(name));
    }

    [Fact]
    public void BasicOperationsRemove_Test()
    {
        // Arrange
        var sut = new HashTableChaining<string, int[]>();
        string name = "Roel";
        int[] ints = { 1, 2, 3 };
        sut.Add(name, ints);

        // Act
        sut.Delete(name);

        // Assert
        Assert.Throws<KeyNotFoundException>(() => sut.Get(name));
    }

    [Fact]
    public void BasicOperationsUpdateCheckValues_Test()
    {
        // Arrange
        var sut = new HashTableChaining<string, int[]>();
        string name = "Roel";
        int[] originalInts = { 1, 2, 3 };
        int[] updatedInts = { -9, 15, 1779, -983 };
        sut.Add(name, originalInts);

        // Act
        sut.Update(name, updatedInts);

        // Assert
        Assert.Equal(updatedInts, sut.Get(name));
    }

    //[Fact]
    //public void AddDataset_Test()
    //{
    //    // Arrange
    //    var sut = LoadDataset();

    //    // Assert
    //    //Assert.Equal(27, sut.Count);
    //}

    //[Fact]
    //public void CheckValuesOfDataset_Test()
    //{
    //    // Arrange
    //    var sut = LoadDataset();
    //    int[] ints = { 4545, 334344, 45454, 6576, -1 };
    //    bool checkValues = true;

    //    // Act
    //    int index = sut.GetIndex("w");

    //    for (int i = 0; i < ints.Length; i++)
    //    {
    //        if (ints[i] != sut.GetByIndex(index).Value[i])
    //        {
    //            checkValues = false;
    //        };
    //    }

    //    // Assert
    //    Assert.True(checkValues);
    //}

    //private HashTableChaining<string, int> LoadDataset()
    //{
    //    var sut = new HashTableChaining<string, int>(typeof(DatasetHashing).GetProperties().Length);
    //    foreach (PropertyInfo prop in dataset.HashtabelSleutelsWaardes.GetType().GetProperties())
    //    {
    //        string key = prop.Name;
    //        var values = (List<int>)prop.GetValue(dataset.HashtabelSleutelsWaardes);

    //        foreach (var value in values)
    //        {
    //            sut.Add(key, value); // Duplicate keys, throws exception!
    //        }
    //    }
    //    return sut;
    //}

    public Task DisposeAsync() => Task.CompletedTask;
}