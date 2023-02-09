namespace Bunfiu_TEst.UserControls
{
    partial class UC_Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            this.label1 = new System.Windows.Forms.Label();
            this.revenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.productsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateLast = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.last30daysBtn = new Guna.UI2.WinForms.Guna2Button();
            this.last7daysBtn = new Guna.UI2.WinForms.Guna2Button();
            this.todayBtn = new Guna.UI2.WinForms.Guna2Button();
            this.customBtn = new Guna.UI2.WinForms.Guna2Button();
            this.okBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.orderLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.revenueLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.profitLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.soldProducts = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.customerLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.productsLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsChart)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dashboard";
            // 
            // revenueChart
            // 
            chartArea3.AxisX.LineColor = System.Drawing.Color.Blue;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisY.LabelStyle.Format = "${0}";
            chartArea3.AxisY.LineColor = System.Drawing.Color.Blue;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea3.Name = "ChartArea1";
            this.revenueChart.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Name = "Legend1";
            this.revenueChart.Legends.Add(legend3);
            this.revenueChart.Location = new System.Drawing.Point(17, 133);
            this.revenueChart.Name = "revenueChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            this.revenueChart.Series.Add(series3);
            this.revenueChart.Size = new System.Drawing.Size(550, 257);
            this.revenueChart.TabIndex = 4;
            this.revenueChart.Text = "chart1";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.Blue;
            title3.Name = "Title1";
            title3.Text = "Revenue";
            this.revenueChart.Titles.Add(title3);
            // 
            // productsChart
            // 
            chartArea4.Name = "ChartArea1";
            this.productsChart.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.productsChart.Legends.Add(legend4);
            this.productsChart.Location = new System.Drawing.Point(585, 133);
            this.productsChart.Name = "productsChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.productsChart.Series.Add(series4);
            this.productsChart.Size = new System.Drawing.Size(340, 411);
            this.productsChart.TabIndex = 6;
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.ForeColor = System.Drawing.Color.Blue;
            title4.Name = "Title1";
            title4.Text = "Top 5 products";
            this.productsChart.Titles.Add(title4);
            // 
            // dateStart
            // 
            this.dateStart.AutoRoundedCorners = true;
            this.dateStart.BorderRadius = 12;
            this.dateStart.CheckedState.Parent = this.dateStart;
            this.dateStart.FillColor = System.Drawing.Color.Blue;
            this.dateStart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.ForeColor = System.Drawing.Color.White;
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.HoverState.Parent = this.dateStart;
            this.dateStart.Location = new System.Drawing.Point(179, 11);
            this.dateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.ShadowDecoration.Parent = this.dateStart;
            this.dateStart.Size = new System.Drawing.Size(119, 27);
            this.dateStart.TabIndex = 7;
            this.dateStart.Value = new System.DateTime(2023, 2, 8, 19, 55, 21, 514);
            // 
            // dateLast
            // 
            this.dateLast.AutoRoundedCorners = true;
            this.dateLast.BorderRadius = 12;
            this.dateLast.CheckedState.Parent = this.dateLast;
            this.dateLast.FillColor = System.Drawing.Color.Blue;
            this.dateLast.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLast.ForeColor = System.Drawing.Color.White;
            this.dateLast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLast.HoverState.Parent = this.dateLast;
            this.dateLast.Location = new System.Drawing.Point(332, 11);
            this.dateLast.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateLast.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateLast.Name = "dateLast";
            this.dateLast.ShadowDecoration.Parent = this.dateLast;
            this.dateLast.Size = new System.Drawing.Size(119, 27);
            this.dateLast.TabIndex = 8;
            this.dateLast.Value = new System.DateTime(2023, 2, 8, 19, 58, 15, 174);
            // 
            // last30daysBtn
            // 
            this.last30daysBtn.Animated = true;
            this.last30daysBtn.AutoRoundedCorners = true;
            this.last30daysBtn.BorderColor = System.Drawing.Color.Blue;
            this.last30daysBtn.BorderRadius = 12;
            this.last30daysBtn.BorderThickness = 3;
            this.last30daysBtn.CheckedState.Parent = this.last30daysBtn;
            this.last30daysBtn.CustomImages.Parent = this.last30daysBtn;
            this.last30daysBtn.FillColor = System.Drawing.Color.Navy;
            this.last30daysBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last30daysBtn.ForeColor = System.Drawing.Color.White;
            this.last30daysBtn.HoverState.Parent = this.last30daysBtn;
            this.last30daysBtn.Location = new System.Drawing.Point(830, 11);
            this.last30daysBtn.Name = "last30daysBtn";
            this.last30daysBtn.ShadowDecoration.Parent = this.last30daysBtn;
            this.last30daysBtn.Size = new System.Drawing.Size(95, 27);
            this.last30daysBtn.TabIndex = 10;
            this.last30daysBtn.Text = "Last 30 days";
            // 
            // last7daysBtn
            // 
            this.last7daysBtn.Animated = true;
            this.last7daysBtn.AutoRoundedCorners = true;
            this.last7daysBtn.BorderColor = System.Drawing.Color.Blue;
            this.last7daysBtn.BorderRadius = 12;
            this.last7daysBtn.BorderThickness = 3;
            this.last7daysBtn.CheckedState.Parent = this.last7daysBtn;
            this.last7daysBtn.CustomImages.Parent = this.last7daysBtn;
            this.last7daysBtn.FillColor = System.Drawing.Color.Navy;
            this.last7daysBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last7daysBtn.ForeColor = System.Drawing.Color.White;
            this.last7daysBtn.HoverState.Parent = this.last7daysBtn;
            this.last7daysBtn.Location = new System.Drawing.Point(729, 11);
            this.last7daysBtn.Name = "last7daysBtn";
            this.last7daysBtn.ShadowDecoration.Parent = this.last7daysBtn;
            this.last7daysBtn.Size = new System.Drawing.Size(95, 27);
            this.last7daysBtn.TabIndex = 11;
            this.last7daysBtn.Text = "Last 7 days";
            // 
            // todayBtn
            // 
            this.todayBtn.Animated = true;
            this.todayBtn.AutoRoundedCorners = true;
            this.todayBtn.BorderColor = System.Drawing.Color.Blue;
            this.todayBtn.BorderRadius = 12;
            this.todayBtn.BorderThickness = 3;
            this.todayBtn.CheckedState.Parent = this.todayBtn;
            this.todayBtn.CustomImages.Parent = this.todayBtn;
            this.todayBtn.FillColor = System.Drawing.Color.Navy;
            this.todayBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayBtn.ForeColor = System.Drawing.Color.White;
            this.todayBtn.HoverState.Parent = this.todayBtn;
            this.todayBtn.Location = new System.Drawing.Point(628, 11);
            this.todayBtn.Name = "todayBtn";
            this.todayBtn.ShadowDecoration.Parent = this.todayBtn;
            this.todayBtn.Size = new System.Drawing.Size(95, 27);
            this.todayBtn.TabIndex = 12;
            this.todayBtn.Text = "Today";
            // 
            // customBtn
            // 
            this.customBtn.Animated = true;
            this.customBtn.AutoRoundedCorners = true;
            this.customBtn.BorderColor = System.Drawing.Color.Blue;
            this.customBtn.BorderRadius = 12;
            this.customBtn.BorderThickness = 3;
            this.customBtn.CheckedState.Parent = this.customBtn;
            this.customBtn.CustomImages.Parent = this.customBtn;
            this.customBtn.FillColor = System.Drawing.Color.Navy;
            this.customBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customBtn.ForeColor = System.Drawing.Color.White;
            this.customBtn.HoverState.Parent = this.customBtn;
            this.customBtn.Location = new System.Drawing.Point(527, 11);
            this.customBtn.Name = "customBtn";
            this.customBtn.ShadowDecoration.Parent = this.customBtn;
            this.customBtn.Size = new System.Drawing.Size(95, 27);
            this.customBtn.TabIndex = 13;
            this.customBtn.Text = "Custom";
            // 
            // okBtn
            // 
            this.okBtn.Animated = true;
            this.okBtn.AutoRoundedCorners = true;
            this.okBtn.BorderColor = System.Drawing.Color.Blue;
            this.okBtn.BorderRadius = 11;
            this.okBtn.BorderThickness = 3;
            this.okBtn.CheckedState.Parent = this.okBtn;
            this.okBtn.CustomImages.Parent = this.okBtn;
            this.okBtn.FillColor = System.Drawing.Color.Navy;
            this.okBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.HoverState.Parent = this.okBtn;
            this.okBtn.Location = new System.Drawing.Point(480, 11);
            this.okBtn.Name = "okBtn";
            this.okBtn.ShadowDecoration.Parent = this.okBtn;
            this.okBtn.Size = new System.Drawing.Size(25, 27);
            this.okBtn.TabIndex = 14;
            this.okBtn.Text = "Ok";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel1.Controls.Add(this.orderLabel);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(17, 54);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(223, 68);
            this.guna2Panel1.TabIndex = 15;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Location = new System.Drawing.Point(3, 11);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(51, 53);
            this.guna2ImageButton1.TabIndex = 2;
            // 
            // orderLabel
            // 
            this.orderLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.ForeColor = System.Drawing.Color.Blue;
            this.orderLabel.Location = new System.Drawing.Point(68, 40);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(43, 23);
            this.orderLabel.TabIndex = 1;
            this.orderLabel.Text = "1000";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Blue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(68, 11);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(152, 23);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Number of orders";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.guna2ImageButton2);
            this.guna2Panel2.Controls.Add(this.revenueLabel);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Location = new System.Drawing.Point(258, 54);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(309, 68);
            this.guna2Panel2.TabIndex = 16;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton2.Location = new System.Drawing.Point(25, 10);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(51, 53);
            this.guna2ImageButton2.TabIndex = 3;
            // 
            // revenueLabel
            // 
            this.revenueLabel.BackColor = System.Drawing.Color.Transparent;
            this.revenueLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueLabel.ForeColor = System.Drawing.Color.Blue;
            this.revenueLabel.Location = new System.Drawing.Point(92, 42);
            this.revenueLabel.Name = "revenueLabel";
            this.revenueLabel.Size = new System.Drawing.Size(43, 23);
            this.revenueLabel.TabIndex = 2;
            this.revenueLabel.Text = "1000";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Blue;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(92, 12);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(129, 23);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Total Revenue";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.guna2ImageButton3);
            this.guna2Panel3.Controls.Add(this.profitLabel);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel3.Location = new System.Drawing.Point(585, 54);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(340, 68);
            this.guna2Panel3.TabIndex = 17;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton3.Location = new System.Drawing.Point(14, 11);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Size = new System.Drawing.Size(51, 53);
            this.guna2ImageButton3.TabIndex = 4;
            // 
            // profitLabel
            // 
            this.profitLabel.BackColor = System.Drawing.Color.Transparent;
            this.profitLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitLabel.ForeColor = System.Drawing.Color.Blue;
            this.profitLabel.Location = new System.Drawing.Point(84, 40);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(43, 23);
            this.profitLabel.TabIndex = 3;
            this.profitLabel.Text = "1000";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Blue;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(84, 11);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(97, 23);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Total Profit";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.White;
            this.guna2Panel4.Controls.Add(this.soldProducts);
            this.guna2Panel4.Controls.Add(this.customerLabel);
            this.guna2Panel4.Controls.Add(this.productsLabel);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel4.Controls.Add(this.sad);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel4.Location = new System.Drawing.Point(17, 400);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(550, 144);
            this.guna2Panel4.TabIndex = 16;
            // 
            // soldProducts
            // 
            this.soldProducts.BackColor = System.Drawing.Color.Transparent;
            this.soldProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldProducts.ForeColor = System.Drawing.Color.Cyan;
            this.soldProducts.Location = new System.Drawing.Point(407, 70);
            this.soldProducts.Name = "soldProducts";
            this.soldProducts.Size = new System.Drawing.Size(33, 23);
            this.soldProducts.TabIndex = 9;
            this.soldProducts.Text = "100";
            // 
            // customerLabel
            // 
            this.customerLabel.BackColor = System.Drawing.Color.Transparent;
            this.customerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.customerLabel.Location = new System.Drawing.Point(224, 70);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(33, 23);
            this.customerLabel.TabIndex = 8;
            this.customerLabel.Text = "100";
            // 
            // productsLabel
            // 
            this.productsLabel.BackColor = System.Drawing.Color.Transparent;
            this.productsLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.ForeColor = System.Drawing.Color.Red;
            this.productsLabel.Location = new System.Drawing.Point(17, 70);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(33, 23);
            this.productsLabel.TabIndex = 7;
            this.productsLabel.Text = "100";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Cyan;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(407, 41);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(122, 23);
            this.guna2HtmlLabel8.TabIndex = 6;
            this.guna2HtmlLabel8.Text = "Sold products";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Lime;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(224, 41);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(94, 23);
            this.guna2HtmlLabel7.TabIndex = 5;
            this.guna2HtmlLabel7.Text = "Customers";
            // 
            // sad
            // 
            this.sad.BackColor = System.Drawing.Color.Transparent;
            this.sad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sad.ForeColor = System.Drawing.Color.Red;
            this.sad.Location = new System.Drawing.Point(17, 41);
            this.sad.Name = "sad";
            this.sad.Size = new System.Drawing.Size(79, 23);
            this.sad.TabIndex = 4;
            this.sad.Text = "Products";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(210, 6);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(131, 23);
            this.guna2HtmlLabel5.TabIndex = 3;
            this.guna2HtmlLabel5.Text = "Total Counters";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Blue;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(309, 8);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(12, 32);
            this.guna2HtmlLabel4.TabIndex = 3;
            this.guna2HtmlLabel4.Text = "-";
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.customBtn);
            this.Controls.Add(this.todayBtn);
            this.Controls.Add(this.last7daysBtn);
            this.Controls.Add(this.last30daysBtn);
            this.Controls.Add(this.dateLast);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.productsChart);
            this.Controls.Add(this.revenueChart);
            this.Controls.Add(this.label1);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(942, 560);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsChart)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart revenueChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart productsChart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateLast;
        private Guna.UI2.WinForms.Guna2Button last30daysBtn;
        private Guna.UI2.WinForms.Guna2Button last7daysBtn;
        private Guna.UI2.WinForms.Guna2Button todayBtn;
        private Guna.UI2.WinForms.Guna2Button customBtn;
        private Guna.UI2.WinForms.Guna2Button okBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel orderLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel revenueLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel profitLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel soldProducts;
        private Guna.UI2.WinForms.Guna2HtmlLabel customerLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel productsLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel sad;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}
