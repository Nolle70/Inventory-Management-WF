﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Inventory_App.UserControls;
using Bunfiu_TEst.UserControls;
using System.Runtime.InteropServices;

namespace Bunfiu_TEst
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();
            addUserControl(uc);          
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")] //Drag top panel
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
            topPanel.BackColor = Color.Blue;
            
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            UC_Inventory uc = new UC_Inventory();
            addUserControl(uc);
            topPanel.BackColor = Color.Red;
            
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            UC_Orders uc = new UC_Orders();
            addUserControl(uc);
            topPanel.BackColor = Color.LimeGreen;
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            UC_Customers uc = new UC_Customers();
            addUserControl(uc);
            topPanel.BackColor = Color.Yellow;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            homeBtn_Click(sender, e);
            homeBtn.Checked = true;
        }

        private void kryssBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e) //Drag top panel
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void viewOrdersBtn_Click(object sender, EventArgs e)
        {
            Inventory_App.UserControls3.UC_viewOrders uc = new Inventory_App.UserControls3.UC_viewOrders();
            addUserControl(uc);
            topPanel.BackColor = Color.Cyan;
        }
    }
}
