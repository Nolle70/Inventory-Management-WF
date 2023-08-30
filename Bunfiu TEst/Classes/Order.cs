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
        public Customer Customer { get; set; }
        public DateTime Datum { get; set; }
        public List<OrderItem> OrderList { get; set; } = new List<OrderItem>();
        public int Produkter { get; set; }

        public Bunfiu_TEst.UserControls.UC_Orders UC_Orders
        {
            get => default;
            set
            {
            }
        }

        public override double calculateTotalPrice() //Sammanlagda priset för ordern
        {
            Summa = 0;
            foreach (OrderItem item in OrderList)
            {
                Summa += item.calculateTotalPrice();
            }

            return Summa;
        }

        public override int calculateTotalProducts() //Antal produkter i ordern
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
