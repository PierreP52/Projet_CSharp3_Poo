using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet03
{
    class Candy
    {
        public string Name { get; private set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Candy(String name,decimal price,int stock)
        {
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
