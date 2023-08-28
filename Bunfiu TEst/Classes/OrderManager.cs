using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_App.UserControls;
using Bunfiu_TEst.UserControls;

namespace Inventory_App.Classes
{
    public class OrderManager
    {
        private static Dictionary<int, Order> orderDictionary = new Dictionary<int, Order>();

        public static void LoadOrdersId()
        {
            orderDictionary.Clear();
            foreach(Order order in UC_Orders.OrdersList)
            {
                orderDictionary.Add(order.Id, order);
            }
        }

        public static Order FindOrderByProductId(int productId)
        {  
            if (orderDictionary.ContainsKey(productId))
            {
                return orderDictionary[productId];
            }
            return null;
        }
    }
}
