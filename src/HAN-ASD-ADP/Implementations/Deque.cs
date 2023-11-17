using System;
using System.Collections.Generic;

namespace HAN_ASD_ADP.Implementations;

/// <summary>
/// Double-Ended Queue
/// </summary>
/// <typeparam name="T"></typeparam>
public class Deque<T>
{
    private readonly LinkedList<T> list = new();

    public T DequeueLeft()
    {
        if (list.Count == 0)
            throw new InvalidOperationException("Deque is empty");

        var value = list.First.Value;
        list.RemoveFirst();
        return value;
    }

    public T DequeueRight()
    {
        if (list.Count == 0)
            throw new InvalidOperationException("Deque is empty");

        var value = list.Last.Value;
        list.RemoveLast();
        return value;
    }

    public void EnqueueLeft(T value) => list.AddFirst(value);

    public void EnqueueRight(T value) => list.AddLast(value);

    public bool IsEmpty() => list.Count == 0;

    public int Size() => list.Count;
}