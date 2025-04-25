using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShortestPath.Core.Algorithms;
using ShortestPath.Core.Data;

[TestClass]
public class PathFinderTests
{
    [TestMethod]
    public void TestShortestPath_AtoD()
    {
        var graph = GraphSeeder.GetGraph();
        var result = new PathFinder().ShortestPath("A", "D", graph);

        CollectionAssert.AreEqual(new List<string> { "A", "B", "C", "D" }, result.NodeNames);
        Assert.AreEqual(10, result.Distance);
    }
}
