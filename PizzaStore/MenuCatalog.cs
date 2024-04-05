namespace PizzaStore;

public class MenuCatalog
{
    private List<Pizza> _pizzas;
    public MenuCatalog()
    {
        _pizzas = new List<Pizza>();
    }
    public void Create(Pizza pizza)
    {
        _pizzas.Add(pizza);
    }

    public void DeletePizza(string name)
    {
        foreach (Pizza p in _pizzas)
        {
            if (p.GetPizzaName() == name)
            {
                _pizzas.Remove(p);
                return;
            }
        }
    }
    
    
    public void PrintMenu()
    {
        bool isEmpty = true;
        Console.WriteLine("----- Menu Catalog ----");
        foreach (Pizza p in _pizzas)
        {
            Console.WriteLine($"{p} - Price: {p.GetPizzaPrice()} DKK");
            isEmpty = false;
        }
        if (isEmpty)
        {
            Console.WriteLine("Menu is empty!");
        }
        Console.WriteLine("-----------------------");
    }

    public IEnumerator<Pizza> GetEnumerator()
    {
        return _pizzas.GetEnumerator();
    }
    public Pizza SearchPizza(string pizzaName)
    {
        Console.WriteLine("----- Search Pizza ----");
        foreach (Pizza p in _pizzas)
        {
            if (pizzaName == p.GetPizzaName())
            {
                Console.WriteLine(p);
                Console.WriteLine("-----------------------");
                return p;
                
            }
            
        }
        Console.WriteLine("-----------------------");
        return null;
    }
}