using System;
namespace PizzaStore
{
	public class Store
	{
        string _storeName;
        public Store(string storeName)
        {
            _storeName = storeName;
        }

        public void Start()
        {
            MenuCatalog menuCatalog = new MenuCatalog();
			Customer customer1 = new Customer("Hanne");
			Pizza pizza1 = new Pizza("Pepperoni", 80);
            menuCatalog.Create(pizza1);
            Order order1 = new Order(customer1, pizza1);
            
            Customer customer2 = new Customer("Anne");
            Pizza pizza2 = new Pizza("Hawaii", 70);
            menuCatalog.Create(pizza2);
            Order order2 = new Order(customer2, pizza2);

            Customer customer3 = new Customer("Sanne");
            Pizza pizza3 = new Pizza("Ham", 60);
            menuCatalog.Create(pizza3);
            Order order3 = new Order(customer3, pizza3);

            Console.WriteLine("----" + _storeName + "----");
            Console.WriteLine("Order #1:");
            order1.PrintOrderInfo();
            Console.WriteLine("Order #2:");
            order2.PrintOrderInfo();
            Console.WriteLine("Order #3:");
            order3.PrintOrderInfo();
            menuCatalog.PrintMenu();
            menuCatalog.SearchPizza("Pepperoni");
        }

        public override string ToString()
        {
            return _storeName;
        }
    }
}

