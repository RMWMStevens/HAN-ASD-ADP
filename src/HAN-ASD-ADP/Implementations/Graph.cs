using System;
using System.Collections.Generic;

namespace HAN_ASD_ADP.Implementations;

public class Graph
{
    private Dictionary<string, Vertex> VertexMap = new();

    public Graph(int[,] lineList)
    {
        for (int i = 0; i < lineList.GetLength(0); i++)
        {
            AddVertex(lineList[i, 0].ToString());
            AddVertex(lineList[i, 1].ToString());
        }

        for (int i = 0; i < lineList.GetLength(0); i++)
        {
            int source = lineList[i, 0];
            int dest = lineList[i, 1];
            double cost = lineList[i, 2];
            AddEdge(source.ToString(), dest.ToString(), cost);
        }
    }

    public Graph(int[][][] connectionList)
    {
        for (int i = 0; i < connectionList.GetLength(0); i++)
        {
            AddVertex(i.ToString());
        }

        for (int i = 0; i < connectionList.GetLength(0); i++)
        {
            for (int j = 0; j < connectionList[i].GetLength(0); j++)
            {
                int source = i;
                int dest = connectionList[i][j][0];
                double cost = connectionList[i][j][1];

                AddEdge(source.ToString(), dest.ToString(), cost);
            }
        }

    }

    public Graph(int[][,] jaggedList)
    {
        for (int i = 0; i < jaggedList.GetLength(0); i++)
        {
            AddVertex(i.ToString());
        }

        for (int i = 0; i < jaggedList.Length; i++)
        {
            for (int j = 0; j < jaggedList[i].GetLength(0); j++)
            {
                if (jaggedList[i].GetLength(1) > 0)
                {
                    int source = i;
                    int dest = jaggedList[i][j, 0];
                    double cost = jaggedList[i][j, 1];
                    AddEdge(source.ToString(), dest.ToString(), cost);
                }
            }
        }

    }

    public Graph(int[][] connectionMatrix)
    {
        for (int i = 0; i < connectionMatrix.Length; i++)
        {
            AddVertex(i.ToString());
        }

        for (int i = 0; i < connectionMatrix.Length; i++)
        {
            for (int j = 0; j < connectionMatrix[i].Length; j++)
            {
                if (connectionMatrix[i][j] != 0)
                {
                    int source = i;
                    int dest = j;
                    double cost = connectionMatrix[i][j];
                    AddEdge(source.ToString(), dest.ToString(), cost);
                }
            }
        }
    }

    public void AddVertex(string vertexName)
    {
        if (VertexMap.ContainsKey(vertexName))
            throw new ArgumentException("A vertex with this name already exists.");
        
        Vertex newVertex = new Vertex(vertexName);
        VertexMap.Add(vertexName, newVertex);
    }

    public void AddEdge(string sourceVertexName, string destVertexName, double cost)
    {
        if (!VertexMap.ContainsKey(sourceVertexName) || !VertexMap.ContainsKey(destVertexName))
            throw new ArgumentException("The provided vertices are invalid.");

        Vertex sourceVertex = VertexMap[sourceVertexName];
        Vertex destVertex = VertexMap[destVertexName];

        sourceVertex.AddEdge(destVertex, cost);
    }

    public Dictionary<Vertex, double> DijkstraShortestPath(string startVertexName)
    {
        Dictionary<Vertex, double> distance = new Dictionary<Vertex, double>();
        Dictionary<Vertex, Vertex> previousVertex = new Dictionary<Vertex, Vertex>();
        PriorityQueue<Vertex> priorityQueue = new PriorityQueue<Vertex>();

        foreach (var vertex in VertexMap.Values)
        {
            distance[vertex] = double.PositiveInfinity;
            previousVertex[vertex] = null;
            priorityQueue.Enqueue(vertex, distance[vertex]);
        }

        Vertex startVertex = VertexMap[startVertexName];
        distance[startVertex] = 0;

        while (priorityQueue.Count > 0)
        {
            Vertex currentVertex = priorityQueue.Dequeue();

            foreach (Edge edge in currentVertex.AdjacentEdges)
            {
                double newDistance = distance[currentVertex] + edge.Cost;

                if (newDistance < distance[edge.Destination])
                {
                    distance[edge.Destination] = newDistance;
                    previousVertex[edge.Destination] = currentVertex;
                    priorityQueue.Enqueue(edge.Destination, newDistance);
                }
            }
        }

        return distance;
    }

    public void PrintGraph()
    {
        foreach (var vertexEntry in VertexMap)
        {
            Vertex vertex = vertexEntry.Value;
            Console.Write($"Vertex {vertex.Name}: ");

            foreach (var edge in vertex.AdjacentEdges)
            {
                Console.Write($"({edge.Destination.Name}, {edge.Cost}) ");
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
                display += $"  [{vertex.Name}, {edge.Destination.Name}, {edge.Cost}], \n";
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
                display += $"    [{edge.Destination.Name}, {edge.Cost}]{comma} \n";
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
                matrix[int.Parse(vertex.Name), int.Parse(edge.Destination.Name)] = edge.Cost;
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
}

public class Vertex
{
    public string Name { get; }

    public LinkedList<Edge> AdjacentEdges { get; }

    private double cost;
    private Vertex previousVertexOnShortestPath;

    public Vertex(String name)
    {
        this.Name = name;
        this.AdjacentEdges = new LinkedList<Edge>();
        this.previousVertexOnShortestPath = null;
        this.cost = double.PositiveInfinity;
    }

    public void AddEdge(Vertex dest, double cost)
    {
        Edge newEdge = new Edge(dest, cost);
        AdjacentEdges.AddLast(newEdge);
    }
}

public class Edge
{
    public Vertex Destination { get; }
    public double Cost { get; }

    public Edge(Vertex dest, double cost)
    {
        Destination = dest;
        Cost = cost;
    }
}

public enum PrintLayout
{
    LineList,
    ConnectionList,
    ConnectionMatrix,
}