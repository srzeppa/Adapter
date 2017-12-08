namespace ObjectAdapter
{
    public class SpecificPlayer : Player, ISpecificPlayer
    {

        public SpecificPlayer(string firstname, string lastname, int age) : base(firstname, lastname, age)
        {
        }

        public string GetSpecificPlayer()
        {
            return GetPlayer();
        }

    }
}
