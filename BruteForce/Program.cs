namespace BruteForce
{
    class Program
    {
        public static void Main(string[] args)
        {
            dfs();
            Console.WriteLine("........................................................");
            bfs();
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

        public static void bfs()
        {
           
            // Number of vertices in the graph
            int V = 5;

            // Adjacency list representation of the graph
            List<List<int>> adj = new List<List<int>>(V);
            for (int i = 0; i < V; i++)
            {
                adj.Add(new List<int>());
            }

            // Add edges to the graph
            BFS.AddEdge(adj, 0, 1);
            BFS.AddEdge(adj, 0, 2);
            BFS.AddEdge(adj, 1, 3);
            BFS.AddEdge(adj, 1, 4);
            BFS.AddEdge(adj, 2, 4);

            // Perform BFS traversal starting from vertex 0
            Console.WriteLine("BFS starting from 0 : ");
            BFS.Bfs(adj, 0);
        }
    }
}