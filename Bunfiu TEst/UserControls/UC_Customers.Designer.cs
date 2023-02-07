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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customers));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.customerGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.newBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.editBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneText = new Guna.UI2.WinForms.Guna2TextBox();
            this.idText = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.guna2GradientPanel1.Location = new System.Drawing.Point(295, 9);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(634, 396);
            this.guna2GradientPanel1.TabIndex = 4;
            // 
            // customerGrid
            // 
            this.customerGrid.AllowUserToAddRows = false;
            this.customerGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.customerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.customerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerGrid.BackgroundColor = System.Drawing.Color.White;
            this.customerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.customerGrid.ColumnHeadersHeight = 30;
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.customerGrid.EnableHeadersVisualStyles = false;
            this.customerGrid.GridColor = System.Drawing.Color.Silver;
            this.customerGrid.Location = new System.Drawing.Point(17, 3);
            this.customerGrid.MultiSelect = false;
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.customerGrid.RowHeadersVisible = false;
            this.customerGrid.RowHeadersWidth = 25;
            this.customerGrid.RowTemplate.Height = 25;
            this.customerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGrid.Size = new System.Drawing.Size(599, 379);
            this.customerGrid.TabIndex = 2;
            this.customerGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
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
            this.customerGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customerGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.customerGrid.ThemeStyle.ReadOnly = true;
            this.customerGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customerGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
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
            this.newBtn.CheckedState.Parent = this.newBtn;
            this.newBtn.CustomImages.Parent = this.newBtn;
            this.newBtn.FillColor = System.Drawing.Color.Yellow;
            this.newBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.ForeColor = System.Drawing.Color.Black;
            this.newBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.newBtn.HoverState.Parent = this.newBtn;
            this.newBtn.Image = ((System.Drawing.Image)(resources.GetObject("newBtn.Image")));
            this.newBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.newBtn.Location = new System.Drawing.Point(12, 176);
            this.newBtn.Name = "newBtn";
            this.newBtn.ShadowDecoration.Parent = this.newBtn;
            this.newBtn.Size = new System.Drawing.Size(270, 45);
            this.newBtn.TabIndex = 5;
            this.newBtn.Text = "New";
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Animated = true;
            this.saveBtn.AutoRoundedCorners = true;
            this.saveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saveBtn.BorderRadius = 21;
            this.saveBtn.CheckedState.Parent = this.saveBtn;
            this.saveBtn.CustomImages.Parent = this.saveBtn;
            this.saveBtn.FillColor = System.Drawing.Color.Yellow;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.saveBtn.HoverState.Parent = this.saveBtn;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.saveBtn.Location = new System.Drawing.Point(12, 236);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.ShadowDecoration.Parent = this.saveBtn;
            this.saveBtn.Size = new System.Drawing.Size(270, 45);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Animated = true;
            this.editBtn.AutoRoundedCorners = true;
            this.editBtn.BackColor = System.Drawing.SystemColors.Control;
            this.editBtn.BorderRadius = 21;
            this.editBtn.CheckedState.Parent = this.editBtn;
            this.editBtn.CustomImages.Parent = this.editBtn;
            this.editBtn.FillColor = System.Drawing.Color.Yellow;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.Black;
            this.editBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.editBtn.HoverState.Parent = this.editBtn;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.editBtn.Location = new System.Drawing.Point(12, 298);
            this.editBtn.Name = "editBtn";
            this.editBtn.ShadowDecoration.Parent = this.editBtn;
            this.editBtn.Size = new System.Drawing.Size(270, 45);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "Edit";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Animated = true;
            this.deleteBtn.AutoRoundedCorners = true;
            this.deleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.BorderRadius = 21;
            this.deleteBtn.CheckedState.Parent = this.deleteBtn;
            this.deleteBtn.CustomImages.Parent = this.deleteBtn;
            this.deleteBtn.FillColor = System.Drawing.Color.Yellow;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.HoverState.Parent = this.deleteBtn;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.deleteBtn.Location = new System.Drawing.Point(12, 360);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ShadowDecoration.Parent = this.deleteBtn;
            this.deleteBtn.Size = new System.Drawing.Size(270, 45);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
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
            this.nameText.DisabledState.Parent = this.nameText;
            this.nameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.nameText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.nameText.FocusedState.BorderColor = System.Drawing.Color.Olive;
            this.nameText.FocusedState.Parent = this.nameText;
            this.nameText.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.nameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.ForeColor = System.Drawing.Color.Black;
            this.nameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nameText.HoverState.Parent = this.nameText;
            this.nameText.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.nameText.IconRightOffset = new System.Drawing.Point(5, 0);
            this.nameText.IconRightSize = new System.Drawing.Size(30, 30);
            this.nameText.Location = new System.Drawing.Point(12, 26);
            this.nameText.Margin = new System.Windows.Forms.Padding(5);
            this.nameText.Name = "nameText";
            this.nameText.PasswordChar = '\0';
            this.nameText.PlaceholderForeColor = System.Drawing.Color.Orange;
            this.nameText.PlaceholderText = "Name...";
            this.nameText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameText.SelectedText = "";
            this.nameText.ShadowDecoration.Depth = 15;
            this.nameText.ShadowDecoration.Parent = this.nameText;
            this.nameText.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.nameText.Size = new System.Drawing.Size(127, 45);
            this.nameText.TabIndex = 10;
            this.nameText.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // phoneText
            // 
            this.phoneText.BackColor = System.Drawing.Color.Transparent;
            this.phoneText.BorderColor = System.Drawing.Color.Yellow;
            this.phoneText.BorderRadius = 20;
            this.phoneText.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.phoneText.BorderThickness = 3;
            this.phoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneText.DefaultText = "";
            this.phoneText.DisabledState.BorderColor = System.Drawing.Color.White;
            this.phoneText.DisabledState.FillColor = System.Drawing.Color.White;
            this.phoneText.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.phoneText.DisabledState.Parent = this.phoneText;
            this.phoneText.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.phoneText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.phoneText.FocusedState.BorderColor = System.Drawing.Color.Olive;
            this.phoneText.FocusedState.Parent = this.phoneText;
            this.phoneText.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.phoneText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.ForeColor = System.Drawing.Color.Black;
            this.phoneText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.phoneText.HoverState.Parent = this.phoneText;
            this.phoneText.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.phoneText.IconRightOffset = new System.Drawing.Point(5, 0);
            this.phoneText.IconRightSize = new System.Drawing.Size(30, 30);
            this.phoneText.Location = new System.Drawing.Point(12, 96);
            this.phoneText.Margin = new System.Windows.Forms.Padding(5);
            this.phoneText.Name = "phoneText";
            this.phoneText.PasswordChar = '\0';
            this.phoneText.PlaceholderForeColor = System.Drawing.Color.Orange;
            this.phoneText.PlaceholderText = "Phone-number...";
            this.phoneText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.phoneText.SelectedText = "";
            this.phoneText.ShadowDecoration.Depth = 15;
            this.phoneText.ShadowDecoration.Parent = this.phoneText;
            this.phoneText.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.phoneText.Size = new System.Drawing.Size(270, 45);
            this.phoneText.TabIndex = 11;
            this.phoneText.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // idText
            // 
            this.idText.BackColor = System.Drawing.Color.Transparent;
            this.idText.BorderColor = System.Drawing.Color.Yellow;
            this.idText.BorderRadius = 20;
            this.idText.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.idText.BorderThickness = 3;
            this.idText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idText.DefaultText = "";
            this.idText.DisabledState.BorderColor = System.Drawing.Color.White;
            this.idText.DisabledState.FillColor = System.Drawing.Color.White;
            this.idText.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.idText.DisabledState.Parent = this.idText;
            this.idText.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.idText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.idText.FocusedState.BorderColor = System.Drawing.Color.Olive;
            this.idText.FocusedState.Parent = this.idText;
            this.idText.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.idText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.ForeColor = System.Drawing.Color.Black;
            this.idText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.idText.HoverState.Parent = this.idText;
            this.idText.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.idText.IconRightOffset = new System.Drawing.Point(5, 0);
            this.idText.IconRightSize = new System.Drawing.Size(30, 30);
            this.idText.Location = new System.Drawing.Point(160, 26);
            this.idText.Margin = new System.Windows.Forms.Padding(5);
            this.idText.Name = "idText";
            this.idText.PasswordChar = '\0';
            this.idText.PlaceholderForeColor = System.Drawing.Color.Orange;
            this.idText.PlaceholderText = "Id...";
            this.idText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idText.SelectedText = "";
            this.idText.ShadowDecoration.Depth = 15;
            this.idText.ShadowDecoration.Parent = this.idText;
            this.idText.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.idText.Size = new System.Drawing.Size(122, 45);
            this.idText.TabIndex = 12;
            this.idText.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // UC_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.idText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UC_Customers";
            this.Size = new System.Drawing.Size(942, 560);
            this.Load += new System.EventHandler(this.UC_Customers_Load);
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
        private Guna.UI2.WinForms.Guna2TextBox phoneText;
        private Guna.UI2.WinForms.Guna2TextBox idText;
    }
}
