using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory_App.UserControls
{
    public class Order
    {
        public Customer customer { get; set; }
        public int totalOrderPrice = 0;
        public DateTime orderDate { get; set; }
        public List<OrderItem> orderList = new List<OrderItem>();
        public int soldProducts = 0;
           
        public Order(Customer customer, DateTime orderDate, List<OrderItem> orderLista)
        {
            this.customer = customer;
            this.orderDate = orderDate;
            orderList = orderLista;
            
        }

        public void setTotalOrderPrice()
        {
            totalOrderPrice = 0;
            foreach(OrderItem item in orderList)
            {
                totalOrderPrice += item.totalPrice; 
            }
        }

        public int getTotalOrderPrice()
        {
            totalOrderPrice = 0;
            foreach (OrderItem item in orderList)
            {
                totalOrderPrice += item.calculateTotalPrice();
            }
            MessageBox.Show(totalOrderPrice.ToString());
            return totalOrderPrice;
        }

        public int allProducts()
        {
            foreach(OrderItem item in orderList)
            {
                soldProducts += item.quantity;         
            }
            return soldProducts;
        }


    }
}
