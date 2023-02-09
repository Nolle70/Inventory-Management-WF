using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_App.UserControls
{
    public class TopProduct
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        
        public TopProduct(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }

    
}
