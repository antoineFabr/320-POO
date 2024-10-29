using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    public class Bateau
    {
        private string Name;
        private float MaxCargoWeight;
        private int MaxSpeed;

        public Bateau(string name,int maxspeed)
        {
            Name = name;
            MaxSpeed = maxspeed;
        }
        public void Start()
        {
            Console.WriteLine("le bateau démare");
        }
        public bool LoadContainer(Container container)
        {
            Console.WriteLine("le container {0} est chargé",container.Id);
            return true;
        }
        public bool UnloadContainer(Container container)
        {
            Console.WriteLine("le container {0} est déchargé", container.Id);
            return false;
        }
    }

}