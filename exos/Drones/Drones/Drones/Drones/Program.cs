namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();

            List<Building> City = new List<Building>();
            Building building1 = new Building(8,8,30,30);
            drone.x = 100;
            drone.y = 100;
            drone.name = "Joe";
            fleet.Add(drone);

            // Démarrage
            Application.Run(new AirSpace(fleet));
        }
    }
}