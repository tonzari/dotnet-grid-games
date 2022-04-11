namespace GridBasedGames
{
    public class GameObject
    {
        public Vector2 Position { get; set; }
        public string DefaultCharacter { get; set; }
        public string[,] ArtMatrix { get; set; }

        public void MoveTo(Vector2 targetPosition)
        {
            Position = targetPosition;
        }
    }
}
