namespace Algorithims
{
    internal class Graph
    {
        Dictionary<int, List<GraphNode>> graph;
        public Graph()
        {
            graph = [];
        }

        public bool AddVertex(int vertex)
        {
            if (!ContainsVertex(vertex))
            {
                graph.Add(vertex, []);
                return true;
            }
            return false;
        }
        private bool ContainsVertex(int value) => graph.ContainsKey(value);

        public bool AddEdge(int vertex1, int vertex2)
        {
            if (ContainsVertex(vertex1) && ContainsVertex(vertex2))
            {
                graph[vertex1].Add(new GraphNode(vertex2));
                graph[vertex2].Add(new GraphNode(vertex1));

                return true;
            }
            return false;
        }

        public void PrintGraph()
        {
            foreach (var vertex in graph)
            {
                Console.Write($"Vertex {vertex.Key}: ");
                foreach (var neighbor in vertex.Value)
                {
                    Console.Write($"{neighbor.GetValue()} ");
                }
                Console.WriteLine();
            }
        }
        internal class GraphNode
        {
            private readonly int value;

            public GraphNode(int value)
            {
                this.value = value;
            }

            public int GetValue() => value;
        }
    }
}