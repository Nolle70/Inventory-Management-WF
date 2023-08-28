using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using Inventory_App.Classes;


namespace Inventory_App.UserControls
{
    public partial class UC_Customers : UserControl
    {
        public static List<Customer> customerList = new List<Customer>();
        public string path = @"C:\Users\Noel Nevrén\Desktop\Saker\Code\Projects in VS\Bunfiu TEst\Bunfiu TEst\Json\customers.json";
        Customer temp = new Customer();
        public UC_Customers()
        {
            InitializeComponent();
            RefreshCustomerGrid();
        }

        public void LoadCustomerData()
        {
            string jsonData = File.ReadAllText(path);
            customerList = JSONUtility.DeserializeListFromJson<Customer>(jsonData);
            GenerateId.LoadCustomerIds(customerList);
        }
        public void UpdateJsonFile()
        {
            File.WriteAllText(path, JSONUtility.SerializeListToJson(customerList));
        }

        private void RefreshCustomerGrid()
        {
            LoadCustomerData();
            customerGrid.DataSource = customerList;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            nameText.Text = "";
            phoneText.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameText.Text != "" && phoneText.Text != "")
            {
                string name = nameText.Text;
                string phone = phoneText.Text;
                Customer customer = new Customer { Namn = name, Telefon = phone, Ordrar = 0, Id = GenerateId.GenerateUniqueId(GenerateId.UsedCustomerIds)};
                customerList.Add(customer);

                UpdateJsonFile();
                RefreshCustomerGrid();

                newBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Fyll i alla fält");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            string phone = phoneText.Text;

            if (customerGrid.CurrentCell != null)
            {
                int index = customerGrid.CurrentCell.RowIndex;
               
                customerList[index].Namn = name;
                customerList[index].Telefon = phone;
            }

            UpdateJsonFile();
            RefreshCustomerGrid();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (customerGrid.CurrentCell != null)
            {
                int index = customerGrid.CurrentCell.RowIndex;
            
                customerList.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Välj en rad innan du raderar");
            }
            UpdateJsonFile();
            RefreshCustomerGrid();
        }

        public void UC_Customers_Load(object sender, EventArgs e)
        {

            

        }

       

        private void customerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nameText.Text = customerList[customerGrid.CurrentCell.RowIndex].Namn;
                phoneText.Text = customerList[customerGrid.CurrentCell.RowIndex].Telefon;
            }
            catch (Exception error)
            {
                Console.WriteLine("Det har uppstått ett fel: " + error);
            }
        }
    }
}
