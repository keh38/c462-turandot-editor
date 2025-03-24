namespace FSMGraph
{
    public class GraphViewAttributes
    {
        public float scale = 1f;
        public float dx = 0;
        public float dy = 0;

        public GraphViewAttributes() { }

        public GraphViewAttributes(float scale, float dx, float dy)
        {
            this.scale = scale;
            this.dx = dx;
            this.dy = dy;
        }
    }
}