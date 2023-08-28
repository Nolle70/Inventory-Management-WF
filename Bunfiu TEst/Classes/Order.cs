using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory_App.UserControls
{
    public class Order : OrderBaseClass //Klass för varje enskild order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime Datum { get; set; }
        public List<OrderItem> OrderList { get; set; } = new List<OrderItem>();
        public int Produkter { get; set; }

        public override double calculateTotalPrice()
        {
            Summa = 0;
            foreach (OrderItem item in OrderList)
            {
                Summa += item.calculateTotalPrice();
            }

            return Summa;
        }

        public override int calculateTotalProducts()
        {  
           Produkter = 0;
           foreach (OrderItem item in OrderList)
            {
                Produkter += item.calculateTotalProducts();
            }

           return Produkter;
            
        }

    }
}
