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
using Bunfiu_TEst.UserControls;

namespace Bunfiu_TEst.UserControls
{
    public partial class UC_Home : UserControl
    {
        public DataTable data = new DataTable();
        public static List<RevenueByDate> dataList = new List<RevenueByDate>();
        public int totalRevenue = 0;
        public double totalProfit;
        public int totalSoldProducts = 0;
        int num = 0;
        public UC_Home()
        {
            InitializeComponent();
            dateStart.Value = DateTime.Today.AddDays(-7);
            dateLast.Value = DateTime.Now;
            last7daysBtn.Select();

            
        }

        private void LoadData()
        {
            
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            UC_Inventory.LoadInventoryGrid();
            UC_Customers.LoadCustomerGrid(sender, e);

            /* data.Columns.Add("Date", typeof(DateTime));
             data.Columns.Add("Revenue", typeof(decimal));

             // Add some sample data to the table
             data.Rows.Add(new object[] { new DateTime(2022, 1, 1), 100 });
             data.Rows.Add(new object[] { new DateTime(2022, 2, 1), 200 });
             data.Rows.Add(new object[] { new DateTime(2022, 3, 1), 300 });
            dataList.Add(new RevenueByDate(new DateTime(2022, 1, 1), 200));
            dataList.Add(new RevenueByDate(new DateTime(2022, 1, 4), 100));
            dataList.Add(new RevenueByDate(new DateTime(2022, 1, 5), 500));
             */

            dataList.Add(new RevenueByDate(new DateTime(2022, 1, 1), 200));
            dataList.Add(new RevenueByDate(new DateTime(2022, 1, 2), 500));
            dataList.Add(new RevenueByDate(new DateTime(2022, 1, 3), 300));
            dataList.Add(new RevenueByDate(new DateTime(2022, 1, 4), 700));
            dataList.Add(new RevenueByDate(new DateTime(2022, 1, 5), 800));
            dataList.Add(new RevenueByDate(new DateTime(2022, 1, 6), 1000));
            dataList.Add(new RevenueByDate(new DateTime(2022, 1, 7), 1500));



            orderLabel.Text = UC_Orders.OrdersList.Count.ToString();
            revenueLabel.Text = "$" + UC_Orders.totalOrdersPrice.ToString();
            profitLabel.Text = "$" + getTotalProfit().ToString();
            productsLabel.Text = UC_Inventory.inventoryList.Count.ToString();
            customerLabel.Text = UC_Customers.customerList.Count.ToString();
            //soldProducts.Text = getTotalsoldProducts().ToString();
            soldProducts.Text = UC_Orders.totalSoldProducts.ToString();

       
            

            revenueChart.DataSource = dataList;
            revenueChart.Series[0].XValueMember = "Date";
            revenueChart.Series[0].YValueMembers = "Revenue";
            revenueChart.DataBind();

            List<TopProduct> sortedTopProducts = UC_Inventory.topProducts.OrderByDescending(x => x.Quantity).ToList();

            foreach(TopProduct product in sortedTopProducts)
            {
                if(num == 5)
                {
                    break;
                }
                if(product.Quantity > 0)
                {
                    productsChart.Series[0].Points.AddXY(product.Name, product.Quantity);
                    num++;
                }   
            }


        }

         public int getTotalRevenue()
        {
            totalRevenue = 0;
            foreach(Order order in UC_Orders.OrdersList)
            {   
                totalRevenue += order.getTotalOrderPrice();         
            }

            return totalRevenue;
        }

        public double getTotalProfit()
        {
            totalProfit = Math.Round(UC_Orders.totalOrdersPrice * 0.25);
            return totalProfit;
        }

        public int getTotalsoldProducts()
        {
            foreach(Order order in UC_Orders.OrdersList)
            {
                totalSoldProducts += order.allProducts();
                MessageBox.Show(order.soldProducts.ToString());
            }
            return totalSoldProducts;
        }

      
        

        
    }
}
