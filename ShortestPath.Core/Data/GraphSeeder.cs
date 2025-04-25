using ShortestPath.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath.Core.Data
{
    public static class GraphSeeder
    {
        public static List<Node> GetGraph()
        {
            return new List<Node>
            {
                new Node { Name = "A", Edges = new List<Edge>
                    {
                        new Edge { ToNode = "B", Distance = 4 },
                        new Edge { ToNode = "C", Distance = 6 }
                    }
                },
                new Node { Name = "B", Edges = new List<Edge>
                    {
                        new Edge { ToNode = "F", Distance = 2 }
                    }
                },
                new Node { Name = "C", Edges = new List<Edge>
                    {
                        new Edge { ToNode = "D", Distance = 8 }
                    }
                },
                new Node { Name = "D", Edges = new List<Edge>
                    {
                        new Edge { ToNode = "G", Distance = 1 }
                    }
                },
                new Node { Name = "E", Edges = new List<Edge>
                    {
                        new Edge { ToNode = "B", Distance = 2 },
                        new Edge { ToNode = "F", Distance = 3 },
                        new Edge { ToNode = "G", Distance = 4 }
                    }
                },
                new Node { Name = "F", Edges = new List<Edge>
                    {
                        new Edge { ToNode = "H", Distance = 6 }
                    }
                },
                new Node { Name = "G", Edges = new List<Edge>
                    {
                        new Edge { ToNode = "H", Distance = 5 },
                        new Edge { ToNode = "I", Distance = 8 }
                    }
                },
                new Node { Name = "H", Edges = new List<Edge>
                    {
                        new Edge { ToNode = "F", Distance = 6 }
                    }
                },
                new Node { Name = "I", Edges = new List<Edge>()
                    // No outgoing edges from I
                }
            };
        }
    }
}
