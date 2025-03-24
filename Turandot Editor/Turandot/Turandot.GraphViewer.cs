using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using FSMGraph;
using KLib.Controls;
using KLib.KGraphics;

namespace Turandot
{
    public class GraphViewer : FSMGraphViewer
    {
        public delegate AvailableTransitions GetTransitionsDelegate(string name);

        public GetTransitionsDelegate OnGetAvailableTransitions = null;

        public GraphViewer() : base()
        {
            defaultNodeName = "State";
        }

        public void RefreshNodes(string first, string target, List<string> actions)
        {
            foreach (Node n in Graph.Nodes)
            {
                Node.NodeShape shape = Node.NodeShape.Default;
                XmlColor color = _attr.nodeColor;

                if (n.Name == first)
                {
                    shape = Node.NodeShape.Start;
                    color = _attr.startColor;
                }
                else if (actions.Contains(n.Name))
                {
                    shape = Node.NodeShape.Action;
                    color = _attr.actionColor;
                }
                else if (n.Outgoing.Count == 0)
                {
                    shape = Node.NodeShape.End;
                    color = _attr.endColor;
                }
                else if (n.Name == target)
                {
                    color = _attr.targetColor;
                }

                n.SetShapeAndColor(shape, color);
            }

            Invalidate();
        }

        protected override void BuildEdgeContextMenu(ContextMenu cm, string nodeName)
        {
            if (OnGetAvailableTransitions == null) return;

            AvailableTransitions available = OnGetAvailableTransitions(nodeName);
            if (available == null) return;

            MenuItem mi = new MenuItem();
            mi.Text = "-";
            cm.MenuItems.Add(mi);

            foreach (TermType termType in Enum.GetValues(typeof(TermType)))
            {
                if (!available.types.Contains(termType)) continue;

                string typeName = EditorParameters.TermTypeToString(termType);
                
                mi = new MenuItem();
                mi.Text = available.types.Count > 1 ? "Insert " + typeName : "Insert";
                mi.Click += insertEdge_Click;

                MenuItem sub_mi = new MenuItem();
                sub_mi.Text = "Timeout";
                sub_mi.Click += insertEdge_Click;
                sub_mi.Tag = termType;
                sub_mi.Enabled = available.IsTimeoutAvailable(termType);
                mi.MenuItems.Add(sub_mi);

                sub_mi = new MenuItem();
                sub_mi.Text = "-";
                mi.MenuItems.Add(sub_mi);

                foreach (string src in available.sources)
                {
                    sub_mi = new MenuItem();
                    sub_mi.Text = src;
                    sub_mi.Click += insertEdge_Click;
                    sub_mi.Tag = termType;

                    sub_mi.Enabled = available.IsSourceAvailable(src, termType);
                    mi.MenuItems.Add(sub_mi);
                }

                cm.MenuItems.Add(mi);
            }

        }

        void insertEdge_Click(object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;

            Edge edge = new Edge(
                mi.Text == "Timeout" ? "" : mi.Text,
                GetEdgeColor((TermType)mi.Tag),
                mi.Tag);

            edge.SourceEnd = new EdgeEnd(
                mi.Text == "Timeout" ? EdgeEnd.EndStyle.Circle : EdgeEnd.EndStyle.Diamond,
                GetEdgeColor((TermType)mi.Tag),
                mi.Text == "Timeout" ? Color.White : Color.Yellow
                );

            edge.TargetEnd = new EdgeEnd(
                EdgeEnd.EndStyle.Arrow,
                GetEdgeColor((TermType)mi.Tag),
                GetEdgeColor((TermType) mi.Tag)
                );

            StartEdgeInsertion(edge);
            Refresh();
        }

        public static Color GetEdgeColor(TermType termType)
        {
            Color c = Color.Black;

            switch (termType)
            {
                case  TermType.CSplus:
                    c = Color.Green;
                    break;

                case TermType.CSminus:
                    c = Color.DarkRed;
                    break;
            }

            return c;
        }

        public void RenameEvent(string oldName, string newName)
        {
            foreach (Edge edge in Graph.Edges.FindAll(e => e.Label.Text == oldName))
            {
                edge.Label.Text = newName;
                edge.LineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            Invalidate();
        }

        public void DeleteEvents(List<string> names)
        {
            foreach (string name in names)
                foreach (Edge edge in Graph.Edges.FindAll(e => e.Label.Text == name))
                {
                    edge.Label.Text = "???";
                    edge.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                }

            Invalidate();
        }

        public void ClearBadges(string name)
        {
            Node node = Graph.FindNode(name);
            if (node != null)
            {
                node.Badges.Clear();
            }
        }

        public void AddBadge(string name, Badge.BadgeIcon icon)
        {
            Node node = Graph.FindNode(name);
            if (node != null)
            {
                node.AddBadge(icon);
            }
        }

        public void ChangeTerminationSource(string nodeName, string target, string oldSource, string newSource)
        {
            Node node = Graph.FindNode(nodeName);
            Edge edge = node.Outgoing.Find(e => e.TargetName == target && e.Label.Text == oldSource);
            if (edge != null)
            {
                edge.Label.Text = newSource;
                edge.LineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }

            Invalidate();
        }

    }
}