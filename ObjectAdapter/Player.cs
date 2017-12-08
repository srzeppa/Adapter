namespace ObjectAdapter
{
    public class Player
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public Player(string firstname, string lastname, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }

        public string GetPlayer()
        {
            return $"{Firstname} {Lastname} {Age}";
        }
    }
}
