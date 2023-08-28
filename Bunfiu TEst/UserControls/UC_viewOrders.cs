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
using System.IO;
using System.Text.Json;
using Bunfiu_TEst.UserControls;

namespace Inventory_App.UserControls3
{
    public partial class UC_viewOrders : UserControl
    {
        private static DataTable orderTable = new DataTable();
        public UC_viewOrders()
        {
            InitializeComponent();
            if(orderTable.Columns.Count == 0) 
            {
               orderTable.Columns.Add("Order Id", typeof(int));
               orderTable.Columns.Add("Kund", typeof(string));
               orderTable.Columns.Add("Summa", typeof(double));
               orderTable.Columns.Add("Produkter", typeof(int));
               orderTable.Columns.Add("Datum", typeof(DateTime));
            }
            LoadOrdersData();
            Classes.OrderManager.LoadOrdersId();
        }

        private void LoadOrdersData()
        {
            orderTable.Clear();
            UC_Orders.LoadOrderData();
            foreach(Order order in UC_Orders.OrdersList)
            {
                orderTable.Rows.Add(order.Id, order.Customer.Namn, order.Summa, order.Produkter, order.Datum);
            }
            viewOrdersGrid.DataSource = orderTable;
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if(searchBox.Text == "")
            {
                LoadOrdersData();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
                if (int.TryParse(searchBox.Text, out int searchText))
                {
                    Order order = Classes.OrderManager.FindOrderByProductId(searchText);
                    if (order != null)
                    {
                        orderTable.Clear();
                        orderTable.Rows.Add(order.Id, order.Customer.Namn, order.Summa, order.Produkter, order.Datum);
                    } 
                    else
                    {
                        MessageBox.Show("Det finns ingen order med order id: " + searchText);
                    }
                }
                else
                {
                    MessageBox.Show("Ange ett order id för att söka");
                }
        }
    }
}

