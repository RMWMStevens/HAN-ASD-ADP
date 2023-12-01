using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAN_ASD_ADP.Implementations
{
    public static class Organizer
    {
        public static void SelectionSort(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int indexOfLowestValue = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] < array[indexOfLowestValue])
                    {
                        indexOfLowestValue = j;
                    }
                }
                int placeholder = array[indexOfLowestValue];
                array[indexOfLowestValue] = array[i];
                array[i] = placeholder;
            }
        }
    }
}
