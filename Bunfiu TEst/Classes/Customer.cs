using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_App;

namespace Inventory_App.UserControls
{
    public class Customer : Classes.GenerateId
    {
        public string Namn { get; set; }
        public string Telefon { get; set; }

        public int ordrar;
        public int Ordrar
        {
            get { return ordrar; }
            
            set
            {
                ordrar = 0;
                foreach(Order order in Bunfiu_TEst.UserControls.UC_Orders.OrdersList) //Antal ordrar gjorda av denna customer
                {
                    if(order.Customer.Id == Id && order.Customer.Namn == Namn && order.Customer.Telefon == Telefon)
                    {
                        ordrar += 1;
                    }
                }      
            }
        }

    }
}
