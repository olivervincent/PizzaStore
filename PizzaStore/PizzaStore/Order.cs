using System;
namespace PizzaStore
{
	public class Order
	{
		private Pizza _pizza;
		private Customer _customer;
		private int _pizzaPrice;
        private const int _taxAndDeliveryPrice = 40;

        public Order(Customer customer, Pizza pizza, int pizzaPrice)
		{
			_pizza = pizza;
			_customer = customer;
			_pizzaPrice = pizzaPrice;
		}

		public int GetPizzaPrice()
		{
			return _pizzaPrice;
		}

        public Pizza GetPizzaName()
        {
			return _pizza;
        }

        public Customer GetCustomerName()
        {
            return _customer;
        }

        public int CalculateTotalPrice()
        {
			return _pizzaPrice + _taxAndDeliveryPrice;

        }

        public void PrintOrderInfo()
		{
			Console.WriteLine("Customer: " + _customer);
			Console.WriteLine("Order: " + _pizza);
			Console.WriteLine("Price: " + GetPizzaPrice());
			Console.WriteLine("Total Price including tax and delivery: " + CalculateTotalPrice());
			Console.WriteLine();
		}

        public override string ToString()
        {
            return _customer + "" + _pizza + "" + _pizzaPrice;
        }
    }
}

