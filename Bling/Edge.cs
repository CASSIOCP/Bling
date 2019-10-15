namespace Bling
{
    public class Edge
    {
        public Edge(char v1, char v2, int cost)
        {
            Vertex1 = v1;
            Vertex2 = v2;
            Cost = cost;
        }

        public char Vertex1;
        public char Vertex2;
        public int Cost;
    }
}
