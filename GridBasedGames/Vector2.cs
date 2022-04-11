namespace GridBasedGames
{
    public struct Vector2
    {
        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public override string ToString() => $"{X},{Y}";
    }

}
