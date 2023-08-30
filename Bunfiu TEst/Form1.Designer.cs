namespace Bunfiu_TEst
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new System.Windows.Forms.Panel();
            this.controlBox = new System.Windows.Forms.Panel();
            this.minimizeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.kryssBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewOrdersBtn = new Guna.UI2.WinForms.Guna2Button();
            this.customerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ordersBtn = new Guna.UI2.WinForms.Guna2Button();
            this.inventoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.homeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Blue;
            this.topPanel.Controls.Add(this.controlBox);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1118, 72);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // controlBox
            // 
            this.controlBox.Controls.Add(this.minimizeBtn);
            this.controlBox.Controls.Add(this.kryssBtn);
            this.controlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlBox.Location = new System.Drawing.Point(987, 0);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(131, 72);
            this.controlBox.TabIndex = 0;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.AutoRoundedCorners = true;
            this.minimizeBtn.BorderRadius = 12;
            this.minimizeBtn.FillColor = System.Drawing.Color.Yellow;
            this.minimizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.ImageSize = new System.Drawing.Size(28, 28);
            this.minimizeBtn.Location = new System.Drawing.Point(52, 20);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(27, 27);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // kryssBtn
            // 
            this.kryssBtn.AutoRoundedCorners = true;
            this.kryssBtn.BorderRadius = 12;
            this.kryssBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryssBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryssBtn.ForeColor = System.Drawing.Color.White;
            this.kryssBtn.Image = ((System.Drawing.Image)(resources.GetObject("kryssBtn.Image")));
            this.kryssBtn.ImageSize = new System.Drawing.Size(27, 27);
            this.kryssBtn.Location = new System.Drawing.Point(100, 21);
            this.kryssBtn.Name = "kryssBtn";
            this.kryssBtn.Size = new System.Drawing.Size(26, 26);
            this.kryssBtn.TabIndex = 0;
            this.kryssBtn.Click += new System.EventHandler(this.kryssBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lager Hantering";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.viewOrdersBtn);
            this.panel2.Controls.Add(this.customerBtn);
            this.panel2.Controls.Add(this.ordersBtn);
            this.panel2.Controls.Add(this.inventoryBtn);
            this.panel2.Controls.Add(this.homeBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 560);
            this.panel2.TabIndex = 1;
            // 
            // viewOrdersBtn
            // 
            this.viewOrdersBtn.Animated = true;
            this.viewOrdersBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.viewOrdersBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.viewOrdersBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.viewOrdersBtn.FillColor = System.Drawing.Color.White;
            this.viewOrdersBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrdersBtn.ForeColor = System.Drawing.Color.Black;
            this.viewOrdersBtn.HoverState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.viewOrdersBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewOrdersBtn.Image")));
            this.viewOrdersBtn.ImageOffset = new System.Drawing.Point(-2, 0);
            this.viewOrdersBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.viewOrdersBtn.Location = new System.Drawing.Point(0, 390);
            this.viewOrdersBtn.Name = "viewOrdersBtn";
            this.viewOrdersBtn.Size = new System.Drawing.Size(176, 45);
            this.viewOrdersBtn.TabIndex = 4;
            this.viewOrdersBtn.Text = "Visa ordrar";
            this.viewOrdersBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.viewOrdersBtn.Click += new System.EventHandler(this.viewOrdersBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.Animated = true;
            this.customerBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.customerBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Yellow;
            this.customerBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.customerBtn.FillColor = System.Drawing.Color.White;
            this.customerBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.Color.Black;
            this.customerBtn.HoverState.CustomBorderColor = System.Drawing.Color.Yellow;
            this.customerBtn.Image = ((System.Drawing.Image)(resources.GetObject("customerBtn.Image")));
            this.customerBtn.ImageOffset = new System.Drawing.Point(-5, 0);
            this.customerBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.customerBtn.Location = new System.Drawing.Point(0, 302);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(176, 45);
            this.customerBtn.TabIndex = 3;
            this.customerBtn.Text = "Kunder";
            this.customerBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // ordersBtn
            // 
            this.ordersBtn.Animated = true;
            this.ordersBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ordersBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Green;
            this.ordersBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ordersBtn.FillColor = System.Drawing.Color.White;
            this.ordersBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersBtn.ForeColor = System.Drawing.Color.Black;
            this.ordersBtn.HoverState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.ordersBtn.Image = ((System.Drawing.Image)(resources.GetObject("ordersBtn.Image")));
            this.ordersBtn.ImageOffset = new System.Drawing.Point(-5, 0);
            this.ordersBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.ordersBtn.Location = new System.Drawing.Point(0, 210);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(176, 45);
            this.ordersBtn.TabIndex = 2;
            this.ordersBtn.Text = "Order";
            this.ordersBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Animated = true;
            this.inventoryBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.inventoryBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.inventoryBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.inventoryBtn.FillColor = System.Drawing.Color.White;
            this.inventoryBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.Black;
            this.inventoryBtn.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.inventoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("inventoryBtn.Image")));
            this.inventoryBtn.ImageOffset = new System.Drawing.Point(-6, 0);
            this.inventoryBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.inventoryBtn.Location = new System.Drawing.Point(0, 130);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(176, 45);
            this.inventoryBtn.TabIndex = 1;
            this.inventoryBtn.Text = "Lager";
            this.inventoryBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Animated = true;
            this.homeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homeBtn.Checked = true;
            this.homeBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Blue;
            this.homeBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.homeBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.homeBtn.FillColor = System.Drawing.Color.White;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.Black;
            this.homeBtn.HoverState.CustomBorderColor = System.Drawing.Color.Blue;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageOffset = new System.Drawing.Point(-11, 0);
            this.homeBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.homeBtn.Location = new System.Drawing.Point(0, 54);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(176, 41);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Översikt";
            this.homeBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(176, 72);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(942, 560);
            this.panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1118, 632);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button viewOrdersBtn;
        private Guna.UI2.WinForms.Guna2Button customerBtn;
        private Guna.UI2.WinForms.Guna2Button ordersBtn;
        private Guna.UI2.WinForms.Guna2Button inventoryBtn;
        private Guna.UI2.WinForms.Guna2Button homeBtn;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel controlBox;
        private Guna.UI2.WinForms.Guna2Button minimizeBtn;
        private Guna.UI2.WinForms.Guna2Button kryssBtn;
    }
}

