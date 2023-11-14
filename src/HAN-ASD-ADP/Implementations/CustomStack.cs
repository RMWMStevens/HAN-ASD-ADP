using System;

namespace HAN_ASD_ADP.Implementations
{
    public class CustomStack<T>
    {
        private T[] array;

        public CustomStack()
        {
            array = new T[0];
        }

        public void Push(T item)
        {
            if (IsEmpty())
            {
                array = new T[1];
                array[0] = item;
            }
            else
            {
                T[] newArray = new T[array.Length + 1];
                newArray[0] = item;
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i + 1] = array[i];
                }
                array = newArray;
            }
        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                int newLength = array.Length - 1;
                T[] newArray = new T[newLength];
                for (int i = 0; i < newLength; i++)
                {
                    newArray[i] = array[i + 1];
                }
                array = newArray;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }
        public T Top()
        {
            if (!IsEmpty())
            {
                return array[0];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }

        public Boolean IsEmpty()
        {
            return array.Length == 0;
        }
    }
}
