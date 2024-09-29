using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForce
{
    public class DFS
    {
        public static void AddEdge(List<List<int>> adj, int s, int t)
        {
            adj[s].Add(t);
            adj[t].Add(s);
        }

        // Recursive function for DFS traversal
        public static void DFSRec(List<List<int>> adj, bool[] visited, int s)
        {
            // Mark the current vertex as visited
            visited[s] = true;

            // Print the current vertex
            Console.Write(s + " ");

            // Recursively visit all adjacent vertices
            // that are not visited yet
            foreach (int i in adj[s])
            {
                if (!visited[i])
                {
                    DFSRec(adj, visited, i);
                }
            }
        }

        // Main DFS function that initializes the visited array
        public static void PerformDFS(List<List<int>> adj, int s)
        {
            bool[] visited = new bool[adj.Count];
            // Call the recursive DFS function
            DFSRec(adj, visited, s);
        }
        }
}
