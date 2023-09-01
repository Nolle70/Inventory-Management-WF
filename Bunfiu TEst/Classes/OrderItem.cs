using System;

namespace Inventory_App.UserControls
{
    public class OrderItem : OrderBaseClass //Klass för varje enskild produkt som läggs till i order
    {
        public string Namn { get; set; }

        public double Pris { get; set; }

        public int Kvantitet { get; set; }
        public Product Product { get; set; }
        public override double calculateTotalPrice()
        {
            Summa = Pris * Convert.ToDouble(Kvantitet);
            return Summa;
        }

        public override int calculateTotalProducts()
        {
            return Kvantitet;
        }

        public void AddQuantity(int quantity) //Ifall produkt av samma typ läggs till uppdateras kvantiten
        {
            Kvantitet += quantity;
        }

        public bool CheckQuantity() //Kollar om produkten borde finnas kvar i ordern
        {
            if(Kvantitet <= 0)
            {
                return false;
            }
            return true;
        }






    }
}
