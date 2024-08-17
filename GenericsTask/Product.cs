using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    public abstract class Product
    {
        private static int _idCounter = 0;
        public int Id { get; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Count { get; protected set; }
        protected double TotalInCome { get; set; }

        public Product(string name, double price, int count)
        {
            if (string.IsNullOrEmpty(name) || price <= 0 || count < 0)
            {
                throw new ArgumentException("Invalid arguments for product creation.");
            }

            Id = ++_idCounter;
            Name = name;
            Price = price;
            Count = count;
            TotalInCome = 0;
        }

        public abstract void Sell();
        public abstract void ShowInfo();
    }
}
