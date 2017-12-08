using Adapter;

namespace AdapterTests
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                var adapter = new SpecificPlayer();
                adapter.GetSpecificPlayer();
            }

            for (int i = 0; i < 1000; i++)
            {
                var objectAdapter = new ObjectAdapter.SpecificPlayer("Marcin", "Nowak", 20);
                objectAdapter.GetSpecificPlayer();
            }
        }
    }
}
