using System;

namespace HAN_ASD_ADP.Implementations
{
    public class Organizer<T> where T : IComparable<T>
    {
        public void SelectionSort(T[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int indexOfLowestValue = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[j].CompareTo(array[indexOfLowestValue]) < 0)
                    {
                        indexOfLowestValue = j;
                    }
                }
                var placeholder = array[indexOfLowestValue];
                array[indexOfLowestValue] = array[i];
                array[i] = placeholder;
            }
        }
    }
}
