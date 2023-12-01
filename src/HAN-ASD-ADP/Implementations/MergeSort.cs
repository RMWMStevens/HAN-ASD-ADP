using System;

namespace HAN_ASD_ADP.Implementations
{
    public static class MergeSort
    {
        public static void Sort<T>(T[] inputArray) where T : IComparable<T>
        {
            int inputLenth = inputArray.Length;
            if(inputLenth < 2)
            {
                return;
            }
            int midIndex = inputArray.Length / 2;
            T[] leftHalf = new T[midIndex];
            T[] rightHalf = new T[inputLenth - midIndex];

            for(int i = 0; i < midIndex; i++)
            {
                leftHalf[i] = inputArray[i];
            }

            for (int i = midIndex; i < inputLenth; i++)
            {
                rightHalf[i - midIndex] = inputArray[i];
            }

            Sort(leftHalf);
            Sort(rightHalf);

            Merge(inputArray, leftHalf, rightHalf);
        }

        private static void Merge<T>(T[] inputArray, T[] leftHalf, T[] rightHalf) where T : IComparable<T>
        {
            int leftLength = leftHalf.Length;
            int rightLength = rightHalf.Length;
            int i = 0; // leftHalf
            int j = 0; // rightHalf
            int k = 0; // merged

            while(i < leftLength && j < rightLength)
            {
                if (leftHalf[i].CompareTo(rightHalf[j]) <= 0)
                {
                    inputArray[k] = leftHalf[i];
                    i++;
                } else
                {
                    inputArray[k] = rightHalf[j];
                    j++;
                }
                k++;
            }

            while(i < leftLength)
            {
                inputArray[k] = leftHalf[i];
                i++;
                k++;
            }

            while (j < rightLength)
            {
                inputArray[k] = rightHalf[j];
                j++;
                k++;
            }
        }
    }
}
