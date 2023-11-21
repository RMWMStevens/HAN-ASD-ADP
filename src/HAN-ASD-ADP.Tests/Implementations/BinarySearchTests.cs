using HAN_ASD_ADP.Implementations;
using System.Collections.Generic;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations
{

    public class BinarySearchTests
    {
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

        private BinarySearch<string> GetListOfNames()
        {
            BinarySearch<string> binarySearch = new BinarySearch<string>();

            binarySearch.array = new List<string> { "Stef", "Ruud", "Tom", "Kris", "Tim", "Nick", "Otis", "Rosie", "Lola", "Sophie" };
            binarySearch.array.Sort();
            return binarySearch;
        }
    }
}
