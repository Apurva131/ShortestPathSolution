using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShortestPath.Core.Algorithms;
using ShortestPath.Core.Data;

namespace ShortestPath.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Nodes = GraphSeeder.GetGraph().Select(n => n.Name).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string fromNode, string toNode)
        {
            var graph = GraphSeeder.GetGraph();
            var result = new PathFinder().ShortestPath(fromNode, toNode, graph);

            ViewBag.Nodes = graph.Select(n => n.Name).ToList();
            ViewBag.Path = string.Join(", ", result.NodeNames);
            ViewBag.Distance = result.Distance;
            ViewBag.From = fromNode;
            ViewBag.To = toNode;
            ViewBag.Path = string.Join(",", result.NodeNames);
            ViewBag.Distance = result.Distance;

            return View();
        }
    }
}
