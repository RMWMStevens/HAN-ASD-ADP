using System;
using System.Collections.Generic;

namespace HAN_ASD_ADP.Implementations
{
    public class PriorityQueue<T>
    {
        private List<(T, double)> heap;

        public int Count => heap.Count;

        public PriorityQueue()
        {
            heap = new List<(T, double)>();
        }

        public void Enqueue(T item, double priority)
        {
            heap.Add((item, priority));
            HeapifyUp();
        }

        public T Dequeue()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Priority queue is empty");

            T topItem = heap[0].Item1;
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown();
            return topItem;
        }

        private void HeapifyUp()
        {
            int index = heap.Count - 1;
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (heap[index].Item2 < heap[parentIndex].Item2)
                {
                    Swap(index, parentIndex);
                    index = parentIndex;
                }
                else
                {
                    break;
                }
            }
        }

        private void HeapifyDown()
        {
            int index = 0;
            while (true)
            {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;
                int smallest = index;

                if (leftChild < heap.Count && heap[leftChild].Item2 < heap[smallest].Item2)
                {
                    smallest = leftChild;
                }

                if (rightChild < heap.Count && heap[rightChild].Item2 < heap[smallest].Item2)
                {
                    smallest = rightChild;
                }

                if (smallest != index)
                {
                    Swap(index, smallest);
                    index = smallest;
                }
                else
                {
                    break;
                }
            }
        }

        private void Swap(int i, int j)
        {
            var temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
    }
}
