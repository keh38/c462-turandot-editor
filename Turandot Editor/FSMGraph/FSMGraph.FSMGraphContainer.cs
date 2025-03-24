namespace FSMGraph
{
    public class FSMGraphContainer
    {
        public static int Version = 1;
        public int version = 0;
        public GraphViewAttributes attr = null;
        public Graph graph = null;

        public FSMGraphContainer() { }
        public FSMGraphContainer(GraphViewAttributes attr, Graph graph)
        {
            this.version = Version;
            this.attr = attr;
            this.graph = graph;
        }
    }
}