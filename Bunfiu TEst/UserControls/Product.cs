using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_App
{
    public class Product
    {

        public string name;
        public string price;
        public string quantity;
        public Categories category;

        public Product(string name, string price, string quantity, Categories category)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
        }
    }
}
