using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunfiu_TEst.UserControls
{
    public partial class UC_Orders : UserControl
    {
        public Inventory_App.UserControls.UC_Customers customerClass = new Inventory_App.UserControls.UC_Customers();
        public static DataTable customerTable = new DataTable();
        public UC_Orders()
        {
            InitializeComponent();
            
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            
        }
        public static void dataLoad(DataTable dt)
        {
            customerTable = dt;
        }

        private void UC_Orders_Load(object sender, EventArgs e)
        {
            customerClass.UC_Customers_Load(sender, e);
            customerGrid.DataSource = customerTable;
        }

        
    }
}
