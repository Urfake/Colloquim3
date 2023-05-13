namespace Colloquim3
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
            /*using (ApplicationContext db = new ApplicationContext())
            {
                Bed bed1 = new Bed { Name = "Кровать1", Description = "Кровать сделан из дерева", Price = 200, STATUS ="SOLD" };
                Bed bed2 = new Bed { Name = "Кровать2", Description = "Кровать сделан из железа", Price = 100, STATUS = "AVAILABLE" };
                // добавляем их в бд    
                db.Beds.AddRange(bed1, bed2);
                db.SaveChanges();
            }*/

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            
            /*// получение данных
            using (ApplicationContext db = new ApplicationContext())
            {
                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Users list:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }*/
        }
    }

}