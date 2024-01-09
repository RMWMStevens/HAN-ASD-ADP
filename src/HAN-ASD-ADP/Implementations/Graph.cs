using System;
using System.Collections.Generic;

namespace HAN_ASD_ADP.Implementations
{
    public class Graph
    {
        public Dictionary<string, Vertex> vertexMap = new Dictionary<string, Vertex>();

        public void FillGraph(int[,] lineList)
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

        public void FillGraph(int[][][] connectionList)
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

        public void FillGraph(int[][,] jaggedList)
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

        public void FillGraph(int[][] connectionMatrix)
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
            if (!vertexMap.ContainsKey(vertexName))
            {
                Vertex newVertex = new Vertex(vertexName);
                vertexMap.Add(vertexName, newVertex);
            }
        }

        public void AddEdge(string sourceVertexName, string destVertexName, double cost)
        {
            if (vertexMap.ContainsKey(sourceVertexName) && vertexMap.ContainsKey(destVertexName))
            {
                Vertex sourceVertex = vertexMap[sourceVertexName];
                Vertex destVertex = vertexMap[destVertexName];

                sourceVertex.AddEdge(destVertex, cost);
            }
            else
            {
                Console.WriteLine("Invalid vertices!");
            }
        }

        public Dictionary<Vertex, double> DijkstraShortestPath(string startVertexName)
        {
            // Initialize data structures for the algorithm
            Dictionary<Vertex, double> distance = new Dictionary<Vertex, double>();
            Dictionary<Vertex, Vertex> previousVertex = new Dictionary<Vertex, Vertex>();
            PriorityQueue<Vertex> priorityQueue = new PriorityQueue<Vertex>();

            // Set initial distances and add vertices to the priority queue
            foreach (var vertex in vertexMap.Values)
            {
                distance[vertex] = double.PositiveInfinity;
                previousVertex[vertex] = null;
                priorityQueue.Enqueue(vertex, distance[vertex]);
            }

            Vertex startVertex = vertexMap[startVertexName];
            distance[startVertex] = 0;

            // Main loop of the algorithm
            while (priorityQueue.Count > 0)
            {
                Vertex currentVertex = priorityQueue.Dequeue();

                foreach (Edge edge in currentVertex.adjacentEdges)
                {
                    double newDistance = distance[currentVertex] + edge.cost;

                    if (newDistance < distance[edge.dest])
                    {
                        distance[edge.dest] = newDistance;
                        previousVertex[edge.dest] = currentVertex;
                        priorityQueue.Enqueue(edge.dest, newDistance);
                    }
                }
            }

            // Return the results (distance and previous vertex) as dictionaries
            return distance;
        }

        public void PrintGraph()
        {
            foreach (var vertexEntry in vertexMap)
            {
                Vertex vertex = vertexEntry.Value;
                Console.Write($"Vertex {vertex.name}: ");

                foreach (var edge in vertex.adjacentEdges)
                {
                    Console.Write($"({edge.dest.name}, {edge.cost}) ");
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
            foreach (var vertexEntry in vertexMap)
            {
                Vertex vertex = vertexEntry.Value;
                foreach (var edge in vertex.adjacentEdges)
                {
                    display += $"  [{vertex.name}, {edge.dest.name}, {edge.cost}], \n";
                }
            }
            display = display.Remove(display.LastIndexOf(","));
            display = display + "\n]";
            Console.WriteLine(display);
        }

        private void PrintAsConnectionList()
        {
            string display = "[";
            foreach (var vertexEntry in vertexMap)
            {
                display += "\n  [\n";
                Vertex vertex = vertexEntry.Value;
                int total = vertex.adjacentEdges.Count;
                int counter = 0;
                foreach (var edge in vertex.adjacentEdges)
                {
                    counter++;
                    string comma = "";
                    if (counter < total)
                    {
                        comma = ",";
                    }
                    display += $"    [{edge.dest.name}, {edge.cost}]{comma} \n";
                }
                display += "  ],";
            }
            display = display.Remove(display.LastIndexOf(","));
            display = display + "\n]";
            Console.WriteLine(display);
        }

        private void PrintAsConnectionMatrix()
        {
            int vertices = vertexMap.Count;
            double[,] matrix = new double[vertices, vertices];
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            foreach (var vertexEntry in vertexMap)
            {
                Vertex vertex = vertexEntry.Value;
                foreach (var edge in vertex.adjacentEdges)
                {
                    matrix[Int32.Parse(vertex.name), Int32.Parse(edge.dest.name)] = edge.cost;
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
            display = display + "\n]";
            Console.WriteLine(display);
        }
    }
}

public enum PrintLayout
{
    LineList,
    ConnectionList,
    ConnectionMatrix,
}