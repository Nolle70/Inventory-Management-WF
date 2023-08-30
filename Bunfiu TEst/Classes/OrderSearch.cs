using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_App.UserControls;
using Bunfiu_TEst.UserControls;

namespace Inventory_App.Classes
{
    public class OrderSearch
    {
        private static Dictionary<int, Order> orderDictionary = new Dictionary<int, Order>(); //All ordrar lagras i ett dictionary där jag använder order id som nyckel till varje order

        public UserControls3.UC_viewOrders UC_viewOrders
        {
            get => default;
            set
            {
            }
        }

        public static void LoadOrdersId() //Lägger till alla ordrar i dictionary där jag sätter order id som nyckel och själva order objektet som värde
        {
            orderDictionary.Clear();
            foreach(Order order in UC_Orders.OrdersList)
            {
                orderDictionary.Add(order.Id, order);
            }
        }

        public static Order FindOrderByProductId(int productId) //Kollar om dictionary innehåller vald order isåfall returnar den ordern som tillhör det order id.
        {  
            if (orderDictionary.ContainsKey(productId))
            {
                return orderDictionary[productId];
            }
            return null;
        }
    }
}
