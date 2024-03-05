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
			Customer customer1 = new Customer("Hanne");
			Pizza pizza1 = new Pizza("Pepperoni");
            Order order1 = new Order(customer1, pizza1, 100);

            Customer customer2 = new Customer("Anne");
            Pizza pizza2 = new Pizza("Hawaii");
            Order order2 = new Order(customer2, pizza2, 90);

            Customer customer3 = new Customer("Sanne");
            Pizza pizza3 = new Pizza("Ham");
            Order order3 = new Order(customer3, pizza3, 120);

            Console.WriteLine("----" + _storeName + "----");
            Console.WriteLine("Order #1:");
            order1.PrintOrderInfo();
            Console.WriteLine("Order #2:");
            order2.PrintOrderInfo();
            Console.WriteLine("Order #3:");
            order3.PrintOrderInfo();
        }

        public override string ToString()
        {
            return _storeName;
        }
    }
}

