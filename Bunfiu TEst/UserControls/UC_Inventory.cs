using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_App;
using Inventory_App.UserControls;
using Inventory_App.Classes;



namespace Bunfiu_TEst.UserControls
{
    public partial class UC_Inventory : UserControl
    {
        public static List<Product> inventoryList = new List<Product>();
        public string path = @"C:\Users\Noel Nevrén\Desktop\Saker\Code\Projects in VS\Bunfiu TEst\Bunfiu TEst\Json\products.json";

        public UC_Inventory()
        {
            InitializeComponent();
            RefreshInventoryGrid();
        }

        public void LoadInventoryData()
        {
            string jsonData = File.ReadAllText(path);
            inventoryList = JSONUtility.DeserializeListFromJson<Product>(jsonData);
            GenerateId.LoadProductIds(inventoryList);

        }
        public void UpdateJsonFile()
        {
            File.WriteAllText(path, JSONUtility.SerializeListToJson(inventoryList));
        }

        private void RefreshInventoryGrid()
        {
            LoadInventoryData();
            CalculateSoldItems();
            inventoryGrid.DataSource = inventoryList;
        }

        public void CalculateSoldItems()
        {
            foreach (Order order in UC_Orders.OrdersList)
            {
                foreach (OrderItem item in order.OrderList)
                {
                    item.Product.Sålda += item.Kvantitet;      
                }
            }
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
            if (nameText.Text != "" && priceText.Text != "" && quantityText.Text != "" && selectBox.SelectedIndex != -1)
            {
                string name = nameText.Text;
                double price = Convert.ToDouble(priceText.Text);
                long quantity = Convert.ToInt64(quantityText.Text);
                int index = selectBox.SelectedIndex;
                Product pro = new Product { Namn = name, Pris = price, Kvantitet = quantity, Kategori = (Categories)index, Sålda = 0, Id = GenerateId.GenerateUniqueId(GenerateId.UsedProductIds)};
                inventoryList.Add(pro);

                UpdateJsonFile();
                RefreshInventoryGrid();
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
            double price = Convert.ToDouble(priceText.Text);
            long quantity = Convert.ToInt64(quantityText.Text);
            int selected = selectBox.SelectedIndex;


            if (inventoryGrid.CurrentCell != null)
            {
                int index = inventoryGrid.CurrentCell.RowIndex;
                
                inventoryList[index].Namn = name;
                inventoryList[index].Pris = price;
                inventoryList[index].Kvantitet = quantity;
                inventoryList[index].Kategori = (Categories)selected;
            }

            UpdateJsonFile();
            RefreshInventoryGrid();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (inventoryGrid.CurrentCell != null)
            {
                int index = inventoryGrid.CurrentCell.RowIndex;            
                inventoryList.RemoveAt(index);
                UpdateJsonFile(); 
                RefreshInventoryGrid();    
            }
            else
            {
                MessageBox.Show("Välj en rad innan du raderar");
            }
        }

        private void inventoryGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(inventoryGrid.Rows.Count > 0)
            {
                try
                {
                    int index = (int)inventoryList[inventoryGrid.CurrentCell.RowIndex].Kategori;
                    nameText.Text = inventoryList[inventoryGrid.CurrentCell.RowIndex].Namn;
                    priceText.Text = inventoryList[inventoryGrid.CurrentCell.RowIndex].Pris.ToString();
                    quantityText.Text = inventoryList[inventoryGrid.CurrentCell.RowIndex].Kvantitet.ToString();
                    selectBox.SelectedIndex = index;

                }
                catch (Exception error)
                {
                    Console.WriteLine("Det har uppstått ett fel: " + error);
                }
            }          
        }

         private void searchBox_TextChanged(object sender, EventArgs e)
         {
            List<Product> FilteredList = new List<Product>();

             if(searchBox.Text == "")
             {
                inventoryGrid.DataSource = inventoryList;
             }
             else
             {
                foreach (Product pro in inventoryList)
                 {
                     if(pro.Namn.Length >= searchBox.Text.Length)
                     {
                         if (pro.Namn.Substring(0, searchBox.Text.Length).ToLower() == searchBox.Text.ToLower())
                         {
                            FilteredList.Add(pro);
                         }
                     }
                 }
                inventoryGrid.DataSource = FilteredList;
            }
         }



    }
}
