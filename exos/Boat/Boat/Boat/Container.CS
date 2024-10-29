using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    public class Container
    {
        public int Id;
        private float Weight;
        private bool IsRefrigerated;
        string Color;
        List<string> Merchandise;
        public Container(int id, float weight, bool isrefrigerated, string color) 
        {
            Id = id;
            Weight = weight;
            IsRefrigerated = isrefrigerated;
            Color = color;
            
        }  
        public void ViewContent()
        {
            foreach(string merchandise in Merchandise)
            {
                Console.WriteLine(merchandise);
            }
        }
        public void AddMerchandise(string item)
        {
            Merchandise.Add(item);
        }


    }

}