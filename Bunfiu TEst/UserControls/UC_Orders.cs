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
        private static List<OrderItem> OneOrder = new List<OrderItem>(); //Lista med produkterna i ordern som pågar just nu
        public static List<Order> OrdersList = new List<Order>(); //Lista med alla ordrar

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

        public Inventory_App.UserControls3.UC_viewOrders UC_viewOrders
        {
            get => default;
            set
            {
            }
        }

        public Email Email
        {
            get => default;
            set
            {
            }
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

            if (orderGrid.Columns.Count > 4) //Tar bort produkt kolumnen då den inte behövs
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
            if(int.TryParse(quantityText.Text, out int quantity)) //Går att konvertera till int
            {
                Product product = UC_Inventory.inventoryList[inventoryGrid.CurrentCell.RowIndex]; //Hämtar vald produkt i griden
                if (product.InStock(quantity)) //Kollar om det finns tillräckligt av produkten
                {
                    bool itemExists = true;
                        if (ExistingItem(product, out OrderItem item)) //Om produkten redan finns tillagd uppdateras den befintliga produkten i ordern
                        {
                            if (quantity < 0 && Math.Abs(quantity) > item.Kvantitet) //Kollar om det finns tillräckligt med produkter för att ta bort alla
                            {
                                MessageBox.Show("Du kan inte ta bort fler produkter än du lagt till");
                                itemExists = false;
                            }
                            else
                            {
                                item.AddQuantity(quantity);
                                item.calculateTotalPrice();
                                if (!item.CheckQuantity()) //Om produktens kvantitet är noll tas den bort från ordern
                                {
                                    OneOrder.Remove(item);
                                }
                            }
                        }
                        else //Om produkten inte är tillagd än läggs den till här
                        {
                           if(quantity > 0) //För att inte kunna lägga till negativt antal produkter
                            {
                                OrderItem orderitem = new OrderItem { Namn = product.Namn, Product = product, Kvantitet = quantity, Pris = product.Pris, Summa = quantity * product.Pris, Id = product.Id };
                                OneOrder.Add(orderitem);
                            }
                           else
                            {
                                itemExists = false;
                            }
                        }
                        if(itemExists) //Uppdateras endast om det man vill lägga till/ta bort är möjligt
                        {
                            totalOrdersPrice += product.Pris * Convert.ToDouble(quantity);
                            product.Sålda += quantity;
                            totalProducts += quantity;
                            product.Kvantitet -= quantity;
                        }
                }    
                else
                {
                    MessageBox.Show("Det finns inte " + quantity + " av den produkten i lager");
                }

                UC_Inventory.UpdateJsonFile();
                RefreshGrids();
            }
            else
            {
                MessageBox.Show("Ange siffor");
            }
           
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            if(OneOrder.Count > 0)
            {
               
                DateTime date = datePicker.Value;
                Customer customer = UC_Customers.customerList[customerGrid.CurrentCell.RowIndex];
                customer.AddOrder(); //Uppdaterar order variablen för kunden
                        
                Order order = new Order { Id = GenerateId.GenerateUniqueId(GenerateId.UsedOrderIds), Customer = customer, Datum = date, OrderList = OneOrder, Summa = totalOrdersPrice, Produkter = totalProducts };
                OrdersList.Add(order);

                Email.SendEmail(order, customer);

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

        private bool ExistingItem(Product product, out OrderItem searchItem) //Kollar om produkten redan finns tillagd i ordern
        {
            foreach(OrderItem item in OneOrder)
            {
                if(item.Product.Id == product.Id) //Om den finns använder jag out för att skicka tillbaka orderitem som redan fanns
                {
                    searchItem = item;
                    return true;
                }
            }
            searchItem = null;
            return false;
        }

        
    }
}
