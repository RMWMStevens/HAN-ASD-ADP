using System;
using System.Collections.Generic;

namespace HAN_ASD_ADP.Implementations
{
    public class Vertex
    {
        public string name { get; }
        public LinkedList<Edge> adjacentEdges { get; }
        private double cost;
        private Vertex previousVertexOnShortestPath;

        public Vertex(String name)
        {
            this.name = name;
            this.adjacentEdges = new LinkedList<Edge>();
            this.previousVertexOnShortestPath = null;
            this.cost = double.PositiveInfinity;
        }

        public void AddEdge(Vertex dest, double cost)
        {
            Edge newEdge = new Edge(dest, cost);
            adjacentEdges.AddLast(newEdge);
        }
    }
}
