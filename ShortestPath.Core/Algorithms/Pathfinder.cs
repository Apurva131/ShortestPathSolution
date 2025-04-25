using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShortestPath.Core.Models;
using ShortestPath.Core.DTO;

namespace ShortestPath.Core.Algorithms
{
    public class PathFinder
    {
        public ShortestPathData ShortestPath(string fromNode, string toNode, List<Node> nodes)
        {
            var distances = new Dictionary<string, int>();
            var previous = new Dictionary<string, string>();
            var visited = new HashSet<string>();
            var queue = new SortedSet<(int distance, string node)>();

            foreach (var node in nodes)
                distances[node.Name] = int.MaxValue;

            distances[fromNode] = 0;
            queue.Add((0, fromNode));

            while (queue.Any())
            {
                var (currentDistance, currentNode) = queue.Min;
                queue.Remove(queue.Min);

                if (visited.Contains(currentNode))
                    continue;

                visited.Add(currentNode);

                var node = nodes.First(n => n.Name == currentNode);
                foreach (var edge in node.Edges)
                {
                    var newDist = currentDistance + edge.Distance;
                    if (newDist < distances[edge.ToNode])
                    {
                        distances[edge.ToNode] = newDist;
                        previous[edge.ToNode] = currentNode;
                        queue.Add((newDist, edge.ToNode));
                    }
                }
            }

            var path = new List<string>();
            var curr = toNode;
            while (previous.ContainsKey(curr))
            {
                path.Insert(0, curr);
                curr = previous[curr];
            }

            if (curr == fromNode)
            {
                path.Insert(0, fromNode);
                return new ShortestPathData
                {
                    NodeNames = path,
                    Distance = distances[toNode]
                };
            }

            return new ShortestPathData(); // No path found
        }
    }
}

