namespace Inventory_App.UserControls
{
    partial class UC_Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customers));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.customerGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.newBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.editBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.mailText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.customerGrid);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Yellow;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Yellow;
            this.guna2GradientPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientPanel1.ForeColor = System.Drawing.Color.DarkRed;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(295, 39);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(634, 483);
            this.guna2GradientPanel1.TabIndex = 4;
            // 
            // customerGrid
            // 
            this.customerGrid.AllowUserToAddRows = false;
            this.customerGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.customerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerGrid.GridColor = System.Drawing.Color.Silver;
            this.customerGrid.Location = new System.Drawing.Point(17, 3);
            this.customerGrid.MultiSelect = false;
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.customerGrid.RowHeadersVisible = false;
            this.customerGrid.RowHeadersWidth = 25;
            this.customerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customerGrid.RowTemplate.Height = 25;
            this.customerGrid.Size = new System.Drawing.Size(599, 465);
            this.customerGrid.TabIndex = 2;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.customerGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.customerGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Yellow;
            this.customerGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customerGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.customerGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customerGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.customerGrid.ThemeStyle.ReadOnly = true;
            this.customerGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customerGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkRed;
            this.customerGrid.ThemeStyle.RowsStyle.Height = 25;
            this.customerGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.customerGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.customerGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGrid_CellDoubleClick);
            // 
            // newBtn
            // 
            this.newBtn.Animated = true;
            this.newBtn.AutoRoundedCorners = true;
            this.newBtn.BackColor = System.Drawing.SystemColors.Control;
            this.newBtn.BorderRadius = 21;
            this.newBtn.FillColor = System.Drawing.Color.Yellow;
            this.newBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.ForeColor = System.Drawing.Color.Black;
            this.newBtn.HoverState.FillColor = System.Drawing.Color.DarkKhaki;
            this.newBtn.Image = ((System.Drawing.Image)(resources.GetObject("newBtn.Image")));
            this.newBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.newBtn.Location = new System.Drawing.Point(12, 204);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(270, 45);
            this.newBtn.TabIndex = 5;
            this.newBtn.Text = "Ny";
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Animated = true;
            this.saveBtn.AutoRoundedCorners = true;
            this.saveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saveBtn.BorderRadius = 21;
            this.saveBtn.FillColor = System.Drawing.Color.Yellow;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.HoverState.FillColor = System.Drawing.Color.DarkKhaki;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.saveBtn.Location = new System.Drawing.Point(12, 295);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(270, 45);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Spara";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Animated = true;
            this.editBtn.AutoRoundedCorners = true;
            this.editBtn.BackColor = System.Drawing.SystemColors.Control;
            this.editBtn.BorderRadius = 21;
            this.editBtn.FillColor = System.Drawing.Color.Yellow;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.Black;
            this.editBtn.HoverState.FillColor = System.Drawing.Color.DarkKhaki;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.editBtn.Location = new System.Drawing.Point(12, 388);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(270, 45);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "Ändra";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Animated = true;
            this.deleteBtn.AutoRoundedCorners = true;
            this.deleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.BorderRadius = 21;
            this.deleteBtn.FillColor = System.Drawing.Color.Yellow;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.HoverState.FillColor = System.Drawing.Color.DarkKhaki;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.deleteBtn.Location = new System.Drawing.Point(12, 477);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(270, 45);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Radera";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.Color.Transparent;
            this.nameText.BorderColor = System.Drawing.Color.Yellow;
            this.nameText.BorderRadius = 20;
            this.nameText.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.nameText.BorderThickness = 3;
            this.nameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameText.DefaultText = "";
            this.nameText.DisabledState.BorderColor = System.Drawing.Color.White;
            this.nameText.DisabledState.FillColor = System.Drawing.Color.White;
            this.nameText.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.nameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.nameText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.nameText.FocusedState.BorderColor = System.Drawing.Color.DarkKhaki;
            this.nameText.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.nameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.ForeColor = System.Drawing.Color.Black;
            this.nameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nameText.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.nameText.IconRightOffset = new System.Drawing.Point(5, 0);
            this.nameText.IconRightSize = new System.Drawing.Size(30, 30);
            this.nameText.Location = new System.Drawing.Point(12, 39);
            this.nameText.Margin = new System.Windows.Forms.Padding(5);
            this.nameText.Name = "nameText";
            this.nameText.PasswordChar = '\0';
            this.nameText.PlaceholderForeColor = System.Drawing.Color.Orange;
            this.nameText.PlaceholderText = "Namn...";
            this.nameText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameText.SelectedText = "";
            this.nameText.ShadowDecoration.Depth = 15;
            this.nameText.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.nameText.Size = new System.Drawing.Size(270, 45);
            this.nameText.TabIndex = 10;
            this.nameText.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // mailText
            // 
            this.mailText.BackColor = System.Drawing.Color.Transparent;
            this.mailText.BorderColor = System.Drawing.Color.Yellow;
            this.mailText.BorderRadius = 20;
            this.mailText.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.mailText.BorderThickness = 3;
            this.mailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailText.DefaultText = "";
            this.mailText.DisabledState.BorderColor = System.Drawing.Color.White;
            this.mailText.DisabledState.FillColor = System.Drawing.Color.White;
            this.mailText.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.mailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.mailText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.mailText.FocusedState.BorderColor = System.Drawing.Color.DarkKhaki;
            this.mailText.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.mailText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailText.ForeColor = System.Drawing.Color.Black;
            this.mailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mailText.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.mailText.IconRightOffset = new System.Drawing.Point(5, 0);
            this.mailText.IconRightSize = new System.Drawing.Size(30, 30);
            this.mailText.Location = new System.Drawing.Point(12, 107);
            this.mailText.Margin = new System.Windows.Forms.Padding(5);
            this.mailText.Name = "mailText";
            this.mailText.PasswordChar = '\0';
            this.mailText.PlaceholderForeColor = System.Drawing.Color.Orange;
            this.mailText.PlaceholderText = "Mail...";
            this.mailText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mailText.SelectedText = "";
            this.mailText.ShadowDecoration.Depth = 15;
            this.mailText.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.mailText.Size = new System.Drawing.Size(270, 45);
            this.mailText.TabIndex = 11;
            this.mailText.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // UC_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mailText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UC_Customers";
            this.Size = new System.Drawing.Size(942, 560);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView customerGrid;
        private Guna.UI2.WinForms.Guna2Button newBtn;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2Button editBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2TextBox nameText;
        private Guna.UI2.WinForms.Guna2TextBox mailText;
    }
}
