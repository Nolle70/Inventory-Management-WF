using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_App.UserControls
{
    public partial class UC_viewOrders : UserControl
    {
        public static DataTable orderTable = new DataTable();

        public UC_viewOrders()
        {
            InitializeComponent();
        }

        private void UC_viewOrders_Load(object sender, EventArgs e)
        {
            loadOrdersGrid();
            viewOrdersGrid.DataSource = orderTable;
        }

        public static void loadOrdersGrid()
        {
            if(orderTable.Columns.Count == 0)
            {
                orderTable.Columns.Add("Order Id");
                orderTable.Columns.Add("Customer Name");
                orderTable.Columns.Add("Total Order Price");
                orderTable.Columns.Add("Order Date");
            }
        }


    }
}
