using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_App.UserControls
{
    public class OrderItem : OrderBaseClass //Klass för varje enskild produkt som läggs till i order
    {
        public string Namn { get; set; }

        public double Pris { get; set; }

        public int kvantitet;
        public Product Product { get; set; }
        public int Kvantitet //Ser till att kvantiteten inte sätts till negativt tal
        {
            get { return kvantitet; }
            set
            {
                if (value >= 0)
                {
                    kvantitet = value;
                }
                else
                {
                    throw new ArgumentException("Kvantiten måste vara positivt");
                }
            }

        }

        public override double calculateTotalPrice()
        {
            Summa = Pris * Convert.ToDouble(Kvantitet);
            return Summa;
        }

        public override int calculateTotalProducts()
        {
            return Kvantitet;
        }

        public void AddQuantity(int quantity)
        {
            Kvantitet += quantity;
        }






    }
}
