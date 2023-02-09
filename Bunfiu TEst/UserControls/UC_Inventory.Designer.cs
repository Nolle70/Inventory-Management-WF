namespace Bunfiu_TEst.UserControls
{
    partial class UC_Inventory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Inventory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.newBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.inventoryGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.editBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceText = new Guna.UI2.WinForms.Guna2TextBox();
            this.quantityText = new Guna.UI2.WinForms.Guna2TextBox();
            this.selectBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2MouseStateHandler1 = new Guna.UI2.WinForms.Guna2MouseStateHandler(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // newBtn
            // 
            this.newBtn.Animated = true;
            this.newBtn.AutoRoundedCorners = true;
            this.newBtn.BackColor = System.Drawing.SystemColors.Control;
            this.newBtn.BorderRadius = 21;
            this.newBtn.CheckedState.Parent = this.newBtn;
            this.newBtn.CustomImages.Parent = this.newBtn;
            this.newBtn.FillColor = System.Drawing.Color.Red;
            this.newBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.ForeColor = System.Drawing.Color.White;
            this.newBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.newBtn.HoverState.Parent = this.newBtn;
            this.newBtn.Image = ((System.Drawing.Image)(resources.GetObject("newBtn.Image")));
            this.newBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.newBtn.Location = new System.Drawing.Point(17, 25);
            this.newBtn.Name = "newBtn";
            this.newBtn.ShadowDecoration.Parent = this.newBtn;
            this.newBtn.Size = new System.Drawing.Size(170, 45);
            this.newBtn.TabIndex = 4;
            this.newBtn.Text = "New";
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.inventoryGrid);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Crimson;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Crimson;
            this.guna2GradientPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientPanel1.ForeColor = System.Drawing.Color.DarkRed;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(17, 135);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(908, 415);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // inventoryGrid
            // 
            this.inventoryGrid.AllowUserToAddRows = false;
            this.inventoryGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.inventoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.inventoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGrid.BackgroundColor = System.Drawing.Color.White;
            this.inventoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.inventoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.inventoryGrid.ColumnHeadersHeight = 30;
            this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventoryGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.inventoryGrid.EnableHeadersVisualStyles = false;
            this.inventoryGrid.GridColor = System.Drawing.Color.LightGray;
            this.inventoryGrid.Location = new System.Drawing.Point(19, 3);
            this.inventoryGrid.MultiSelect = false;
            this.inventoryGrid.Name = "inventoryGrid";
            this.inventoryGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.inventoryGrid.RowHeadersVisible = false;
            this.inventoryGrid.RowHeadersWidth = 25;
            this.inventoryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.inventoryGrid.RowTemplate.Height = 25;
            this.inventoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryGrid.Size = new System.Drawing.Size(869, 393);
            this.inventoryGrid.TabIndex = 2;
            this.inventoryGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.inventoryGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.inventoryGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.inventoryGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.inventoryGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.inventoryGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.inventoryGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.inventoryGrid.ThemeStyle.GridColor = System.Drawing.Color.LightGray;
            this.inventoryGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
            this.inventoryGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.inventoryGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.inventoryGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.inventoryGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.inventoryGrid.ThemeStyle.ReadOnly = true;
            this.inventoryGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.inventoryGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.inventoryGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkRed;
            this.inventoryGrid.ThemeStyle.RowsStyle.Height = 25;
            this.inventoryGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inventoryGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.inventoryGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGrid_CellDoubleClick);
            // 
            // editBtn
            // 
            this.editBtn.Animated = true;
            this.editBtn.AutoRoundedCorners = true;
            this.editBtn.BackColor = System.Drawing.SystemColors.Control;
            this.editBtn.BorderRadius = 21;
            this.editBtn.CheckedState.Parent = this.editBtn;
            this.editBtn.CustomImages.Parent = this.editBtn;
            this.editBtn.FillColor = System.Drawing.Color.Red;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.editBtn.HoverState.Parent = this.editBtn;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.editBtn.Location = new System.Drawing.Point(389, 25);
            this.editBtn.Name = "editBtn";
            this.editBtn.ShadowDecoration.Parent = this.editBtn;
            this.editBtn.Size = new System.Drawing.Size(170, 45);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Animated = true;
            this.saveBtn.AutoRoundedCorners = true;
            this.saveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saveBtn.BorderRadius = 21;
            this.saveBtn.CheckedState.Parent = this.saveBtn;
            this.saveBtn.CustomImages.Parent = this.saveBtn;
            this.saveBtn.FillColor = System.Drawing.Color.Red;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.saveBtn.HoverState.Parent = this.saveBtn;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.saveBtn.Location = new System.Drawing.Point(203, 25);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.ShadowDecoration.Parent = this.saveBtn;
            this.saveBtn.Size = new System.Drawing.Size(170, 45);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Animated = true;
            this.deleteBtn.AutoRoundedCorners = true;
            this.deleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.BorderRadius = 21;
            this.deleteBtn.CheckedState.Parent = this.deleteBtn;
            this.deleteBtn.CustomImages.Parent = this.deleteBtn;
            this.deleteBtn.FillColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.HoverState.Parent = this.deleteBtn;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteBtn.Location = new System.Drawing.Point(574, 25);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ShadowDecoration.Parent = this.deleteBtn;
            this.deleteBtn.Size = new System.Drawing.Size(170, 45);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.BorderColor = System.Drawing.Color.Red;
            this.searchBox.BorderRadius = 20;
            this.searchBox.BorderThickness = 2;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.Parent = this.searchBox;
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.Red;
            this.searchBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchBox.FocusedState.Parent = this.searchBox;
            this.searchBox.FocusedState.PlaceholderForeColor = System.Drawing.Color.Red;
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Red;
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.searchBox.HoverState.Parent = this.searchBox;
            this.searchBox.IconRight = ((System.Drawing.Image)(resources.GetObject("searchBox.IconRight")));
            this.searchBox.IconRightOffset = new System.Drawing.Point(5, 0);
            this.searchBox.IconRightSize = new System.Drawing.Size(30, 30);
            this.searchBox.Location = new System.Drawing.Point(752, 51);
            this.searchBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.searchBox.PlaceholderText = "Search...";
            this.searchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchBox.SelectedText = "";
            this.searchBox.ShadowDecoration.Depth = 15;
            this.searchBox.ShadowDecoration.Parent = this.searchBox;
            this.searchBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.searchBox.Size = new System.Drawing.Size(185, 45);
            this.searchBox.TabIndex = 8;
            this.searchBox.TextOffset = new System.Drawing.Point(5, 0);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.Color.Transparent;
            this.nameText.BorderColor = System.Drawing.Color.Red;
            this.nameText.BorderRadius = 20;
            this.nameText.BorderThickness = 2;
            this.nameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameText.DefaultText = "";
            this.nameText.DisabledState.BorderColor = System.Drawing.Color.White;
            this.nameText.DisabledState.FillColor = System.Drawing.Color.White;
            this.nameText.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.nameText.DisabledState.Parent = this.nameText;
            this.nameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.nameText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.nameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameText.FocusedState.Parent = this.nameText;
            this.nameText.FocusedState.PlaceholderForeColor = System.Drawing.Color.Red;
            this.nameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.ForeColor = System.Drawing.Color.Red;
            this.nameText.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.nameText.HoverState.Parent = this.nameText;
            this.nameText.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.nameText.IconRightOffset = new System.Drawing.Point(5, 0);
            this.nameText.IconRightSize = new System.Drawing.Size(30, 30);
            this.nameText.Location = new System.Drawing.Point(17, 78);
            this.nameText.Margin = new System.Windows.Forms.Padding(5);
            this.nameText.Name = "nameText";
            this.nameText.PasswordChar = '\0';
            this.nameText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.nameText.PlaceholderText = "Name...";
            this.nameText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameText.SelectedText = "";
            this.nameText.ShadowDecoration.Depth = 15;
            this.nameText.ShadowDecoration.Parent = this.nameText;
            this.nameText.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.nameText.Size = new System.Drawing.Size(170, 45);
            this.nameText.TabIndex = 9;
            this.nameText.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // priceText
            // 
            this.priceText.BackColor = System.Drawing.Color.Transparent;
            this.priceText.BorderColor = System.Drawing.Color.Red;
            this.priceText.BorderRadius = 20;
            this.priceText.BorderThickness = 2;
            this.priceText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceText.DefaultText = "";
            this.priceText.DisabledState.BorderColor = System.Drawing.Color.White;
            this.priceText.DisabledState.FillColor = System.Drawing.Color.White;
            this.priceText.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.priceText.DisabledState.Parent = this.priceText;
            this.priceText.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.priceText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.priceText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.priceText.FocusedState.Parent = this.priceText;
            this.priceText.FocusedState.PlaceholderForeColor = System.Drawing.Color.Red;
            this.priceText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceText.ForeColor = System.Drawing.Color.Red;
            this.priceText.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.priceText.HoverState.Parent = this.priceText;
            this.priceText.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.priceText.IconRightOffset = new System.Drawing.Point(5, 0);
            this.priceText.IconRightSize = new System.Drawing.Size(30, 30);
            this.priceText.Location = new System.Drawing.Point(203, 78);
            this.priceText.Margin = new System.Windows.Forms.Padding(5);
            this.priceText.Name = "priceText";
            this.priceText.PasswordChar = '\0';
            this.priceText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.priceText.PlaceholderText = "Price...";
            this.priceText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceText.SelectedText = "";
            this.priceText.ShadowDecoration.Depth = 15;
            this.priceText.ShadowDecoration.Parent = this.priceText;
            this.priceText.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.priceText.Size = new System.Drawing.Size(170, 45);
            this.priceText.TabIndex = 10;
            this.priceText.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // quantityText
            // 
            this.quantityText.BackColor = System.Drawing.Color.Transparent;
            this.quantityText.BorderColor = System.Drawing.Color.Red;
            this.quantityText.BorderRadius = 20;
            this.quantityText.BorderThickness = 2;
            this.quantityText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityText.DefaultText = "";
            this.quantityText.DisabledState.BorderColor = System.Drawing.Color.White;
            this.quantityText.DisabledState.FillColor = System.Drawing.Color.White;
            this.quantityText.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.quantityText.DisabledState.Parent = this.quantityText;
            this.quantityText.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.quantityText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.quantityText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quantityText.FocusedState.Parent = this.quantityText;
            this.quantityText.FocusedState.PlaceholderForeColor = System.Drawing.Color.Red;
            this.quantityText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityText.ForeColor = System.Drawing.Color.Red;
            this.quantityText.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.quantityText.HoverState.Parent = this.quantityText;
            this.quantityText.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.quantityText.IconRightOffset = new System.Drawing.Point(5, 0);
            this.quantityText.IconRightSize = new System.Drawing.Size(30, 30);
            this.quantityText.Location = new System.Drawing.Point(389, 78);
            this.quantityText.Margin = new System.Windows.Forms.Padding(5);
            this.quantityText.Name = "quantityText";
            this.quantityText.PasswordChar = '\0';
            this.quantityText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.quantityText.PlaceholderText = "Quantity...";
            this.quantityText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantityText.SelectedText = "";
            this.quantityText.ShadowDecoration.Depth = 15;
            this.quantityText.ShadowDecoration.Parent = this.quantityText;
            this.quantityText.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.quantityText.Size = new System.Drawing.Size(170, 45);
            this.quantityText.TabIndex = 11;
            this.quantityText.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // selectBox
            // 
            this.selectBox.AutoRoundedCorners = true;
            this.selectBox.BackColor = System.Drawing.Color.Transparent;
            this.selectBox.BorderColor = System.Drawing.Color.Red;
            this.selectBox.BorderRadius = 21;
            this.selectBox.BorderThickness = 2;
            this.selectBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBox.FocusedColor = System.Drawing.Color.Empty;
            this.selectBox.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.selectBox.FocusedState.Parent = this.selectBox;
            this.selectBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBox.ForeColor = System.Drawing.Color.Red;
            this.selectBox.FormattingEnabled = true;
            this.selectBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectBox.HoverState.Parent = this.selectBox;
            this.selectBox.ItemHeight = 38;
            this.selectBox.Items.AddRange(new object[] {
            "Electronics",
            "Hardware",
            "Grocery",
            "Pharmacy",
            "Automotive"});
            this.selectBox.ItemsAppearance.Parent = this.selectBox;
            this.selectBox.Location = new System.Drawing.Point(574, 79);
            this.selectBox.Name = "selectBox";
            this.selectBox.ShadowDecoration.Parent = this.selectBox;
            this.selectBox.Size = new System.Drawing.Size(170, 44);
            this.selectBox.TabIndex = 13;
            this.selectBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // UC_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UC_Inventory";
            this.Size = new System.Drawing.Size(942, 560);
            this.Load += new System.EventHandler(this.UC_Inventory_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button newBtn;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView inventoryGrid;
        private Guna.UI2.WinForms.Guna2Button editBtn;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Guna.UI2.WinForms.Guna2TextBox nameText;
        private Guna.UI2.WinForms.Guna2TextBox priceText;
        private Guna.UI2.WinForms.Guna2TextBox quantityText;
        private Guna.UI2.WinForms.Guna2ComboBox selectBox;
        private Guna.UI2.WinForms.Guna2MouseStateHandler guna2MouseStateHandler1;
    }
}
