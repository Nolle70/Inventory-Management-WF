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

namespace Inventory_App.UserControls3
{
    public partial class UC_viewOrders : UserControl
    {
        public static DataTable orderTable = new DataTable();
        public UC_viewOrders()
        {
            InitializeComponent();
            if(orderTable.Columns.Count == 0) 
            {
               orderTable.Columns.Add("Order Id", typeof(int));
               orderTable.Columns.Add("Kund", typeof(string));
               orderTable.Columns.Add("Ordersumma", typeof(int));
               orderTable.Columns.Add("Datum", typeof(DateTime));
            }
            LoadOrderData();
            viewOrdersGrid.DataSource = orderTable;
        }

        public void LoadOrderData()
        {
            orderTable.Clear();
            Bunfiu_TEst.UserControls.UC_Orders temp = new Bunfiu_TEst.UserControls.UC_Orders();
            temp.LoadOrderData();
            foreach(Order order in Bunfiu_TEst.UserControls.UC_Orders.OrdersList)
            {
                orderTable.Rows.Add(order.Id, order.Customer.Namn, order.Summa, order.Datum);
            }
        }

        private void UC_viewOrders_Load(object sender, EventArgs e)
        {
            
        }
       


    }
}
