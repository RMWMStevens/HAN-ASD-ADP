﻿using System;

namespace HAN_ASD_ADP.Implementations;

public class DoublyLinkedList<T>
    where T : IComparable<T>
{
    public int Count { get; private set; }

    public DoublyLinkedListNode<T> Head { get; set; }

    public DoublyLinkedListNode<T> Tail { get; set; }

    public DoublyLinkedList()
    {
        Head = new(default);
        Tail = new(default);
        Head.Next = Tail;
        Tail.Previous = Head;
    }

    public void Add(T value)
    {
        var node = new DoublyLinkedListNode<T>(value);

        node.Previous = Tail.Previous;
        node.Next = Tail;
        Tail.Previous.Next = node;
        Tail.Previous = node;
        Count++;
    }

    public bool Contains(T value)
        => IndexOf(value) >= 0;

    public T Get(int index, bool allowFromTail = true)
        => GetNode(index, allowFromTail).Value;

    public int IndexOf(T value)
        => FindNodeWithIndex(value).Index;

    public void Remove(T value)
    {
        var node = FindNodeWithIndex(value).Node;
        if (node is null)
            throw new ArgumentException("Value not found");

        Remove(node);
    }

    public void RemoveAt(int index)
        => Remove(GetNode(index));

    public void Set(int index, T value)
    {
        var node = GetNode(index);
        if (node is null)
            return;
        node.Value = value;
    }

    private DoublyLinkedListNode<T> GetFromHead(int index)
    {
        var node = Head.Next;
        for (var position = 0; position < index; position++)
        {
            node = node.Next;
        }
        return node;
    }

    private DoublyLinkedListNode<T> GetFromTail(int index)
    {
        var node = Tail.Previous;
        for (var position = Count - 1; position > index; position--)
        {
            node = node.Previous;
        }
        return node;
    }

    private void Remove(DoublyLinkedListNode<T> node)
    {
        node.Previous.Next = node.Next;
        node.Next.Previous = node.Previous;
        Count--;
    }

    private (int Index, DoublyLinkedListNode<T> Node) FindNodeWithIndex(T value)
    {
        var node = Head.Next;
        var index = 0;
        while (node is not null && node.Next is not null)
        {
            if (node.Value.Equals(value))
                return (index, node);
            node = node.Next;
            index++;
        }

        return (-1, null);
    }

    private DoublyLinkedListNode<T> GetNode(int index, bool allowFromTail = true)
    {
        if (index >= Count)
            throw new IndexOutOfRangeException();

        return (index > (Count / 2) && allowFromTail)
            ? GetFromTail(index)
            : GetFromHead(index);
    }
}

public class DoublyLinkedListNode<T>
{
    public T Value { get; set; }

    public DoublyLinkedListNode<T> Next { get; set; }

    public DoublyLinkedListNode<T> Previous { get; set; }

    public DoublyLinkedListNode(T value)
        => Value = value;
}