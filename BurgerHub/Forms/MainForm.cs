using System.Text.Json;
using BurgerHub.BurgerHub.Forms;
using BurgerHub.BurgerHub.Models;
using BurgerHub.BurgerHub.Services;

namespace BurgerHub
{
    public partial class MainForm : Form
    {
        private static OrderService _burgerOrderService = new OrderService();
        private static List<Burger> _burgerList = new List<Burger>();
        private static List<Beverage> _beverageList = new List<Beverage>();
        private Order? _order = new Order();

        public MainForm()
        {
            InitializeComponent();
            InitializeBurgerHubComponents();
        }

        private void InitializeBurgerHubComponents()
        {
            string burgerListPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BurgerHub", "Data", "BurgerList.json");
            string beverageListPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BurgerHub", "Data", "BeverageList.json");
            if (File.Exists(burgerListPath))
            {
                var json = File.ReadAllText(burgerListPath);
                _burgerList = JsonSerializer.Deserialize<List<Burger>>(json);
            }

            if (File.Exists(beverageListPath))
            {
                var json = File.ReadAllText(beverageListPath);
                _beverageList = JsonSerializer.Deserialize<List<Beverage>>(json);
            }

            _burgerList?.Insert(0, new Burger { Name = "None", Price = 0 });
            _beverageList?.Insert(0, new Beverage { Name = "None", Price = 0 });

            DropdownBurger.DataSource = _burgerList;
            DropdownBeverage.DataSource = _beverageList;

            for (int i = 1; i <= 10; i++)
            {
                DropdownBurgerAmount.Items.Add(i);
                DropdownBurgerAmount.SelectedIndex = 0;
                DropdownBeverageAmount.Items.Add(i);
                DropdownBeverageAmount.SelectedIndex = 0;
            }

            ListViewActiveOrders.View = View.Details;
            ListViewActiveOrders.Columns.Add("Content", 250);
            ListViewActiveOrders.Columns.Add("Price", 80);
        }

        private void UpdateUI()
        {
            LabelTotalPrice.Text = $"{_order?.Price:0.00} ₺";
            LabelBurgerAmount.Text = $"{_order?.BurgerQuantity}";
            LabelBeverageAmount.Text = $"{_order?.BeverageQuantity}";
            if (_order?.TotalQuantity > 0)
            {
                BtnCreateOrder.Enabled = true;
                BtnCancelActiveOrder.Enabled = true;
            }
            else
            {
                BtnCreateOrder.Enabled = false;
                BtnCancelActiveOrder.Enabled = false;
                ListViewActiveOrders.Items.Clear();
            }
        }

        private void SetDefaultDropdowns()
        {
            DropdownBurger.SelectedItem = _burgerList.FirstOrDefault(b => b.Name == "None");
            DropdownBurgerAmount.SelectedIndex = 0;
            DropdownBeverage.SelectedItem = _beverageList.FirstOrDefault(b => b.Name == "None");
            DropdownBeverageAmount.SelectedIndex = 0;
        }

        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {
            _burgerOrderService.AddOrder(_order);
            _order = new Order();
            UpdateUI();
        }

        private void BtnAddToOrderList_Click(object sender, EventArgs e)
        {
            if (DropdownBurger.SelectedItem is Burger burger && burger.Name != "None")
            {
                if (DropdownBurgerAmount.SelectedItem is int amount)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        _order?.AddBurger(burger);
                        var item = new ListViewItem(burger.Name);
                        item.SubItems.Add(burger.Price.ToString());
                        ListViewActiveOrders.Items.Add(item);
                    }
                }
            }

            if (DropdownBeverage.SelectedItem is Beverage beverage && beverage.Name != "None")
            {
                if (DropdownBeverageAmount.SelectedItem is int amount)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        _order?.AddBeverage(beverage);
                        var item = new ListViewItem(beverage.Name);
                        item.SubItems.Add(beverage.Price.ToString());
                        ListViewActiveOrders.Items.Add(item);
                    }
                }
            }

            UpdateUI();
            SetDefaultDropdowns();
        }

        private void BtnCancelActiveOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to cancel this Order?", "Cancel Order", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _order = new Order();
                UpdateUI();
            }

        }

        private void BtnShowAllOrdersForm_Click(object sender, EventArgs e)
        {
            AllOrdersForm allOrdersForm = new AllOrdersForm(_burgerOrderService);
            allOrdersForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
