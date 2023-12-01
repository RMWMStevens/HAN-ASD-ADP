using HAN_ASD_ADP.Implementations;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations
{
    public class OrganizerTests
    {
        [Fact]
        public void SortIntegersTest()
        {
            // Arrange
            int[] arrayOfInts = { 5, 6, 8, 0, 7, 4, 1, 3, 2, 9 };
            int[] sortedArrayOfInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            Organizer.SelectionSort(arrayOfInts);
            bool theSame = true;
            for (int i = 0; i < 10; i++)
            {
                if (arrayOfInts[i] != sortedArrayOfInts[i])
                {
                    theSame = false;
                }
            }

            // Assert
            Assert.True(theSame);
        }
    }
}
