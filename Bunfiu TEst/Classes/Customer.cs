using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_App.UserControls
{
    public class Customer : Classes.GenerateId
    {
        public string Namn { get; set; }
        public string Mail { get; set; }

        public int Ordrar { get; set; }

        public void AddOrder()
        {
            Ordrar += 1;
        }

        public static void LoadOrders()
        {
            foreach(Customer customer in UC_Customers.customerList)
            {
                customer.Ordrar = 0;
                foreach (Order order in Bunfiu_TEst.UserControls.UC_Orders.OrdersList) //Antal ordrar gjorda av denna customer
                {
                    if (order.Customer.Id == customer.Id)
                    {
                        customer.Ordrar += 1;
                    }
                }
            } 
        }

    }
}
