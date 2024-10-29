using static System.Net.Mime.MediaTypeNames;
using System.Text;
using Boat;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            string banane = "banane";
            Bateau Gaston = new Bateau("Gaston",35);
            Container numerobis = new Container(113,1200,false,"blue");
            Gaston.Start();
            Gaston.LoadContainer(numerobis);
            Gaston.UnloadContainer(numerobis);
            Console.ReadLine();



        }
    }
}