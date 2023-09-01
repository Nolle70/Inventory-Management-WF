using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Inventory_App.Classes;


namespace Inventory_App.UserControls
{
    public partial class UC_Customers : UserControl
    {
        public static List<Customer> customerList = new List<Customer>();
        private static string path = @"C:\Users\Noel Nevrén\Desktop\Saker\Code\Projects in VS\Bunfiu TEst\Bunfiu TEst\Json\customers.json";
        public UC_Customers()
        {
            InitializeComponent();
            RefreshCustomerGrid();
            Customer.LoadOrders();
        }

        public static void LoadCustomerData()
        {
            customerList = JSONUtility.GetData(path, customerList);
            GenerateId.LoadIds(customerList, GenerateId.UsedProductIds);
        }
        public static void UpdateJsonFile()
        {
            JSONUtility.UpdateJsonFile(path, customerList);
        }

        private void RefreshCustomerGrid()
        {
            LoadCustomerData();
            customerGrid.DataSource = customerList;
        }

        private void newBtn_Click(object sender, EventArgs e) //Tömmer alla fält
        {
            nameText.Text = "";
            mailText.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e) //Lägger till ny kund
        {
            if (nameText.Text != "" && mailText.Text != "")
            {
                string name = nameText.Text;
                string phone = mailText.Text;
                Customer customer = new Customer { Namn = name, Mail = phone, Ordrar = 0, Id = GenerateId.GenerateUniqueId(GenerateId.UsedCustomerIds)};
                customerList.Add(customer);

                UpdateJsonFile();
                RefreshCustomerGrid();
                newBtn_Click(sender, e); //Rensar alla fält
            }
            else
            {
                MessageBox.Show("Fyll i alla fält");
            }
        }

        private void editBtn_Click(object sender, EventArgs e) //Ändra kund som redan finns tillagd
        {
            string name = nameText.Text;
            string phone = mailText.Text;

            if (customerGrid.CurrentCell != null)
            {
                int index = customerGrid.CurrentCell.RowIndex;
               
                customerList[index].Namn = name;
                customerList[index].Mail = phone;
            }

            UpdateJsonFile();
            RefreshCustomerGrid();
        }

        private void deleteBtn_Click(object sender, EventArgs e) //Ta bort kund
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
        private void customerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Välj kund i datagriden
        {
            try
            {
                nameText.Text = customerList[customerGrid.CurrentCell.RowIndex].Namn;
                mailText.Text = customerList[customerGrid.CurrentCell.RowIndex].Mail;
            }
            catch (Exception error)
            {
                Console.WriteLine("Det har uppstått ett fel: " + error);
            }
        }
    }
}
