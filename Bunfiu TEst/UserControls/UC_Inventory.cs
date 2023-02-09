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
using Inventory_App.UserControls;


namespace Bunfiu_TEst.UserControls
{
    public partial class UC_Inventory : UserControl
    {
        public static List<Product> inventoryList = new List<Product>();
        public static DataTable productsTable = new DataTable();
        public static List<TopProduct> topProducts = new List<TopProduct>();


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
                int quantity = Convert.ToInt32(quantityText.Text);
                string category = (string)selectBox.SelectedItem;
                int index = selectBox.SelectedIndex;

                inventoryList.Add(new Product(name, price, quantity, (Categories)index));
                productsTable.Rows.Add(name, price, quantity, category);

                topProducts.Add(new TopProduct(name, 0));

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
                inventoryList[index].quantity = Convert.ToInt32(quantity);
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
                quantityText.Text = inventoryList[inventoryGrid.CurrentCell.RowIndex].quantity.ToString();
                selectBox.SelectedIndex = index;

            }
            catch (Exception error)
            {
                Console.WriteLine("There hase been an error: " + error);
            }
        }

        public void UC_Inventory_Load(object sender, EventArgs e)
        {
            LoadInventoryGrid();
            
            inventoryGrid.DataSource = productsTable;     
        }

        public static void LoadInventoryGrid()
        {
            if (productsTable.Columns.Count == 0)
            {
                productsTable.Columns.Add("Name");
                productsTable.Columns.Add("Price");
                productsTable.Columns.Add("Quantity", typeof(int));
                productsTable.Columns.Add("Category");
                inventoryList.Add(new Product("Mobil", "399", 10, Categories.Electronics));
                productsTable.Rows.Add("Mobil", "399$", 10, "Electronics");
                inventoryList.Add(new Product("Alvedon", "18", 23, Categories.Pharmacy));
                productsTable.Rows.Add("Alvedon", "18$", 23, "Pharmacy");
                inventoryList.Add(new Product("Äpple", "1", 1000, Categories.Grocery));
                productsTable.Rows.Add("Äpple", "1$", 1000, "Grocery");
                topProducts.Add(new TopProduct("Mobil", 1));
                topProducts.Add(new TopProduct("Alvedon", 2));
                topProducts.Add(new TopProduct("Äpple", 2));
            }
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
