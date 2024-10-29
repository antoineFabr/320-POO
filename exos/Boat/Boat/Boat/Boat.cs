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
            Console.WriteLine("le bateau d�mare");
        }
        public bool LoadContainer(Container container)
        {
            Console.WriteLine("le container {0} est charg�",container.Id);
            return true;
        }
        public bool UnloadContainer(Container container)
        {
            Console.WriteLine("le container {0} est d�charg�", container.Id);
            return false;
        }
    }

}