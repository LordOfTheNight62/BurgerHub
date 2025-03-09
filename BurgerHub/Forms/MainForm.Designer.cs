namespace BurgerHub
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ListViewActiveOrders = new ListView();
            DropdownBurger = new ComboBox();
            BtnCreateOrder = new Button();
            pictureBox1 = new PictureBox();
            BtnAddToOrderList = new Button();
            BtnShowAllOrdersForm = new Button();
            LabelTotalPrice = new Label();
            BtnCancelActiveOrder = new Button();
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ListViewActiveOrders
            // 
            ListViewActiveOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ListViewActiveOrders.Location = new Point(15, 32);
            ListViewActiveOrders.Margin = new Padding(4);
            ListViewActiveOrders.Name = "ListViewActiveOrders";
            ListViewActiveOrders.Size = new Size(655, 793);
            ListViewActiveOrders.TabIndex = 0;
            ListViewActiveOrders.UseCompatibleStateImageBehavior = false;
            // 
            // DropdownBurger
            // 
            DropdownBurger.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DropdownBurger.DropDownStyle = ComboBoxStyle.DropDownList;
            DropdownBurger.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            DropdownBurger.FormattingEnabled = true;
            DropdownBurger.Location = new Point(725, 728);
            DropdownBurger.Margin = new Padding(4);
            DropdownBurger.Name = "DropdownBurger";
            DropdownBurger.Size = new Size(597, 39);
            DropdownBurger.TabIndex = 1;
            // 
            // BtnCreateOrder
            // 
            BtnCreateOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnCreateOrder.BackColor = Color.Lime;
            BtnCreateOrder.Enabled = false;
            BtnCreateOrder.Location = new Point(723, 774);
            BtnCreateOrder.Name = "BtnCreateOrder";
            BtnCreateOrder.Size = new Size(844, 50);
            BtnCreateOrder.TabIndex = 2;
            BtnCreateOrder.Text = "Order";
            BtnCreateOrder.UseVisualStyleBackColor = false;
            BtnCreateOrder.Click += BtnCreateOrder_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(902, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 461);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // BtnAddToOrderList
            // 
            BtnAddToOrderList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAddToOrderList.BackColor = Color.Lime;
            BtnAddToOrderList.Location = new Point(1329, 728);
            BtnAddToOrderList.Name = "BtnAddToOrderList";
            BtnAddToOrderList.Size = new Size(237, 39);
            BtnAddToOrderList.TabIndex = 4;
            BtnAddToOrderList.Text = "Add";
            BtnAddToOrderList.UseVisualStyleBackColor = false;
            BtnAddToOrderList.Click += BtnAddToOrderList_Click;
            // 
            // BtnShowAllOrdersForm
            // 
            BtnShowAllOrdersForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnShowAllOrdersForm.BackColor = Color.Gold;
            BtnShowAllOrdersForm.Location = new Point(902, 499);
            BtnShowAllOrdersForm.Name = "BtnShowAllOrdersForm";
            BtnShowAllOrdersForm.Size = new Size(540, 50);
            BtnShowAllOrdersForm.TabIndex = 5;
            BtnShowAllOrdersForm.Text = "Show All Orders";
            BtnShowAllOrdersForm.UseVisualStyleBackColor = false;
            BtnShowAllOrdersForm.Click += BtnShowAllOrdersForm_Click;
            // 
            // LabelTotalPrice
            // 
            LabelTotalPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelTotalPrice.AutoSize = true;
            LabelTotalPrice.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            LabelTotalPrice.Location = new Point(725, 662);
            LabelTotalPrice.Name = "LabelTotalPrice";
            LabelTotalPrice.Size = new Size(72, 50);
            LabelTotalPrice.TabIndex = 6;
            LabelTotalPrice.Text = "0 ₺";
            // 
            // BtnCancelActiveOrder
            // 
            BtnCancelActiveOrder.BackColor = Color.Red;
            BtnCancelActiveOrder.Enabled = false;
            BtnCancelActiveOrder.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnCancelActiveOrder.ForeColor = Color.White;
            BtnCancelActiveOrder.Location = new Point(677, 31);
            BtnCancelActiveOrder.Name = "BtnCancelActiveOrder";
            BtnCancelActiveOrder.Size = new Size(77, 43);
            BtnCancelActiveOrder.TabIndex = 7;
            BtnCancelActiveOrder.Text = "Cancel";
            BtnCancelActiveOrder.UseVisualStyleBackColor = false;
            BtnCancelActiveOrder.Click += BtnCancelActiveOrder_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gold;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1578, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 841);
            Controls.Add(BtnCancelActiveOrder);
            Controls.Add(LabelTotalPrice);
            Controls.Add(BtnShowAllOrdersForm);
            Controls.Add(BtnAddToOrderList);
            Controls.Add(pictureBox1);
            Controls.Add(BtnCreateOrder);
            Controls.Add(DropdownBurger);
            Controls.Add(ListViewActiveOrders);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MinimumSize = new Size(1596, 888);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Order - BurgerHub";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ListViewActiveOrders;
        private ComboBox DropdownBurger;
        private Button BtnCreateOrder;
        private PictureBox pictureBox1;
        private Button BtnAddToOrderList;
        private Button BtnShowAllOrdersForm;
        private Label LabelTotalPrice;
        private Button BtnCancelActiveOrder;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
