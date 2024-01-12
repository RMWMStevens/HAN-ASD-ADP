using System;
using System.Collections.Generic;
using System.Linq;

namespace HAN_ASD_ADP.Implementations;

public class Graph
{
    public int VertexCount => VertexMap.Count;

    private readonly Dictionary<string, Vertex> VertexMap = new();
    private const int DefaultWeight = 1;

    #region Loaders
    public void LoadLijnlijst(int[][] edges)
    {
        foreach (var edge in edges)
        {
            TryAddVertex(edge[0].ToString());
            TryAddVertex(edge[1].ToString());
            AddEdge(edge[0].ToString(), edge[1].ToString(), DefaultWeight);
        }
    }

    public void LoadVerbindingslijst(int[][] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            TryAddVertex(i.ToString());
            foreach (int neighbor in list[i])
            {
                TryAddVertex(neighbor.ToString());
                AddEdge(i.ToString(), neighbor.ToString(), DefaultWeight);
            }
        }
    }

    public void LoadVerbindingsmatrix(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            TryAddVertex(i.ToString());
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] != 0)
                {
                    TryAddVertex(j.ToString());
                    AddEdge(i.ToString(), j.ToString(), DefaultWeight);
                }
            }
        }
    }

    public void LoadLijnlijstGewogen(int[][] edges)
    {
        foreach (var edge in edges)
        {
            TryAddVertex(edge[0].ToString());
            TryAddVertex(edge[1].ToString());
            AddEdge(edge[0].ToString(), edge[1].ToString(), edge[2]);
        }
    }

    public void LoadVerbindingslijstGewogen(int[][][] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            TryAddVertex(i.ToString());
            foreach (var neighbor in list[i])
            {
                TryAddVertex(neighbor[0].ToString());
                AddEdge(i.ToString(), neighbor[0].ToString(), neighbor[1]);
            }
        }
    }

    public void LoadVerbindingsmatrixGewogen(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            TryAddVertex(i.ToString());
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] != 0)
                {
                    TryAddVertex(j.ToString());
                    AddEdge(i.ToString(), j.ToString(), matrix[i][j]);
                }
            }
        }
    }
    #endregion Loaders

    public bool TryAddVertex(string vertexName)
    {
        if (!VertexMap.ContainsKey(vertexName))
        {
            Vertex newVertex = new Vertex(vertexName);
            VertexMap.Add(vertexName, newVertex);
            return true;
        }
        return false;
    }

    public void AddEdge(string sourceVertexName, string destVertexName, double weight)
    {
        if (!VertexMap.ContainsKey(sourceVertexName) || !VertexMap.ContainsKey(destVertexName))
            throw new ArgumentException("The provided vertices are invalid.");

        Vertex sourceVertex = VertexMap[sourceVertexName];
        Vertex destVertex = VertexMap[destVertexName];

        sourceVertex.AddEdge(destVertex, weight);
    }

    public bool HasEdge(string sourceVertexName, string destVertexName, double weight = DefaultWeight)
    {
        if (!VertexMap.ContainsKey(sourceVertexName) || !VertexMap.ContainsKey(destVertexName))
            return false;

        Vertex sourceVertex = VertexMap[sourceVertexName];
        Edge adjacentEdge = sourceVertex.AdjacentEdges.FirstOrDefault(edge => edge.Destination.Name == destVertexName);
        return adjacentEdge is not null && adjacentEdge.Weight == weight;
    }

    public List<string> FindShortestPathUnweighted(string startVertexName, string endVertexName)
    {
        if (!VertexMap.ContainsKey(startVertexName) || !VertexMap.ContainsKey(endVertexName))
            throw new ArgumentException("Start or end vertex not found.");

        ResetVertices();

        Queue<Vertex> queue = new();
        Vertex startVertex = VertexMap[startVertexName];
        startVertex.Distance = 0;
        queue.Enqueue(startVertex);

        while (queue.Count > 0)
        {
            Vertex currentVertex = queue.Dequeue();
            foreach (Edge edge in currentVertex.AdjacentEdges)
            {
                Vertex adjacentVertex = edge.Destination;
                if (adjacentVertex.Distance == double.PositiveInfinity)
                {
                    adjacentVertex.Distance = currentVertex.Distance + 1;
                    adjacentVertex.PreviousVertexOnShortestPath = currentVertex;
                    queue.Enqueue(adjacentVertex);
                }
            }
        }

        return BuildPath(VertexMap[endVertexName]);
    }

    public List<string> FindShortestPathDijkstra(string startVertexName, string endVertexName)
    {
        if (!VertexMap.ContainsKey(startVertexName) || !VertexMap.ContainsKey(endVertexName))
            throw new ArgumentException("Start or end vertex not found.");

        var priorityQueue = new PriorityQueue<Vertex, double>();
        ResetVertices();

        Vertex startVertex = VertexMap[startVertexName];
        startVertex.Distance = 0;
        priorityQueue.Enqueue(startVertex, startVertex.Distance);

        while (priorityQueue.Count > 0)
        {
            Vertex currentVertex = priorityQueue.Dequeue();

            if (currentVertex.Name == endVertexName)
                break;

            foreach (Edge edge in currentVertex.AdjacentEdges)
            {
                Vertex adjacentVertex = edge.Destination;
                double weightedDistance = currentVertex.Distance + edge.Weight;

                if (weightedDistance < adjacentVertex.Distance)
                {
                    adjacentVertex.Distance = weightedDistance;
                    adjacentVertex.PreviousVertexOnShortestPath = currentVertex;
                    priorityQueue.Enqueue(adjacentVertex, adjacentVertex.Distance);
                }
            }
        }

        return BuildPath(VertexMap[endVertexName]);
    }

    private void ResetVertices()
    {
        foreach (var vertex in VertexMap.Values)
        {
            vertex.Distance = double.PositiveInfinity;
            vertex.PreviousVertexOnShortestPath = null;
        }
    }

    private static List<string> BuildPath(Vertex endVertex)
    {
        List<string> path = new();
        while (endVertex != null)
        {
            path.Add(endVertex.Name);
            endVertex = endVertex.PreviousVertexOnShortestPath;
        }

        path.Reverse();
        return path;
    }

    #region Prints
    public void PrintGraph()
    {
        foreach (var vertexEntry in VertexMap)
        {
            Vertex vertex = vertexEntry.Value;
            Console.Write($"Vertex {vertex.Name}: ");

            foreach (var edge in vertex.AdjacentEdges)
            {
                Console.Write($"({edge.Destination.Name}, {edge.Weight}) ");
            }

            Console.WriteLine();
        }
    }

    public void PrintAs(PrintLayout layout)
    {
        switch (layout)
        {
            case PrintLayout.LineList:
                PrintAsLineList();
                break;
            case PrintLayout.ConnectionList:
                PrintAsConnectionList();
                break;
            case PrintLayout.ConnectionMatrix:
                PrintAsConnectionMatrix();
                break;
            default:
                PrintAsLineList();
                break;
        }
    }

    private void PrintAsLineList()
    {
        string display = "[\n";
        foreach (var vertexEntry in VertexMap)
        {
            Vertex vertex = vertexEntry.Value;
            foreach (var edge in vertex.AdjacentEdges)
            {
                display += $"  [{vertex.Name}, {edge.Destination.Name}, {edge.Weight}], \n";
            }
        }
        display = display.Remove(display.LastIndexOf(","));
        display = display + "\n]";
        Console.WriteLine(display);
    }

    private void PrintAsConnectionList()
    {
        string display = "[";
        foreach (var vertexEntry in VertexMap)
        {
            display += "\n  [\n";
            Vertex vertex = vertexEntry.Value;
            int total = vertex.AdjacentEdges.Count;
            int counter = 0;
            foreach (var edge in vertex.AdjacentEdges)
            {
                counter++;
                string comma = "";
                if (counter < total)
                {
                    comma = ",";
                }
                display += $"    [{edge.Destination.Name}, {edge.Weight}]{comma} \n";
            }
            display += "  ],";
        }
        display = display.Remove(display.LastIndexOf(","));
        display += "\n]";
        Console.WriteLine(display);
    }

    private void PrintAsConnectionMatrix()
    {
        int vertices = VertexMap.Count;
        double[,] matrix = new double[vertices, vertices];
        for (int i = 0; i < vertices; i++)
        {
            for (int j = 0; j < vertices; j++)
            {
                matrix[i, j] = 0;
            }
        }

        foreach (var vertexEntry in VertexMap)
        {
            Vertex vertex = vertexEntry.Value;
            foreach (var edge in vertex.AdjacentEdges)
            {
                matrix[int.Parse(vertex.Name), int.Parse(edge.Destination.Name)] = edge.Weight;
            }
        }


        string display = "[\n";
        for (int i = 0; i < vertices; i++)
        {
            display += "[";
            for (int j = 0; j < vertices; j++)
            {
                string comma = ",";
                if (j == vertices - 1)
                {
                    comma = "";
                }
                double value = matrix[i, j];
                string sValue = value + comma;
                sValue = sValue.PadRight(3, ' ');
                display += sValue + " ";
            }
            display += "],\n";
        }
        display = display.Remove(display.LastIndexOf(","));
        display += "\n]";
        Console.WriteLine(display);
    }
    #endregion Prints
}

public class Vertex
{
    public string Name { get; }

    public LinkedList<Edge> AdjacentEdges { get; }

    public double Distance { get; set; }

    public Vertex PreviousVertexOnShortestPath { get; set; }

    public Vertex(string name)
    {
        Name = name;
        AdjacentEdges = new LinkedList<Edge>();
        Distance = double.PositiveInfinity;
        PreviousVertexOnShortestPath = null;
    }

    public void AddEdge(Vertex dest, double weight)
    {
        Edge newEdge = new(dest, weight);
        AdjacentEdges.AddLast(newEdge);
    }
}

public class Edge
{
    public Vertex Destination { get; }

    public double Weight { get; }

    public Edge(Vertex dest, double weight)
    {
        Destination = dest;
        Weight = weight;
    }
}

public enum PrintLayout
{
    LineList,
    ConnectionList,
    ConnectionMatrix,
}