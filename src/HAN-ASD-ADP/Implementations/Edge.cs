namespace HAN_ASD_ADP.Implementations
{
    public class Edge
    {
        public Vertex dest { get; } // Second vertex in edge
        public double cost { get; }
        public Edge(Vertex dest, double cost)
        {
            this.dest = dest;
            this.cost = cost;

        }
    }
}
