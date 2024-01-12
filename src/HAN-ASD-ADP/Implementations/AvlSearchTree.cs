using System;

namespace HAN_ASD_ADP.Implementations;

public class AvlSearchTree<T>
    where T : IComparable<T>
{
    private BinaryNode<T> root;

    public void Insert(T value)
        => root = Insert(root, value);

    public bool Find(T value)
        => Find(root, value) != null;

    public T FindMin()
    {
        if (root == null)
            throw new InvalidOperationException("Tree is empty.");

        return FindMin(root).Value;
    }

    public T FindMax()
    {
        if (root == null)
            throw new InvalidOperationException("Tree is empty.");

        return FindMax(root).Value;
    }

    public void Remove(T value)
        => root = Remove(root, value);

    private BinaryNode<T> Insert(BinaryNode<T> node, T value)
    {
        if (node == null)
            return new BinaryNode<T>(value);

        int compareResult = value.CompareTo(node.Value);
        if (compareResult < 0)
        {
            node.Left = Insert(node.Left, value);
        }
        else if (compareResult > 0)
        {
            node.Right = Insert(node.Right, value);
        }
        else
        {
            return node;
        }

        UpdateHeight(node);
        return Balance(node);
    }

    private static BinaryNode<T> Find(BinaryNode<T> node, T value)
    {
        if (node == null)
            return null;

        int compareResult = value.CompareTo(node.Value);
        if (compareResult < 0)
        {
            return Find(node.Left, value);
        }
        else if (compareResult > 0)
        {
            return Find(node.Right, value);
        }

        return node;
    }

    private static BinaryNode<T> FindMin(BinaryNode<T> node)
    {
        return node.Left == null ? node : FindMin(node.Left);
    }

    private static BinaryNode<T> FindMax(BinaryNode<T> node)
    {
        return node.Right == null ? node : FindMax(node.Right);
    }

    private BinaryNode<T> Remove(BinaryNode<T> node, T value)
    {
        if (node == null)
            return null;

        int compareResult = value.CompareTo(node.Value);
        if (compareResult < 0)
        {
            node.Left = Remove(node.Left, value);
        }
        else if (compareResult > 0)
        {
            node.Right = Remove(node.Right, value);
        }
        else
        {
            if (node.Left == null)
                return node.Right;
            else if (node.Right == null)
                return node.Left;

            node.Value = FindMin(node.Right).Value;
            node.Right = Remove(node.Right, node.Value);
        }

        UpdateHeight(node);
        return Balance(node);
    }

    private void UpdateHeight(BinaryNode<T> node)
    {
        node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
    }

    private static int GetHeight(BinaryNode<T> node)
        => node == null ? 0 : node.Height;

    private int GetBalanceFactor(BinaryNode<T> node)
        => node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);

    private BinaryNode<T> Balance(BinaryNode<T> node)
    {
        if (GetBalanceFactor(node) > 1)
        {
            if (GetBalanceFactor(node.Left) < 0)
            {
                node.Left = RotateLeft(node.Left);
            }
            return RotateRight(node);
        }
        if (GetBalanceFactor(node) < -1)
        {
            if (GetBalanceFactor(node.Right) > 0)
            {
                node.Right = RotateRight(node.Right);
            }
            return RotateLeft(node);
        }
        return node;
    }

    private BinaryNode<T> RotateRight(BinaryNode<T> node)
    {
        BinaryNode<T> left = node.Left;
        BinaryNode<T> leftRight = left.Right;
        left.Right = node;
        node.Left = leftRight;

        UpdateHeight(node);
        UpdateHeight(left);

        return left;
    }

    private BinaryNode<T> RotateLeft(BinaryNode<T> node)
    {
        BinaryNode<T> right = node.Right;
        BinaryNode<T> rightLeft = right.Left;
        right.Left = node;
        node.Right = rightLeft;

        UpdateHeight(right);
        UpdateHeight(right);

        return right;
    }
}

public class BinaryNode<T>
{
    public T Value { get; set; }

    public BinaryNode<T> Left { get; set; }

    public BinaryNode<T> Right { get; set; }

    public int Height { get; set; }

    public BinaryNode(T value)
    {
        Value = value;
    }
}