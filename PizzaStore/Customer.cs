using System;
namespace PizzaStore
{
	public class Customer
	{
		private string _customerName;

		public Customer(string customerName)
		{
			_customerName = customerName;
		}

		public string GetCustomerName()
		{
			return _customerName;
		}

        public override string ToString()
        {
            return _customerName;
        }
    }
}

