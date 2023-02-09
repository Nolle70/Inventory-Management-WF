using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_App.UserControls
{
    public class Customer
    {
        public string name;
        public string id;
        public string phone;
        public static List<Order> OrdersList = new List<Order>();
        public int TotalOrders { get; set; }
        public int TotalAmount { get; set; }

        public Customer(string name, string id, string phone)
        {
            this.name = name;
            this.id = id;
            this.phone = phone;
        }
    }
}
