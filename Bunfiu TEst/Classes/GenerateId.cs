using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunfiu_TEst.UserControls;
using Inventory_App.UserControls;
using System.Text.Json.Serialization;

namespace Inventory_App.Classes
{
    public class GenerateId
    {
        public static HashSet<int> UsedProductIds = new HashSet<int>();
        public static HashSet<int> UsedCustomerIds = new HashSet<int>();
        public static HashSet<int> UsedOrderIds = new HashSet<int>();

        protected const int MaxProductId = 999999;
        protected static Random RandomNumber = new Random();
        public int Id { get; set; }   

        public static int GenerateUniqueId(HashSet<int> usedIds)
        {
            int randomId;
            do
            {
                randomId = RandomNumber.Next(111111, MaxProductId + 1);
            } while (usedIds.Contains(randomId));

            usedIds.Add(randomId);
            return randomId;
        }

        public static void LoadProductIds(List<Product> productList)
        {
            UsedProductIds.Clear();
            foreach (Product product in productList)
            {
                UsedProductIds.Add(product.Id);
            }
        }

        public static void LoadCustomerIds(List<Customer> customerList)
        {
            UsedCustomerIds.Clear();
            foreach (Customer customer in customerList)
            {
                UsedCustomerIds.Add(customer.Id);
            }
        }
        public static void LoadOrderIds(List<Order> orderList)
        {
            UsedOrderIds.Clear();
            foreach (Order order in orderList)
            {
                UsedProductIds.Add(order.Id);
            }
        }

    }
}
