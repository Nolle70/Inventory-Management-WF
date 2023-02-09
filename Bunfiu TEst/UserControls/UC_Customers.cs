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
    public partial class UC_Customers : UserControl
    {
        public static List<Customer> customerList = new List<Customer>();
        public static DataTable customerTable = new DataTable();
       
        public UC_Customers()
        {
            InitializeComponent(); 
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            nameText.Text = "";
            idText.Text = "";
            phoneText.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameText.Text != "" && idText.Text != "" && phoneText.Text != "" &&
              nameText.Text != "Name..." && idText.Text != "Price..." && phoneText.Text != "Quantity...")
            {
                string name = nameText.Text;
                string id = idText.Text;
                string phone = phoneText.Text;

                customerList.Add(new Customer(name, id, phone));
                customerTable.Rows.Add(name, id, phone);
                newBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please enter in all fields");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            string id = idText.Text;
            string phone = phoneText.Text;

            if (customerGrid.CurrentCell != null)
            {
                int index = customerGrid.CurrentCell.RowIndex;
                customerTable.Rows[index].Delete();
                customerTable.Rows.Add(name, id, phone);
                customerList[index].name = name;
                customerList[index].id = id;
                customerList[index].phone = phone;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (customerGrid.CurrentCell != null)
            {
                int index = customerGrid.CurrentCell.RowIndex;
                customerTable.Rows[index].Delete();
                customerList.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Please choose a valid cell to delete");
            }
        }

        public void UC_Customers_Load(object sender, EventArgs e)
        {
            LoadCustomerGrid(sender, e);

            customerGrid.DataSource = customerTable;  
 
        }

        public static void LoadCustomerGrid(object sender, EventArgs e)
        {
            if (customerTable.Columns.Count == 0)
            {
                customerTable.Columns.Add("Name");
                customerTable.Columns.Add("Id");
                customerTable.Columns.Add("Phone");
                customerList.Add(new Customer("Max", "1", "073-214 83 50"));
                customerList.Add(new Customer("Noel", "2", "072-197 80 59"));
                customerList.Add(new Customer("Elton", "3", "076-543 53 12"));
                customerTable.Rows.Add("Max", "1", "073-214 83 50");
                customerTable.Rows.Add("Noel", "2", "072-197 80 59");
                customerTable.Rows.Add("Elton", "3", "076-543 53 12");
            }
        }

        private void customerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nameText.Text = customerList[customerGrid.CurrentCell.RowIndex].name;
                idText.Text = customerList[customerGrid.CurrentCell.RowIndex].id;
                phoneText.Text = customerList[customerGrid.CurrentCell.RowIndex].phone;
            }
            catch (Exception error)
            {
                Console.WriteLine("There hase been an error: " + error);
            }
        }
    }
}
