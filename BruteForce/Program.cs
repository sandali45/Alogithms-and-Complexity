namespace BruteForce
{
    class Program
    {
        public static void Main(string[] args)
        {
            dfs();
        }

        public  static void dfs()
        {
            int V = 5;

            // Create an adjacency list for the graph
            List<List<int>> adj = new List<List<int>>(V);
            for (int i = 0; i < V; i++)
            {
                adj.Add(new List<int>());
            }

            // Define the edges of the graph
            int[,] edges = {
            { 1, 2 }, { 1, 0 }, { 2, 0 }, { 2, 3 }, { 2, 4 }
        };

            // Populate the adjacency list with edges
            for (int i = 0; i < edges.GetLength(0); i++)
            {
                DFS.AddEdge(adj, edges[i, 0], edges[i, 1]);
            }

            int source = 1; // Starting vertex for DFS
            Console.WriteLine("DFS from source: " + source);
            DFS.PerformDFS(adj, source);
        }
    }
}