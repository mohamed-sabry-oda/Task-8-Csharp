using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Csharp
{
    class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public Product(int id, string name, int price) {
            Id = id;    
            Name = name;
            Price = price;
        }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}";
        }
    }
}
