using System;
namespace PizzaStore
{
    public class UserDialog
    {
        
        private bool quit = false;
        MenuCatalog _menuCatalog;
        FormatException ex = new FormatException("Wrong format");
        public UserDialog(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }
        
        public Pizza CreatePizza()
        {
            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("CREATE NEW PIZZA");
            Console.WriteLine("----------------");
            Console.WriteLine("Enter Pizza Name:");
            string pizzaName = Console.ReadLine();
            Console.WriteLine("Enter Pizza Price:");
            try
            {
                string pP = Console.ReadLine();
                int pizzaPrice = int.Parse(pP);
                Pizza pizza = new Pizza(pizzaName, pizzaPrice);
                return pizza;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Pizza not formated correctly!");
                return null;
            }
        }

        public string UpdatePizza()
        {
            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("UPDATE PIZZA");
            Console.WriteLine("----------------");
            Console.WriteLine("Enter Pizza Name you want to update:");      
            string pizzaName = Console.ReadLine();
            foreach (Pizza pizza in _menuCatalog)
            {
                if (pizza.GetPizzaName() == pizzaName)
                {
                    Console.WriteLine("Enter new Pizza Name:");
                    string newPizzaName = Console.ReadLine();
                    Console.WriteLine("Enter new Pizza Price:");
                    try
                    {
                        string pP = Console.ReadLine();
                        int newPizzaPrice = int.Parse(pP);
                        pizza.UpdatePizza(newPizzaName, newPizzaPrice);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Pizza not formated correctly!");
                        return null;
                    }
                }
            }
            return pizzaName;
        }
        
        public string DeletePizza()
        {
            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("Delete PIZZA");
            Console.WriteLine("----------------");
            Console.WriteLine("Enter Pizza Name you want to update:");      
            string pizzaName = Console.ReadLine();
            foreach (Pizza pizza in _menuCatalog)
            {
                if (pizza.GetPizzaName() == pizzaName)
                {
                    _menuCatalog.DeletePizza(pizzaName);
                    break;
                }
            }
            return pizzaName;
        }
        public void Run()
        {
            Console.Clear();
            List<string> MenuList = new List<string>();
            MenuList.Add("#1 Create Pizza");
            MenuList.Add("#2 Update Pizza");
            MenuList.Add("#3 Delete Pizza");
            MenuList.Add("#4 Display Pizza Menu");
            MenuList.Add("#5 Quit");

            

            
            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("----------------");
                Console.WriteLine("BIG MAMMA GASTRONOMIA");
                Console.WriteLine("MENU DIALOG");
                Console.WriteLine("----------------");
                foreach (var userDialog in MenuList)
                {
                    Console.WriteLine(userDialog);
                }
                Console.Write("Enter option#: ");
                string input = Console.ReadKey().KeyChar.ToString();
                int menuChoice = int.Parse(input);

                switch (menuChoice)
                {
                    case 1:
                        Pizza pizza = CreatePizza(); 
                        if (pizza is not null)
                        { 
                            _menuCatalog.Create(pizza); Console.WriteLine($"You have created pizza {pizza}");
                        }
                        Console.WriteLine("Press Enter to Continue to Main Menu");
                        Console.ReadLine();
                        break;
                    case 2:
                        string updatePizza = UpdatePizza();
                        if (updatePizza is not null)
                        {
                            Console.WriteLine($"You have updated pizza {updatePizza}");   
                        }
                        Console.WriteLine("Press Enter to Continue to Main Menu");
                        Console.ReadLine();
                        break;
                    case 3:
                        string deletePizza = DeletePizza();
                        if (deletePizza is not null)
                        {
                            Console.WriteLine($"You have deleted pizza {deletePizza}");  
                        }
                        Console.WriteLine("Press Enter to Continue to Main Menu");
                        Console.ReadLine();
                        break;
                    case 4:
                        _menuCatalog.PrintMenu();
                        Console.WriteLine("Press Enter to Continue to Main Menu");
                        Console.ReadLine();
                        break;
                    default:
                        quit = true;
                        break;
                }
            }
        }
    }
}