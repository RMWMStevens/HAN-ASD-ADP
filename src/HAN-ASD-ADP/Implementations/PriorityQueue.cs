using System;
using System.Collections.Generic;
using System.Linq;

namespace HAN_ASD_ADP.Implementations;

public class PriorityQueue<T>
    where T : IComparable<T>
{
    private readonly List<T> list = new();

    public void Add(T value)
        => list.Add(value);

    public T DeleteMin()
    {
        if (!list.Any())
            throw new InvalidOperationException("Queue is empty.");

        var min = FindMin();
        list.Remove(min);
        return min;
    }

    public T FindMin()
        => list.Min();
}