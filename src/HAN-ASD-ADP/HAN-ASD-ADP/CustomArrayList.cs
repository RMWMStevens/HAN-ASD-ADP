using System;

namespace HAN_ASD_ADP
{
    public class CustomArrayList<T>
    {
        private T[] array;
        private int count;
        private const int DefaultCapacity = 4;

        public CustomArrayList()
        {
            array = new T[DefaultCapacity];
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        private void ResizeArray(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        private void ExpandArray()
        {
            int newCapacity = array.Length * 2;
            ResizeArray(newCapacity);
        }

        private void ShrinkArray()
        {
            int newCapacity = array.Length / 2;
            ResizeArray(newCapacity);
        }

        public void Add(T item)
        {
            if (count == array.Length)
            {
                ExpandArray();
            }

            array[count] = item;
            count++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }

            count--;

            if (count < array.Length / 2 && array.Length > DefaultCapacity)
            {
                ShrinkArray();
            }
        }

        public bool Equals(object obj)
        {
            return Equals(obj as CustomArrayList<T>);
        }

        public int Find(T t)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(t))
                {
                    return i;
                };
            }
            return -1;
        }

        public void Set(int index, T value)
        {
            array[index] = value;
        }

        public T Get(int index)
        {
            return array[index];
        }
    }
}
