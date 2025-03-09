using System.Diagnostics;
using System.Text.Json;
using BurgerHub.BurgerHub.Models;
using BurgerHub.BurgerHub.Services;

namespace BurgerHub
{
    public partial class MainForm : Form
    {
        private static BurgerOrderService _burgerOrderService = new BurgerOrderService();
        private static List<Burger> _burgerList = new List<Burger>();
        private Order? _order = new Order();
        public MainForm()
        {
            InitializeComponent();
            InitializeBurgerHubComponents();
        }

        private void InitializeBurgerHubComponents()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BurgerHub", "Data", "BurgerList.json");
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                _burgerList = JsonSerializer.Deserialize<List<Burger>>(json);
            }

            DropdownBurger.DataSource = _burgerList;

            ListViewActiveOrders.View = View.Details;
            ListViewActiveOrders.Columns.Add("Burger", 250);
            ListViewActiveOrders.Columns.Add("Price", 80);
        }

        private void UpdateUI()
        {
            LabelTotalPrice.Text = $"{_order?.Price:0.00} ₺";
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

        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {
            _burgerOrderService.AddOrder(_order);
            _order = new Order();
            UpdateUI();
        }

        private void BtnAddToOrderList_Click(object sender, EventArgs e)
        {
            if (DropdownBurger.SelectedItem is Burger burger)
            {
                var item = new ListViewItem(burger.Name);
                item.SubItems.Add(burger.Price.ToString());
                ListViewActiveOrders.Items.Add(item);
                _order?.AddBurger(burger);

                UpdateUI();
            }
        }

        private void BtnCancelActiveOrder_Click(object sender, EventArgs e)
        {
            _order = new Order();
            UpdateUI();
        }

        private void BtnShowAllOrdersForm_Click(object sender, EventArgs e)
        {
            AllOrdersForm allOrdersForm = new AllOrdersForm(_burgerOrderService);
            allOrdersForm.ShowDialog();
        }
    }
}
