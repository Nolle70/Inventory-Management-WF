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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.customerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ordersBtn = new Guna.UI2.WinForms.Guna2Button();
            this.inventoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.homeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Blue;
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1118, 72);
            this.topPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Manegement";
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.guna2Button4);
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
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(0, 390);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(176, 45);
            this.guna2Button4.TabIndex = 4;
            this.guna2Button4.Text = "Home";
            this.guna2Button4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            // 
            // customerBtn
            // 
            this.customerBtn.Animated = true;
            this.customerBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.customerBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Yellow;
            this.customerBtn.CheckedState.Parent = this.customerBtn;
            this.customerBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.customerBtn.CustomImages.Parent = this.customerBtn;
            this.customerBtn.FillColor = System.Drawing.Color.White;
            this.customerBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.Color.Black;
            this.customerBtn.HoverState.CustomBorderColor = System.Drawing.Color.Yellow;
            this.customerBtn.HoverState.Parent = this.customerBtn;
            this.customerBtn.Location = new System.Drawing.Point(0, 302);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.ShadowDecoration.Parent = this.customerBtn;
            this.customerBtn.Size = new System.Drawing.Size(176, 45);
            this.customerBtn.TabIndex = 3;
            this.customerBtn.Text = "Customers";
            this.customerBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // ordersBtn
            // 
            this.ordersBtn.Animated = true;
            this.ordersBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ordersBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Green;
            this.ordersBtn.CheckedState.Parent = this.ordersBtn;
            this.ordersBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ordersBtn.CustomImages.Parent = this.ordersBtn;
            this.ordersBtn.FillColor = System.Drawing.Color.White;
            this.ordersBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersBtn.ForeColor = System.Drawing.Color.Black;
            this.ordersBtn.HoverState.CustomBorderColor = System.Drawing.Color.Green;
            this.ordersBtn.HoverState.Parent = this.ordersBtn;
            this.ordersBtn.Location = new System.Drawing.Point(0, 210);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.ShadowDecoration.Parent = this.ordersBtn;
            this.ordersBtn.Size = new System.Drawing.Size(176, 45);
            this.ordersBtn.TabIndex = 2;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Animated = true;
            this.inventoryBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.inventoryBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.inventoryBtn.CheckedState.Parent = this.inventoryBtn;
            this.inventoryBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.inventoryBtn.CustomImages.Parent = this.inventoryBtn;
            this.inventoryBtn.FillColor = System.Drawing.Color.White;
            this.inventoryBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.Black;
            this.inventoryBtn.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.inventoryBtn.HoverState.Parent = this.inventoryBtn;
            this.inventoryBtn.Location = new System.Drawing.Point(0, 130);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.ShadowDecoration.Parent = this.inventoryBtn;
            this.inventoryBtn.Size = new System.Drawing.Size(176, 45);
            this.inventoryBtn.TabIndex = 1;
            this.inventoryBtn.Text = "Inventory";
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
            this.homeBtn.CheckedState.Parent = this.homeBtn;
            this.homeBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.homeBtn.CustomImages.Parent = this.homeBtn;
            this.homeBtn.FillColor = System.Drawing.Color.White;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.Black;
            this.homeBtn.HoverState.CustomBorderColor = System.Drawing.Color.Blue;
            this.homeBtn.HoverState.Parent = this.homeBtn;
            this.homeBtn.Location = new System.Drawing.Point(0, 54);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.ShadowDecoration.Parent = this.homeBtn;
            this.homeBtn.Size = new System.Drawing.Size(176, 41);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Home";
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
            this.ClientSize = new System.Drawing.Size(1118, 632);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button customerBtn;
        private Guna.UI2.WinForms.Guna2Button ordersBtn;
        private Guna.UI2.WinForms.Guna2Button inventoryBtn;
        private Guna.UI2.WinForms.Guna2Button homeBtn;
        private System.Windows.Forms.Panel panelContainer;
    }
}

