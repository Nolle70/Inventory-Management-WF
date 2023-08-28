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
        public static List<OrderItem> OneOrder = new List<OrderItem>();

        public static List<Order> OrdersList = new List<Order>();

        UC_Inventory inv = new UC_Inventory();
        UC_Customers cus = new UC_Customers();

        public static double totalOrdersPrice = 0;
        public static int totalSoldProducts = 0;
        public static int totalProducts = 0;
        string path = @"C:\Users\Noel Nevrén\Desktop\Saker\Code\Projects in VS\Bunfiu TEst\Bunfiu TEst\Json\orders.json";
        public UC_Orders()
        {
            InitializeComponent();

            RefreshGrids();
            datePicker.Value = DateTime.Today;
        }
        
        public void LoadOrderData()
        {
            string jsonData = File.ReadAllText(path);
            OrdersList = JSONUtility.DeserializeListFromJson<Order>(jsonData);
            GenerateId.LoadOrderIds(OrdersList);
        }
        public void UpdateJsonFile()
        {
            File.WriteAllText(path, JSONUtility.SerializeListToJson(OrdersList));
        }

        private void RefreshGrids() //Hämtar all data från json och refreshar grids
        { 
            LoadOrderData();
            orderGrid.DataSource = null;
            orderGrid.DataSource = OneOrder;
            inv.LoadInventoryData();
            inventoryGrid.DataSource = UC_Inventory.inventoryList;
            cus.LoadCustomerData();
            customerGrid.DataSource = UC_Customers.customerList;
            if (orderGrid.Columns.Count > 4)
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
            int quantity = Convert.ToInt32(quantityText.Text);
            Product product = UC_Inventory.inventoryList[inventoryGrid.CurrentCell.RowIndex]; //Hämtar vald produkt
            bool duplicateExist = false;
            if (product.Kvantitet >= quantity)
            {
                foreach(OrderItem item in OneOrder) // Kollar om den produkten redan finns tillagd isåfall ökar bara kvantiteten för den orderitem
                {
                    if(item.Product.Namn == product.Namn)
                    {
                        item.Kvantitet += quantity;
                        item.Summa = item.calculateTotalPrice();
                        duplicateExist = true;                     
                        break;
                    }
                }
                if(!duplicateExist) //Om produkten inte är tillagd läggs den till här
                {
                    OrderItem orderitem = new OrderItem { Namn = product.Namn, Product = product, Kvantitet = quantity, Pris = product.Pris, Summa = quantity * product.Pris};
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
                      
            inv.UpdateJsonFile();
            RefreshGrids();
        }

        private void newBtn_Click(object sender, EventArgs e) //Godkänn order knapp
        {
            if(OneOrder.Count > 0)
            {
               
                    DateTime date = datePicker.Value;
                    Customer customer = UC_Customers.customerList[customerGrid.CurrentCell.RowIndex];
                        
                    Order order = new Order { Id = GenerateId.GenerateUniqueId(GenerateId.UsedOrderIds), Customer = customer, Datum = date, OrderList = OneOrder, Summa = totalOrdersPrice, Produkter = totalProducts };
                    OrdersList.Add(order);
                            
                    inv.CalculateSoldItems();

                            //Updaterar alla json filer och refreshar alla grids
                    UpdateJsonFile();
                    inv.UpdateJsonFile();
                    cus.UpdateJsonFile();
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

        private bool CheckForDuplicateId(int id) //Kollar om order med det id redan finns
        {
            foreach(Order order in OrdersList)
            {
                if(order.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
