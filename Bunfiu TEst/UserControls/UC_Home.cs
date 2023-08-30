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
using System.Windows.Forms.DataVisualization.Charting;

namespace Bunfiu_TEst.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
            UC_Orders.LoadOrderData(); //Hämtar order datan från json
            LoadProductChart();
            LoadTopProducts();

            orderLabel.Text = UC_Orders.OrdersList.Count.ToString(); //Alla texter i översikten
            revenueLabel.Text = getTotalRevenue().ToString() + "kr";
            profitLabel.Text = getTotalProfit().ToString() + "kr";
            productsLabel.Text = UC_Inventory.inventoryList.Count.ToString();
            customerLabel.Text = UC_Customers.customerList.Count.ToString();
            soldProducts.Text = getTotalsoldProducts().ToString();
        }

        private void LoadProductChart() //Stapel diagramet
        {
            ProductChart.Series.Clear();

            Series series = new Series("Lager");
            series.ChartType = SeriesChartType.Column;

            foreach(Inventory_App.Product product in UC_Inventory.inventoryList)
            {
                series.Points.AddXY(product.Namn, product.Kvantitet);
            }
            ProductChart.Series.Add(series);
        }

        private void LoadTopProducts() //Cirkel diagramet
        {

            TopProduct.Series.Clear();

            Series series = new Series("Mest sålda produkter");
            series.ChartType = SeriesChartType.Doughnut;

            foreach(Inventory_App.Product product in UC_Inventory.inventoryList)
            {
                series.Points.AddXY(product.Namn, product.Sålda);
            }

            TopProduct.Series.Add(series);
            TopProduct.Series["Mest sålda produkter"].Label = "#VALX: #VALY";
        }
        private double getTotalRevenue()
        {
            double totalRevenue = 0;
            foreach(Order order in UC_Orders.OrdersList)
            {   
                totalRevenue += order.Summa;        
            }    
            return totalRevenue;
        }

        private double getTotalProfit()
        {
            return Math.Round(getTotalRevenue() * 0.20);   
        }

        private int getTotalsoldProducts()
        {
            int totalSoldProducts = 0;
            foreach (Order order in UC_Orders.OrdersList)
            {
                totalSoldProducts += order.Produkter;
            }
            return totalSoldProducts;
        }
    }
}
