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
            label1 = new Label();
            DropdownBeverage = new ComboBox();
            DropdownBeverageAmount = new ComboBox();
            DropdownBurgerAmount = new ComboBox();
            LabelBurgerAmount = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            LabelBeverageAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // ListViewActiveOrders
            // 
            ListViewActiveOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ListViewActiveOrders.Location = new Point(15, 98);
            ListViewActiveOrders.Margin = new Padding(4);
            ListViewActiveOrders.Name = "ListViewActiveOrders";
            ListViewActiveOrders.Size = new Size(655, 727);
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
            DropdownBurger.Size = new Size(377, 39);
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
            LabelTotalPrice.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            LabelTotalPrice.Location = new Point(725, 662);
            LabelTotalPrice.Name = "LabelTotalPrice";
            LabelTotalPrice.Size = new Size(78, 54);
            LabelTotalPrice.TabIndex = 6;
            LabelTotalPrice.Text = "0 ₺";
            // 
            // BtnCancelActiveOrder
            // 
            BtnCancelActiveOrder.BackColor = Color.Transparent;
            BtnCancelActiveOrder.BackgroundImage = (Image)resources.GetObject("BtnCancelActiveOrder.BackgroundImage");
            BtnCancelActiveOrder.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancelActiveOrder.Enabled = false;
            BtnCancelActiveOrder.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnCancelActiveOrder.ForeColor = Color.White;
            BtnCancelActiveOrder.Location = new Point(618, 48);
            BtnCancelActiveOrder.Name = "BtnCancelActiveOrder";
            BtnCancelActiveOrder.Size = new Size(52, 43);
            BtnCancelActiveOrder.TabIndex = 7;
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
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(302, 54);
            label1.TabIndex = 9;
            label1.Text = "Order Summary";
            // 
            // DropdownBeverage
            // 
            DropdownBeverage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DropdownBeverage.DropDownStyle = ComboBoxStyle.DropDownList;
            DropdownBeverage.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            DropdownBeverage.FormattingEnabled = true;
            DropdownBeverage.Location = new Point(1110, 728);
            DropdownBeverage.Margin = new Padding(4);
            DropdownBeverage.Name = "DropdownBeverage";
            DropdownBeverage.Size = new Size(218, 39);
            DropdownBeverage.TabIndex = 10;
            // 
            // DropdownBeverageAmount
            // 
            DropdownBeverageAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DropdownBeverageAmount.DropDownStyle = ComboBoxStyle.DropDownList;
            DropdownBeverageAmount.FormattingEnabled = true;
            DropdownBeverageAmount.Location = new Point(1257, 688);
            DropdownBeverageAmount.Name = "DropdownBeverageAmount";
            DropdownBeverageAmount.Size = new Size(71, 33);
            DropdownBeverageAmount.TabIndex = 11;
            // 
            // DropdownBurgerAmount
            // 
            DropdownBurgerAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DropdownBurgerAmount.DropDownStyle = ComboBoxStyle.DropDownList;
            DropdownBurgerAmount.FormattingEnabled = true;
            DropdownBurgerAmount.Location = new Point(1031, 688);
            DropdownBurgerAmount.Name = "DropdownBurgerAmount";
            DropdownBurgerAmount.Size = new Size(71, 33);
            DropdownBurgerAmount.TabIndex = 12;
            // 
            // LabelBurgerAmount
            // 
            LabelBurgerAmount.AutoSize = true;
            LabelBurgerAmount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            LabelBurgerAmount.Location = new Point(382, 50);
            LabelBurgerAmount.Name = "LabelBurgerAmount";
            LabelBurgerAmount.Size = new Size(34, 41);
            LabelBurgerAmount.TabIndex = 13;
            LabelBurgerAmount.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(324, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(422, 50);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // LabelBeverageAmount
            // 
            LabelBeverageAmount.AutoSize = true;
            LabelBeverageAmount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            LabelBeverageAmount.Location = new Point(480, 50);
            LabelBeverageAmount.Name = "LabelBeverageAmount";
            LabelBeverageAmount.Size = new Size(34, 41);
            LabelBeverageAmount.TabIndex = 15;
            LabelBeverageAmount.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 841);
            Controls.Add(pictureBox3);
            Controls.Add(LabelBeverageAmount);
            Controls.Add(pictureBox2);
            Controls.Add(LabelBurgerAmount);
            Controls.Add(DropdownBurgerAmount);
            Controls.Add(DropdownBeverageAmount);
            Controls.Add(DropdownBeverage);
            Controls.Add(label1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label label1;
        private ComboBox DropdownBeverage;
        private ComboBox DropdownBeverageAmount;
        private ComboBox DropdownBurgerAmount;
        private Label LabelBurgerAmount;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label LabelBeverageAmount;
    }
}
