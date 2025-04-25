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
        string fromNode = Console.ReadLine()?.Trim().ToUpper();

        Console.Write("Enter TO node: ");
        string toNode = Console.ReadLine()?.Trim().ToUpper();

        var result = new PathFinder().ShortestPath(fromNode, toNode, graph);

        if (result.NodeNames.Count > 0)
        {
            Console.WriteLine($">fromNodeName = \"{fromNode}\", toNodeName = \"{toNode}\": {string.Join(",", result.NodeNames)}");
            Console.WriteLine($">Total Distance: {result.Distance}");
        }
        else
        {
            Console.WriteLine("No path found.");
        }

        Console.ReadLine();

    }
}
