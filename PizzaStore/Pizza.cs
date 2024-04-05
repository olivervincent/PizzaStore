using System;
namespace PizzaStore
{
	public class Pizza
	{
        private string _pizzaName;
        public int _pizzaPrice { get; set; }

        public Pizza(string pizzaName, int pizzaPrice)
		{
			_pizzaName = pizzaName;
			_pizzaPrice = pizzaPrice;
		}

		public void UpdatePizza(string pizzaName, int pizzaPrice)
		{
			_pizzaName = pizzaName;
			_pizzaPrice = pizzaPrice; 
		}
		
		public string GetPizzaName()
		{
			return _pizzaName;
		}
		
		public int GetPizzaPrice()
		{
			return _pizzaPrice;
		}

        public override string ToString()
        {
            return _pizzaName;
        }
    }
}

