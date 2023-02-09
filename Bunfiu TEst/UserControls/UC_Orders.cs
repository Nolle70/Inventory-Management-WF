using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_App.UserControls;
using Inventory_App;

namespace Bunfiu_TEst.UserControls
{
    public partial class UC_Orders : UserControl
    {
        public static List<OrderItem> OneOrder = new List<OrderItem>();

        public static List<Order> OrdersList = new List<Order>();
        
        public static DataTable customerTable = new DataTable();

        public static DataTable inventoryTable = new DataTable();

        public static DataTable orderTable = new DataTable();

        public static List<TopProduct> topList = new List<TopProduct>();

        static int num = 1;
        static int num2 = 1;
        public static int totalOrdersPrice;
        public static int totalSoldProducts = 0;
        int index;
        public UC_Orders()
        {
            InitializeComponent();
            
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            if(OneOrder.Count > 0)
            { 

                DateTime date = datePicker.Value;
                Customer customer = UC_Customers.customerList[customerGrid.CurrentCell.RowIndex];
                OrdersList.Add(new Order(customer, date, OneOrder));
                Order temp = OrdersList[OrdersList.Count - 1];
                UC_viewOrders.loadOrdersGrid();
                UC_viewOrders.orderTable.Rows.Add(num2.ToString(), temp.customer.name,temp.getTotalOrderPrice().ToString(), temp.orderDate.ToString());
                totalOrdersPrice += temp.getTotalOrderPrice();
                
                UC_Home.dataList.Add(new RevenueByDate(date, Convert.ToDecimal(OrdersList[OrdersList.Count-1].getTotalOrderPrice())));
                subtractInventory(temp);
                orderTable.Clear();
                OneOrder.Clear();
                num2++;
            }
            else
            {
                MessageBox.Show("Please order at least one item");
            }
            
           
            
        }

        private void subtractInventory(Order order)
        {
            foreach(OrderItem item in order.orderList)
            {
                totalSoldProducts += item.quantity;
                index = UC_Inventory.inventoryList.IndexOf(item.product);
                UC_Inventory.inventoryList[index].quantity -= item.quantity;
                UC_Inventory.productsTable.Rows[index]["Quantity"] = UC_Inventory.inventoryList[index].quantity;

                foreach(TopProduct product in UC_Inventory.topProducts)
                {
                    if(product.Name == item.product.name)
                    {
                        product.Quantity += item.quantity;
                    }
                }
            }

            UC_Inventory.LoadInventoryGrid();

        }

        private void UC_Orders_Load(object sender, EventArgs e)
        {
            UC_Customers.LoadCustomerGrid(sender, e); //Ladda data från customer och inventory
            UC_Inventory.LoadInventoryGrid();
            customerGrid.DataSource =  UC_Customers.customerTable; //Kopiera från customer och inventory
            inventoryGrid.DataSource = UC_Inventory.productsTable;

           if (orderTable.Columns.Count == 0)
            {
                orderTable.Columns.Add("Num");
                orderTable.Columns.Add("Product");
                orderTable.Columns.Add("Quantity");
                orderTable.Columns.Add("Price");
                orderTable.Columns.Add("Total price");
                totalOrdersPrice = 0;
            }
            orderGrid.DataSource = orderTable;

        }

        private void addItem_Click(object sender, EventArgs e)
        {
            string qunati = quantityText.Text;
            int quantity;
            bool success = int.TryParse(qunati, out quantity);
            bool exist = true; 

            if (success)
            {            
                Product product = UC_Inventory.inventoryList[inventoryGrid.CurrentCell.RowIndex];
                if (product.quantity >= quantity)
                {


                    int price = Convert.ToInt32(product.price);
                    foreach (OrderItem ord in OneOrder)
                    {
                        if (ord.product == product)
                        {
                            ord.quantity += quantity;
                            ord.totalPrice = ord.calculateTotalPrice();
                            orderTable.Rows[OneOrder.IndexOf(ord)]["Quantity"] = ord.quantity.ToString();
                            orderTable.Rows[OneOrder.IndexOf(ord)]["Total Price"] = ord.totalPrice.ToString();
                            exist = false;
                            break;
                        }
                    }

                    if (exist)
                    {
                        OneOrder.Add(new OrderItem(num, product, quantity, price));
                        orderTable.Rows.Add(num.ToString(), product.name, quantity.ToString(), product.price.ToString(), Convert.ToInt32(price) * quantity);
                        num++;
                    }
                }
                else
                {
                    MessageBox.Show("Inventory does not have that amount of that product");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity");
            }
              
        }

        private void customerGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(customerGrid.RowCount > 1)
            {
                nameText.Text = UC_Customers.customerList[customerGrid.CurrentCell.RowIndex].name;
                idText.Text = UC_Customers.customerList[customerGrid.CurrentCell.RowIndex].id;
            }
        }
    }
}
