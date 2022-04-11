namespace GridBasedGames
{
    public class Cell
    {
        public Cell(Vector2 gridPosition)
        {
            GridPosition = gridPosition;
        }

        public Vector2 GridPosition { get; set; }
        public string DefaultCharacters { get; set; } = ".";
        public string CurrentCharacters { get; set; } = ".";
    }
}
