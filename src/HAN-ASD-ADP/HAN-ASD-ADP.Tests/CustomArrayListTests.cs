using HAN_ASD_ADP.Datasets;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace HAN_ASD_ADP.Tests
{
    public class CustomArrayListTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, -10033224)]
        public async Task CustomArrayList_LijstAflopend2_Add_Test(int index, int expected)
        {
            // Arrange
            var jsonFetcher = new JsonFetcher(new HttpClient());
            CustomArrayList<int> listOfInts = new CustomArrayList<int>();

            // Act
            var datasetSorteren = await jsonFetcher.FetchJsonAsync<DatasetSorteren>();
            foreach (var value in datasetSorteren.LijstAflopend2)
            {
                listOfInts.Add(value);
            }

            // Assert
            Assert.Equal(expected, listOfInts.Get(index));
        }

        [Theory]
        [InlineData(0, -100324)]
        [InlineData(1, 1023)]
        public async Task CustomArrayList_LijstOplopend2_Add_Test(int index, int expected)
        {
            // Arrange
            var jsonFetcher = new JsonFetcher(new HttpClient());
            CustomArrayList<int> listOfInts = new CustomArrayList<int>();

            // Act
            var datasetSorteren = await jsonFetcher.FetchJsonAsync<DatasetSorteren>();
            foreach (var value in datasetSorteren.LijstOplopend2)
            {
                listOfInts.Add(value);
            }

            // Assert
            Assert.Equal(expected, listOfInts.Get(index));
        }

        [Theory]
        [InlineData(0, -0.0)]
        [InlineData(1, 11312312312312.324)]
        [InlineData(2, 1)]
        [InlineData(3, -0.0)]
        [InlineData(7999, -0.0)]
        [InlineData(8000, 0.0)]
        public async Task CustomArrayList_LijstFloat8001_Add_Test(int index, float expected)
        {
            // Arrange
            var jsonFetcher = new JsonFetcher(new HttpClient());
            CustomArrayList<float> listOfFloats = new CustomArrayList<float>();

            // Act
            var datasetSorteren = await jsonFetcher.FetchJsonAsync<DatasetSorteren>();

            foreach (var value in datasetSorteren.LijstFloat8001)
            {
                listOfFloats.Add(value);
            }

            // Assert
            Assert.Equal(expected, listOfFloats.Get(index));
        }

        [Theory]
        [InlineData(2379, 10)]
        [InlineData(2211, 1187)]
        [InlineData(8009, 9998)]
        public async Task CustomArrayList_LijstWillekeurig10000_Find_Test(int searchFor, int expected)
        {
            // Arrange
            var jsonFetcher = new JsonFetcher(new HttpClient());
            CustomArrayList<int> listOfInts = new CustomArrayList<int>();

            // Act
            var datasetSorteren = await jsonFetcher.FetchJsonAsync<DatasetSorteren>();
            foreach (var value in datasetSorteren.LijstWillekeurig10000)
            {
                listOfInts.Add(value);
            }

            var result = listOfInts.Find(searchFor);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2379)]
        [InlineData(1187, 2211)]
        [InlineData(9998, 8009)]
        public async Task CustomArrayList_LijstWillekeurig10000_Set_Test(int index, int expected)
        {
            // Arrange
            var jsonFetcher = new JsonFetcher(new HttpClient());
            CustomArrayList<int> listOfInts = new CustomArrayList<int>();

            // Act
            var datasetSorteren = await jsonFetcher.FetchJsonAsync<DatasetSorteren>();
            foreach (var value in datasetSorteren.LijstWillekeurig10000)
            {
                listOfInts.Add(value);
            }

            listOfInts.Set(index, expected);

            // Assert
            Assert.Equal(expected, listOfInts.Get(index));
        }

        [Theory]
        [InlineData(0, 2)]
        [InlineData(1, 2)]
        public async Task CustomArrayList_LijstOnsorteerbaar3_Remove_Test(int index, int expected)
        {
            // Arrange
            var jsonFetcher = new JsonFetcher(new HttpClient());
            CustomArrayList<object> listOfObjects = new CustomArrayList<object>();

            // Act
            var datasetSorteren = await jsonFetcher.FetchJsonAsync<DatasetSorteren>();
            foreach (var value in datasetSorteren.LijstOnsorteerbaar3)
            {
                listOfObjects.Add(value);
            }

            listOfObjects.Remove(index);

            // Assert
            Assert.Equal(expected, listOfObjects.Count);
        }

        [Theory]
        [InlineData(0, 99980000)]
        public async Task CustomArrayList_LijstWillekeurig10000_RemoveLast100xSlowerThanRemoveFirst_Test(int lowIndex, int highIndex)
        {
            // Arrange
            var jsonFetcher = new JsonFetcher(new HttpClient());
            CustomArrayList<int> listOfInts = new CustomArrayList<int>();

            // Act
            var datasetSorteren = await jsonFetcher.FetchJsonAsync<DatasetSorteren>();
            for (int i = 0; i < 10000; i++)
            {
                foreach (var value in datasetSorteren.LijstWillekeurig10000)
                {
                    listOfInts.Add(value);
                }
            }

            Stopwatch stopwatchLast = Stopwatch.StartNew();
            listOfInts.Remove(highIndex);
            stopwatchLast.Stop();

            Stopwatch stopwatchFirst = Stopwatch.StartNew();
            listOfInts.Remove(lowIndex);
            stopwatchFirst.Stop();

            var removeLastSlowerThanRemoveFirst = (stopwatchLast.ElapsedMilliseconds + 1) * 100 < stopwatchFirst.ElapsedMilliseconds;

            // Assert
            Assert.True(removeLastSlowerThanRemoveFirst);
        }
    }
}
