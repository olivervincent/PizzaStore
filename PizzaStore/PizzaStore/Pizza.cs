using System;
namespace PizzaStore
{
	public class Pizza
	{
        private string _pizzaName;

        public Pizza(string pizzaName)
		{
			_pizzaName = pizzaName;
		}

		public string GetPizzaName()
		{
			return _pizzaName;
		}

        public override string ToString()
        {
            return _pizzaName;
        }
    }
}

