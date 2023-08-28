using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_App.UserControls;
using Inventory_App;
using System.IO;
using System.Text.Json;
using Inventory_App.Classes;

namespace Bunfiu_TEst.UserControls
{
    public partial class UC_Orders : UserControl
    {
        private static List<OrderItem> OneOrder = new List<OrderItem>();

        public static List<Order> OrdersList = new List<Order>();

        private static double totalOrdersPrice = 0;
        private static int totalProducts = 0;
        private static string path = @"C:\Users\Noel Nevrén\Desktop\Saker\Code\Projects in VS\Bunfiu TEst\Bunfiu TEst\Json\orders.json";
        public UC_Orders()
        {
            InitializeComponent();
            RefreshGrids();
            datePicker.Value = DateTime.Today;
            orderGrid.Enabled = false;
        }

        public static void LoadOrderData()
        {
            OrdersList = JSONUtility.GetData(path, OrdersList);
            GenerateId.LoadIds(OrdersList, GenerateId.UsedProductIds);
        }
        public static void UpdateJsonFile()
        {
            JSONUtility.UpdateJsonFile(path, OrdersList);
        }
        private void RefreshGrids() //Hämtar all data från json och refreshar grids
        { 
            LoadOrderData();
            orderGrid.DataSource = null;
            orderGrid.DataSource = OneOrder;
            UC_Inventory.LoadInventoryData();
            inventoryGrid.DataSource = UC_Inventory.inventoryList;
            UC_Customers.LoadCustomerData();
            Customer.LoadOrders();
            customerGrid.DataSource = UC_Customers.customerList;

            if (orderGrid.Columns.Count > 4) //Tar bort produkt kolumnen
            {
                foreach(DataGridViewColumn column in orderGrid.Columns)
                {
                    if(column.ValueType == typeof(Product))
                    {
                        orderGrid.Columns.Remove(column);
                        break;
                    }
                }
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            if(int.TryParse(quantityText.Text, out int quantity))
            {
                Product product = UC_Inventory.inventoryList[inventoryGrid.CurrentCell.RowIndex]; //Hämtar vald produkt
                if (product.InStock())
                {
                        if (ExistingItem(product, out OrderItem item)) //Om produkten redan finns uppdateras pris samt kvantiteten
                        {
                            item.AddQuantity(quantity);
                            item.calculateTotalPrice();
                        }
                        else //Om produkten inte är tillagd läggs den till här
                        {
                            OrderItem orderitem = new OrderItem { Namn = product.Namn, Product = product, Kvantitet = quantity, Pris = product.Pris, Summa = quantity * product.Pris, Id = product.Id };
                            OneOrder.Add(orderitem);
                        }

                        totalOrdersPrice += product.Pris * Convert.ToDouble(quantity);
                        totalProducts += quantity;
                        product.Kvantitet -= quantity;
                        product.Sålda += quantity;
                    
                    }
                
                else
                {
                    MessageBox.Show("Det finns inte " + quantity + " av den produkten");
                }

                UC_Inventory.UpdateJsonFile();
                RefreshGrids();
            }
            else
            {
                MessageBox.Show("Ange siffor");
            }
           
        }

        private void newBtn_Click(object sender, EventArgs e) //Godkänn order knapp
        {
            if(OneOrder.Count > 0)
            {
               
                DateTime date = datePicker.Value;
                Customer customer = UC_Customers.customerList[customerGrid.CurrentCell.RowIndex];
                customer.AddOrder();
                        
                Order order = new Order { Id = GenerateId.GenerateUniqueId(GenerateId.UsedOrderIds), Customer = customer, Datum = date, OrderList = OneOrder, Summa = totalOrdersPrice, Produkter = totalProducts };
                OrdersList.Add(order);
                            
                UC_Inventory.CalculateSoldItems();

                //Updaterar alla json filer och refreshar alla grids
                UpdateJsonFile();
                UC_Inventory.UpdateJsonFile();
                UC_Customers.UpdateJsonFile();
                RefreshGrids();

                //För att undvika att sätta till tom lista
                orderGrid.DataSource = null;
                OneOrder.Clear();
                orderGrid.DataSource = OneOrder;
                totalOrdersPrice = 0;
                totalProducts = 0;
                
            }
            else
            {
                MessageBox.Show("Du måste lägga till minst en produkt");
            }
        }

        private void customerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nameText.Text = UC_Customers.customerList[customerGrid.CurrentCell.RowIndex].Namn;
            idText.Text = UC_Customers.customerList[customerGrid.CurrentCell.RowIndex].Id.ToString();
        }

        private bool ExistingItem(Product product, out OrderItem itm)
        {
            foreach(OrderItem item in OneOrder)
            {
                if(item.Product.Id == product.Id)
                {
                    itm = item;
                    return true;
                }
            }
            itm = null;
            return false;
        }

    }
}
