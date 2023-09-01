using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_App
{
    public abstract class OrderBaseClass : Classes.IdInterface //Basklass för orderitem och order klasserna
    {
        public int Id { get; set; }
        public double Summa { get; set; }
        public abstract double calculateTotalPrice();

        public abstract int calculateTotalProducts();
       
    }
}
