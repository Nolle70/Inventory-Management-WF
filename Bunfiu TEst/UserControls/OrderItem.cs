using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_App.UserControls
{
    public class OrderItem
    {
        public int num;
        public Product product;
        public int quantity { get; set; }
        public int price {get; set; }
        public int totalPrice { get; set; }

        public OrderItem(int num, Product product, int quantity, int price)
        {
            this.num = num;
            this.product = product;
            this.quantity = quantity;
            this.price = price;
            totalPrice = calculateTotalPrice();
        }

        public int calculateTotalPrice()
        {
            totalPrice = price * quantity;
            return totalPrice;
        } 

        
    }
}
