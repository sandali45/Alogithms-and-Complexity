using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForce
{
    public class BFS
    {
        public static void Bfs(List<List<int>> adj, int s)
        {

            // Create a queue for BFS
            Queue<int> q = new Queue<int>();

            // Mark all the vertices as not visited
            bool[] visited = new bool[adj.Count];

            // Mark the source node as visited and enqueue it
            visited[s] = true;
            q.Enqueue(s);

            // Iterate over the queue
            while (q.Count > 0)
            {

                // Dequeue a vertex from queue and print it
                int curr = q.Dequeue();
                Console.Write(curr + " ");

                // Get all adjacent vertices of the dequeued vertex
                // If an adjacent has not been visited, 
                // mark it visited and enqueue it
                foreach (int x in adj[curr])
                {
                    if (!visited[x])
                    {
                        visited[x] = true;
                        q.Enqueue(x);
                    }
                }
            }
        }

        // Function to add an edge to the graph
        public static void AddEdge(List<List<int>> adj,
                            int u, int v)
        {
            adj[u].Add(v);
            adj[v].Add(u);
        }

    }
}
