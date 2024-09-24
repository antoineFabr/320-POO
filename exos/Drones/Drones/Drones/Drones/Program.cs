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
            for (int i = 0; i < 10; i++)
            {
                Drone drone = new Drone();
                drone.x = 100;
                drone.y = 100;
                drone.name = "antoine";
                fleet.Add(drone);
            }
            

            List<Building> City = new List<Building>();
            Building building1 = new Building(8,8,30,30);
            

            // Démarrage
            Application.Run(new AirSpace(fleet));
        }
    }
}