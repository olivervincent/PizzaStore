using System;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Store store = new Store("BIG MAMMA GASTRONOMIA");
            //store.Start();

            MenuCatalog menuCatalog = new MenuCatalog();
            UserDialog userDialog = new UserDialog(menuCatalog);
            userDialog.Run();

            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }
    }
}

