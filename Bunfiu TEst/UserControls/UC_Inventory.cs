using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_App;

namespace Bunfiu_TEst.UserControls
{
    public partial class UC_Inventory : UserControl
    {
        List<Product> inventoryList = new List<Product>();
        DataTable productsTable = new DataTable();


        public UC_Inventory()
        {
            InitializeComponent();
            
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            nameText.Text = "";
            priceText.Text = "";
            quantityText.Text = "";
            selectBox.SelectedIndex = -1;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameText.Text != "" && priceText.Text != "" && quantityText.Text != "" &&
               nameText.Text != "Name..." && priceText.Text != "Price..." && quantityText.Text != "Quantity..."
               && selectBox.Text != "Select..." && selectBox.SelectedIndex != -1)
            {
                string name = nameText.Text;
                string price = priceText.Text;
                string quantity = quantityText.Text;
                string category = (string)selectBox.SelectedItem;
                int index = selectBox.SelectedIndex;

                inventoryList.Add(new Product(name, price, quantity, (Categories)index));
                productsTable.Rows.Add(name, price, quantity, category);
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
            string price = priceText.Text;
            string quantity = quantityText.Text;
            string category = (string)selectBox.SelectedItem;
            int selected = selectBox.SelectedIndex;



            if (inventoryGrid.CurrentCell != null)
            {
                int index = inventoryGrid.CurrentCell.RowIndex;
                productsTable.Rows[index].Delete();
                productsTable.Rows.Add(name, price, quantity, category);
                inventoryList[index].name = name;
                inventoryList[index].price = price;
                inventoryList[index].quantity = quantity;
                inventoryList[index].category = (Categories)selected;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (inventoryGrid.CurrentCell != null)
            {
                int index = inventoryGrid.CurrentCell.RowIndex;
                productsTable.Rows[index].Delete();
                inventoryList.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Please choose a valid cell to delete");
            }
        }

        private void inventoryGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = (int)inventoryList[inventoryGrid.CurrentCell.RowIndex].category;
                nameText.Text = inventoryList[inventoryGrid.CurrentCell.RowIndex].name;
                priceText.Text = inventoryList[inventoryGrid.CurrentCell.RowIndex].price;
                quantityText.Text = inventoryList[inventoryGrid.CurrentCell.RowIndex].quantity;
                selectBox.SelectedIndex = index;

            }
            catch (Exception error)
            {
                Console.WriteLine("There hase been an error: " + error);
            }
        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            productsTable.Columns.Add("Name");
            productsTable.Columns.Add("Price");
            productsTable.Columns.Add("Quantity");
            productsTable.Columns.Add("Category");
            inventoryGrid.DataSource = productsTable;
            inventoryList.Add(new Product("Computer", "399", "10", Categories.Electronics));
            productsTable.Rows.Add("Computer", "399$", "10", "Electronics");
            inventoryList.Add(new Product("Anabola", "2199", "23", Categories.Pharmacy));
            productsTable.Rows.Add("Anabola", "2199$", "23", "Pharmacy");
            inventoryList.Add(new Product("Apple", "1", "1000", Categories.Grocery));
            productsTable.Rows.Add("Apple", "1$", "1000", "Grocery");

           
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            int count;

            if(searchBox.Text == "")
            {

                count = 0;
                productsTable.Clear();

                foreach (Product pro in inventoryList)
                {
                    int index = (int)pro.category;
                    productsTable.Rows.Add(pro.name, pro.price, pro.quantity, selectBox.Items[index]);

                    count++;
                }
            }
            else
            {
                int index;
                productsTable.Clear();

                foreach(Product pro in inventoryList)
                {
                    if(pro.name.Length >= searchBox.Text.Length)
                    {
                        if (pro.name.Substring(0, searchBox.Text.Length).ToLower() == searchBox.Text.ToLower())
                        {
                            index = (int)pro.category;
                            productsTable.Rows.Add(pro.name, pro.price, pro.quantity, selectBox.Items[index]);
                        }
                    }
                }
            }
        }



    }
}
