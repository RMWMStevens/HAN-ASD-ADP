using HAN_ASD_ADP.Implementations;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HAN_ASD_ADP.Tests.Implementations
{
    public class HashTableTests
    {
        HashTable<string, int[]> sut = new HashTable<string, int[]>();

        [Fact]
        public void BasicOperationsAdd_Test()
        {
            // Arrange
            string name = "Tom";
            int[] ints = { 1, 2, 3 };

            // Act
            sut.Add(name,ints);

            // Assert
            Assert.Equal(1, sut.Count());
        }

        [Fact]
        public void BasicOperationsRemove_Test()
        {
            // Arrange
            sut.Add("Tom", new int[] { 1, 2, 3 });

            // Act
            sut.Remove("Tom");

            // Assert
            Assert.Equal(0, sut.Count());
        }

        [Fact]
        public void BasicOperationsMultipleAdd_Test()
        {
            // Arrange
            string[] names = new string[] { "Tom", "Ruud", "Stef", "Kris" };
            sut.Add(names[0], new int[] { 59 });
            sut.Add(names[1], new int[] { });
            sut.Add(names[2], new int[] { 1, 1, 0 });
            sut.Add(names[3], new int[] { -1, 2, 3, 12, 668 });
            int correctNames = 0;

            // Act
            foreach(string name in names)
            {
                for (int i = 0; i < sut.table.Length; i++)
                {
                    if (sut.table[i].Key == name)
                    {
                        correctNames++;
                    }
                }
            }

            // Assert
            Assert.Equal(4, correctNames);
        }

        [Fact]
        public void BasicOperationsCheckValues_Test()
        {
            // Arrange
            string name = "Tom";
            int[] ints = { -9, 15, 1779, -983 };
            bool checkValues = true;
            sut.Add(name, ints);
            sut.Add("Ruud", new int[] { });
            sut.Add("Stef", new int[] { 1, 1, 0 });
            sut.Add("Kris", new int[] { -1, 2, 3, 12, 668 });

            // Act
            int index = sut.Get("Tom").index;

            for(int i = 0; i < ints.Length; i++)
            {
                if(ints[i] != sut.table[index].Value[i]) {
                    checkValues = false;
                };
            }

            // Assert
            Assert.True(checkValues);
        }
    }
}
