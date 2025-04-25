using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShortestPath.Core.Algorithms;
using ShortestPath.Core.Data;

class Program
{
    static void Main()
    {
        var graph = GraphSeeder.GetGraph();

        Console.Write("Enter FROM node: ");
        var from = Console.ReadLine();

        Console.Write("Enter TO node: ");
        var to = Console.ReadLine();

        var result = new PathFinder().ShortestPath(from, to, graph);

        if (result.NodeNames.Count > 0)
        {
            Console.WriteLine($"Path: {string.Join(", ", result.NodeNames)}");
            Console.WriteLine($"Total Distance: {result.Distance}");
        }
        else
        {
            Console.WriteLine("No path found.");
        }

        Console.ReadLine();
    }
}
