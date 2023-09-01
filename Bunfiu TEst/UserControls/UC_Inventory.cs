using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Inventory_App;
using Inventory_App.Classes;

namespace Bunfiu_TEst.UserControls
{
    public partial class UC_Inventory : UserControl
    {
        public static List<Product> inventoryList = new List<Product>();
        private static string path = @"C:\Users\Noel Nevrén\Desktop\Saker\Code\Projects in VS\Bunfiu TEst\Bunfiu TEst\Json\products.json";

        public UC_Inventory()
        {
            InitializeComponent();
            RefreshInventoryGrid();
        }
        public static void LoadInventoryData()
        {
            inventoryList = JSONUtility.GetData(path, inventoryList);
            GenerateId.LoadIds(inventoryList, GenerateId.UsedProductIds);
        }
        public static void UpdateJsonFile()
        {
            JSONUtility.UpdateJsonFile(path, inventoryList);
        }
        private void RefreshInventoryGrid()
        {
            LoadInventoryData();
            inventoryGrid.DataSource = inventoryList;
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
                if(Double.TryParse(priceText.Text, out double price) && Int64.TryParse(quantityText.Text, out long quantity)) //Kollar så det går att konvertera fälten till long och double
                {
                    string name = nameText.Text;
                    int index = selectBox.SelectedIndex;

                    Product pro = new Product { Namn = name, Pris = price, Kvantitet = quantity, Kategori = (Categories)index, Sålda = 0, Id = GenerateId.GenerateUniqueId(GenerateId.UsedProductIds) };
                    inventoryList.Add(pro);

                    UpdateJsonFile();
                    RefreshInventoryGrid();
                    newBtn_Click(sender, e);

                }    
                else
                {
                    MessageBox.Show("Ange siffor i kvantitet och pris fälten");
                }
            }
            else
            {
                MessageBox.Show("Fyll i alla fält");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(priceText.Text, out double price) && Int64.TryParse(quantityText.Text, out long quantity)) //Kollar så det går att konvertera fälten till long och double
            {
                string name = nameText.Text;
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

         private void searchBox_TextChanged(object sender, EventArgs e) //Om texten i sökfältet ändras körs sökmetoden
         {
            List<Product> FilteredList = new List<Product>(); //Lista med de produkter som går igenom sök

             if(searchBox.Text == "") //Om texten i sökfältet är tom sätts griden tillbaka till vanliga inventorylist
             {
                inventoryGrid.DataSource = inventoryList;
             }
             else
             {
                foreach (Product product in inventoryList)
                 {
                    if (product.Namn.ToLower().Contains(searchBox.Text.ToLower())) //Använder contains metod för att kolla om namnet på produkten innehåller söktexten
                    {
                            FilteredList.Add(product); //Isåfall läggs den till i den filtrerade listan
                    }
                 }
                inventoryGrid.DataSource = FilteredList;
             }
         }



    }
}
