namespace Adapter
{
    public class SpecificPlayer : ISpecificPlayer
    {
        private Player player;

        public string GetSpecificPlayer()
        {
            player = new Player("Jan", "Kowalski", 20);
            return player.GetPlayer();
        }
    }
}
