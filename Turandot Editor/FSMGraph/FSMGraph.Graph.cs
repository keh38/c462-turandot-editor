using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using KLib;

namespace FSMGraph
{
    public class Graph
    {
        public List<Node> Nodes = new List<Node>();
        public List<Edge> Edges = new List<Edge>();

        public Graph()
        {
        }

        public void Relink()
        {
            foreach (Edge e in Edges)
            {
                Nodes.Find(n => n.Name == e.SourceName).AddOutgoing(e);
                Nodes.Find(n => n.Name == e.TargetName).AddIncoming(e);
                e.Layout();
            }
        }

        public Node AddNode(int x, int y)
        {
            return AddNode(GetNextNodeName("Node"), x, y);
        }

        public Node AddNodeAutoName(int x, int y, string defaultNodeName)
        {
            return AddNode(GetNextNodeName(defaultNodeName), x, y);
        }

        public Node AddNode(string name, int x, int y)
        {
            Node node = new Node(name);
            node.Center.X = x;
            node.Center.Y = y;
            Nodes.Add(node);
            node.Layout();
            return node;
        }

        public Node FindNode(string name)
        {
            return Nodes.Find(n => n.Name == name);
        }

        public void RenameNode(string oldName, string newName)
        {
            Node n = FindNode(oldName);
            n.Name = newName;
            foreach (Edge e in n.Outgoing)
                if (e.SourceName == oldName) e.SourceName = newName;
            foreach (Edge e in n.Incoming)
                if (e.TargetName == oldName) e.TargetName = newName;
        }

        public void ClearNodeOutgoing(string name)
        {
            Node n = FindNode(name);
            foreach (Edge e in n.Outgoing) Edges.Remove(e);
            n.Outgoing.Clear();
        }

        public void Layout()
        {
            foreach (Node n in Nodes) n.Layout();
        }

        public void Draw(Graphics g, Edge selected)
        {
            foreach (Edge e in Edges) if (e != selected) e.Draw(g);
            foreach (Node n in Nodes) n.Draw(g);
            foreach (Edge e in Edges) if (e != selected) e.DrawEnds(g);

            if (selected != null) selected.DrawSelected(g);
        }

        public string GetNextNodeName(string defaultNodeName)
        {
            int i = Nodes.Count + 1;
            while (Nodes.Find(n => n.Name == defaultNodeName + " " + i) != null)
            {
                ++i;
            }

            return defaultNodeName + " " + i;
        }

        public void RemoveNode(Node n)
        {
            foreach (Edge e in n.Incoming) Edges.Remove(e);
            foreach (Edge e in n.Outgoing) Edges.Remove(e);
            Nodes.Remove(n);
        }

        public Node NodeUnderMouse(Point mousePoint)
        {
            Node nodeUnder = null;
            foreach (Node n in Nodes)
            {
                if (n.BoundingBox.Contains(mousePoint))
                {
                    nodeUnder = n;
                    break;
                }
            }
            return nodeUnder;
        }

        public Port PortUnderMouse(Point mousePoint)
        {
            Port portUnder = null;
            foreach (Node n in Nodes)
            {
                Port p = n.GetPortUnderMouse(mousePoint);
                if (p != null)
                {
                    portUnder = p;
                    break;
                }
            }
            return portUnder;
        }

        public Edge AddEdge(Port source, Port target)
        {
            Edge e = new Edge(source, target);
            Edges.Add(e);

            source.BelongsTo.AddOutgoing(e);
            target.BelongsTo.AddIncoming(e);

            return e;
        }

        public Edge AddEdge(string sourceName, string targetName)
        {
            List<Port> sourcePorts = FindNode(sourceName).Ports;
            List<Port> targetPorts = FindNode(targetName).Ports;

            Port src = null;
            Port targ = null;

            double minDist = double.PositiveInfinity;

            foreach (Port sp in sourcePorts)
                foreach (Port tp in targetPorts)
                {
                    double dist = Geometry.Distance(sp.Location, tp.Location);
                    if (dist < minDist)
                    {
                        minDist = dist;
                        src = sp;
                        targ = tp;
                    }
                }

            Edge e = null;
            if (src != null && targ != null)
            {
                e = AddEdge(src, targ);
            }

            return e;
        }

        public void AddEdge(Edge e, string source, string target)
        {
            List<Port> sourcePorts = FindNode(source).Ports;
            List<Port> targetPorts = FindNode(target).Ports;

            Port src = null;
            Port targ = null;

            double minDist = double.PositiveInfinity;

            foreach (Port sp in sourcePorts)
                foreach (Port tp in targetPorts)
                {
                    double dist = Geometry.Distance(sp.Location, tp.Location);
                    if (dist < minDist)
                    {
                        minDist = dist;
                        src = sp;
                        targ = tp;
                    }
                }

            AddEdge(e, src, targ);
        }

        public void AddEdge(Edge e, Port source, Port target)
        {
            e.AssignPorts(source, target);

            source.BelongsTo.AddOutgoing(e);
            target.BelongsTo.AddIncoming(e);

            Edges.Add(e);
        }

        public void RemoveEdge(Edge edgeToRemove)
        {
            Nodes.Find(n => n.Name == edgeToRemove.SourceName).RemoveOutgoing(edgeToRemove);
            Nodes.Find(n => n.Name == edgeToRemove.TargetName).RemoveIncoming(edgeToRemove);
            Edges.Remove(edgeToRemove);
        }

        public Edge EdgeUnderMouse(Point mousePoint)
        {
            Edge edgeUnder = null;
            foreach (Edge e in Edges)
            {
                if (e.HitTest(mousePoint))
                {
                    edgeUnder = e;
                    break;
                }
            }
            return edgeUnder;
        }

    }
}
