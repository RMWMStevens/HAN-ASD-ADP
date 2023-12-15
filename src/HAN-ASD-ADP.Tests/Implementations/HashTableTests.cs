using HAN_ASD_ADP.Implementations;
using Newtonsoft.Json;
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

        [Fact]
        public void AddDataSet_Test()
        {
            // Act Arrange
            LoadDataSet();

            // Assert
            Assert.Equal(27, sut.Count());
        }

        [Fact]
        public void CheckValuesOfDataSet_Test()
        {
            // Arrange
            int[] ints = { 4545, 334344, 45454, 6576, -1 };
            LoadDataSet();
            bool checkValues = true;

            // Act
            int index = sut.Get("w").index;

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] != sut.table[index].Value[i])
                {
                    checkValues = false;
                };
            }

            // Assert
            Assert.True(checkValues);
        }

        private void LoadDataSet()
        {
            string jsonData = @"
        {
            ""a"": [0],
            ""b"": [1],
            ""c"": [2],
            ""d"": [3, 4],
            ""e"": [],
            ""f"": [],
            ""g"": [],
            ""h"": [],
            ""i"": [],
            ""j"": [2],
            ""k"": [2],
            ""l"": [2],
            ""m"": [2],
            ""n"": [2],
            ""o"": [2],
            ""p"": [4545],
            ""q"": [4545],
            ""r"": [4545],
            ""s"": [4545],
            ""t"": [4545],
            ""u"": [4545, 4233],
            ""v"": [4545],
            ""w"": [4545, 334344, 45454, 6576, -1],
            ""x"": [4545],
            ""y"": [4545],
            ""z"": [4545],
            ""z0"": [99]
        }";
            var keyValuePairs = JsonConvert.DeserializeObject<Dictionary<string, int[]>>(jsonData);
            foreach (var kvp in keyValuePairs)
            {
                sut.Add(kvp.Key, kvp.Value);
            }

        }
    }
}
