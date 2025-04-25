using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShortestPath.Core.Algorithms;
using ShortestPath.Core.Data;
using ShortestPath.Core.DTO;
using ShortestPath.Core.Models; // If your DTO is here

namespace ShortestPath.Tests
{
    [TestClass]
    public class PathFinderTests
    {
        private PathFinder pathFinder;
        private List<Node> graph;

        [TestInitialize]
        public void Setup()
        {
            pathFinder = new PathFinder();
            graph = GraphSeeder.GetGraph();
        }

        [TestMethod]
        public void TestShortestPath_AtoD()
        {
            var graph = GraphSeeder.GetGraph();
            var from = "A";
            var to = "D";

            var result = pathFinder.ShortestPath(from, to, graph);

            var expectedPath = new List<string> { "A", "C", "D" }; // Based on your graph
            var expectedDistance = 14;

            // Print like example format

            Console.WriteLine($"Expected Path: {string.Join(",", expectedPath)}");
            Console.WriteLine(expectedDistance);
            Console.WriteLine($">fromNodeName = \"{from}\", toNodeName = \"{to}\": {string.Join(",", result.NodeNames)}");
            Console.WriteLine($">Total Distance: {result.Distance}");

            CollectionAssert.AreEqual(expectedPath, result.NodeNames);
            Assert.AreEqual(expectedDistance, result.Distance);
        }

    }
}
