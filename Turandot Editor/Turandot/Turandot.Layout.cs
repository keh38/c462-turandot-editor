using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FSMGraph;

namespace Turandot
{
    public class Layout
    {
        public static void CreateGraph(EditorParameters p, GraphViewer graphViewer)
        {
            graphViewer.Graph = new Graph();

            List<LayoutElement> table = CreateLayoutTable(p.flowChart, p.firstState);

            for (int kcol=0; kcol <= table.Select(t=>t.col).Max(); kcol++)
            {
                CreateColumn(table.FindAll(t => t.col == kcol), graphViewer.Graph, graphViewer.Height / 2);
            }

            RefreshBadges(p.flowChart, graphViewer);
            AddEdges(p.flowChart, graphViewer.Graph);

            graphViewer.RefreshNodes(p.firstState, p.schedule.decisionState, p.GetActions());
        }

        public static void RefreshBadges(List<FlowElement> states, GraphViewer graphViewer)
        {
            foreach(FlowElement state in states)
            {
                AddBadges(state, graphViewer);
            }
        }

        public static void AddBadges(FlowElement state, GraphViewer graphViewer)
        {
            graphViewer.ClearBadges(state.name);

            if (state.sigMan != null && state.sigMan.channels.Count > 0) graphViewer.AddBadge(state.name, Badge.BadgeIcon.Sound);
            foreach (Cues.Cue cue in state.cues)
            {
                switch (cue.Name)
                {
                    case "Message":
                    case "Help":
                        graphViewer.AddBadge(state.name, Badge.BadgeIcon.Info);
                        break;

                    case "Fixation point":
                        graphViewer.AddBadge(state.name, Badge.BadgeIcon.Target);
                        break;

                    case "Counter":
                    case "Scoreboard":
                        graphViewer.AddBadge(state.name, Badge.BadgeIcon.Score);
                        break;

                    default:
                        graphViewer.AddBadge(state.name, Badge.BadgeIcon.Light);
                        break;
                }
            }
            if (state.inputs.Count > 0) graphViewer.AddBadge(state.name, Badge.BadgeIcon.Input);
            if (state.endAction != EndAction.None) graphViewer.AddBadge(state.name, Badge.BadgeIcon.Abort);

            graphViewer.Invalidate();
        }

        private static void AddEdges(List<FlowElement> states, Graph g)
        {
            foreach (FlowElement state in states)
            {
                foreach (Termination term in state.term)
                    if (!string.IsNullOrEmpty(term.linkTo))
                    {
                        Edge e = new Edge(term.source, GraphViewer.GetEdgeColor(term.type), term.type);
                        e.SourceEnd = new EdgeEnd(EdgeEnd.EndStyle.Diamond, GraphViewer.GetEdgeColor(term.type), System.Drawing.Color.Yellow);
                        e.TargetEnd = new EdgeEnd(EdgeEnd.EndStyle.Arrow, GraphViewer.GetEdgeColor(term.type), GraphViewer.GetEdgeColor(term.type));
                        g.AddEdge(e, state.name, term.linkTo);
                    }

                foreach (Timeout to in state.timeOuts)
                    if (!string.IsNullOrEmpty(to.linkTo))
                    {
                        Edge e = new Edge("", GraphViewer.GetEdgeColor(to.termType), to.termType);
                        e.SourceEnd = new EdgeEnd(EdgeEnd.EndStyle.Circle, GraphViewer.GetEdgeColor(to.termType), System.Drawing.Color.White);
                        e.TargetEnd = new EdgeEnd(EdgeEnd.EndStyle.Arrow, GraphViewer.GetEdgeColor(to.termType), GraphViewer.GetEdgeColor(to.termType));
                        g.AddEdge(e, state.name, to.linkTo);
                    }
            }
        }

        private static void CreateColumn(List<LayoutElement> column, Graph g, int yc)
        {
            int nodeWidth = 60;
            int nodeHeight = 40;

            int dx = 60;
            int dy = 20;

            int numRows = column.Count;

            int x = column[0].col * (dx + nodeWidth) + nodeWidth/2;
            int columnHeight = numRows * nodeHeight + (numRows - 1) * dy;
            int y = yc - columnHeight / 2 + nodeHeight / 2;

            foreach (LayoutElement cell in column)
            {
                g.AddNode(cell.name, x, y);
                y += nodeHeight + dy;
            }
        }

        private static List<LayoutElement> CreateLayoutTable(List<FlowElement> states, string startAt)
        {
            List<LayoutElement> table = new List<LayoutElement>();

            AddStateToTable(states, startAt, 0, table);

            return table;
        }

        private static void AddStateToTable(List<FlowElement> states, string name, int col, List<LayoutElement> table)
        {
            if (string.IsNullOrEmpty(name) || table.Find(t => t.name == name) != null) return;

            int nextRow = table.FindAll(t => t.col == col).Count;
            table.Add(new LayoutElement(name, nextRow, col));

            FlowElement fe = states.Find(s => s.name == name);
            foreach (Termination term in fe.term) AddStateToTable(states, term.linkTo, col + 1, table);
            foreach (Timeout to in fe.timeOuts) AddStateToTable(states, to.linkTo, col + 1, table);
        }


        public class LayoutElement
        {
            public string name;
            public int row;
            public int col;
            public LayoutElement(string name, int row, int col)
            {
                this.name = name;
                this.row = row;
                this.col = col;
            }
        }

    }
}
