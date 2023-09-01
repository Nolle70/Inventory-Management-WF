using System;
using System.Collections.Generic;

namespace Inventory_App.Classes
{
    public class GenerateId : IdInterface
    {
        public int Id { get; set; }

        public static HashSet<int> UsedProductIds = new HashSet<int>();
        public static HashSet<int> UsedCustomerIds = new HashSet<int>();
        public static HashSet<int> UsedOrderIds = new HashSet<int>();

        protected const int MaxProductId = 999999;
        protected static Random RandomNumber = new Random();

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

        public static void LoadIds<T>(List<T> list, HashSet<int> UsedIds) where T : IdInterface //Istället för att använda tre separata metoder för varje klass
        { 
            UsedIds.Clear();
            foreach(T item in list)
            {
                UsedIds.Add(item.Id);
            }
        }
    }
}
