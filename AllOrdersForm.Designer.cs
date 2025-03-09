namespace BurgerHub
{
    partial class AllOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllOrdersForm));
            DataGridAllOrders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridAllOrders).BeginInit();
            SuspendLayout();
            // 
            // DataGridAllOrders
            // 
            DataGridAllOrders.AllowUserToAddRows = false;
            DataGridAllOrders.AllowUserToDeleteRows = false;
            DataGridAllOrders.BackgroundColor = Color.White;
            DataGridAllOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridAllOrders.Location = new Point(12, 12);
            DataGridAllOrders.Name = "DataGridAllOrders";
            DataGridAllOrders.ReadOnly = true;
            DataGridAllOrders.RowHeadersWidth = 51;
            DataGridAllOrders.Size = new Size(1238, 649);
            DataGridAllOrders.TabIndex = 0;
            // 
            // AllOrdersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(DataGridAllOrders);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1280, 720);
            Name = "AllOrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Orders - BurgerHub";
            Load += AllOrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridAllOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridAllOrders;
    }
}