using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Inventory_App;

namespace Bunfiu_TEst
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            UserControls.UC_Home uc = new UserControls.UC_Home();
            addUserControl(uc);          
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            UserControls.UC_Home uc = new UserControls.UC_Home();
            addUserControl(uc);
            topPanel.BackColor = Color.Blue;
            
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            UserControls.UC_Inventory uc = new UserControls.UC_Inventory();
            addUserControl(uc);
            topPanel.BackColor = Color.Red;
            
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            UserControls.UC_Orders uc = new UserControls.UC_Orders();
            addUserControl(uc);
            topPanel.BackColor = Color.Green;
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            Inventory_App.UserControls.UC_Customers uc = new Inventory_App.UserControls.UC_Customers();
            addUserControl(uc);
            topPanel.BackColor = Color.Yellow;
        }
    }
}
