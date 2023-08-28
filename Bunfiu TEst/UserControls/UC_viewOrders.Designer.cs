namespace Inventory_App.UserControls3
{
    partial class UC_viewOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.viewOrdersGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrdersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.viewOrdersGrid);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Cyan;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Cyan;
            this.guna2GradientPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientPanel1.ForeColor = System.Drawing.Color.DarkRed;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(161, 116);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(634, 396);
            this.guna2GradientPanel1.TabIndex = 5;
            // 
            // viewOrdersGrid
            // 
            this.viewOrdersGrid.AllowUserToAddRows = false;
            this.viewOrdersGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.viewOrdersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewOrdersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewOrdersGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewOrdersGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewOrdersGrid.GridColor = System.Drawing.Color.Silver;
            this.viewOrdersGrid.Location = new System.Drawing.Point(17, 3);
            this.viewOrdersGrid.MultiSelect = false;
            this.viewOrdersGrid.Name = "viewOrdersGrid";
            this.viewOrdersGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewOrdersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.viewOrdersGrid.RowHeadersVisible = false;
            this.viewOrdersGrid.RowHeadersWidth = 25;
            this.viewOrdersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.viewOrdersGrid.RowTemplate.Height = 25;
            this.viewOrdersGrid.Size = new System.Drawing.Size(599, 379);
            this.viewOrdersGrid.TabIndex = 2;
            this.viewOrdersGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.viewOrdersGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.viewOrdersGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.viewOrdersGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.viewOrdersGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.viewOrdersGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.viewOrdersGrid.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.viewOrdersGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Cyan;
            this.viewOrdersGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.viewOrdersGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrdersGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.viewOrdersGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewOrdersGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.viewOrdersGrid.ThemeStyle.ReadOnly = true;
            this.viewOrdersGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.viewOrdersGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewOrdersGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrdersGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.viewOrdersGrid.ThemeStyle.RowsStyle.Height = 25;
            this.viewOrdersGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewOrdersGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.BorderColor = System.Drawing.Color.Cyan;
            this.searchBox.BorderRadius = 20;
            this.searchBox.BorderThickness = 2;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.Red;
            this.searchBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.searchBox.FocusedState.PlaceholderForeColor = System.Drawing.Color.LightSkyBlue;
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Cyan;
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.searchBox.IconRightOffset = new System.Drawing.Point(5, 0);
            this.searchBox.IconRightSize = new System.Drawing.Size(30, 30);
            this.searchBox.Location = new System.Drawing.Point(161, 54);
            this.searchBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.Cyan;
            this.searchBox.PlaceholderText = "Sök efter produkt id här...";
            this.searchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchBox.SelectedText = "";
            this.searchBox.ShadowDecoration.Depth = 15;
            this.searchBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.searchBox.Size = new System.Drawing.Size(470, 45);
            this.searchBox.TabIndex = 9;
            this.searchBox.TextOffset = new System.Drawing.Point(5, 0);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Animated = true;
            this.searchBtn.AutoRoundedCorners = true;
            this.searchBtn.BackColor = System.Drawing.SystemColors.Control;
            this.searchBtn.BorderRadius = 21;
            this.searchBtn.FillColor = System.Drawing.Color.Cyan;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.searchBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.searchBtn.Location = new System.Drawing.Point(639, 54);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(156, 45);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Sök";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // UC_viewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UC_viewOrders";
            this.Size = new System.Drawing.Size(942, 560);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewOrdersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView viewOrdersGrid;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
    }
}
