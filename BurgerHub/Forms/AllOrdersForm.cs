using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurgerHub.BurgerHub.Services;

namespace BurgerHub
{
    public partial class AllOrdersForm : Form
    {
        private OrderService _burgerOrderService;

        public AllOrdersForm(OrderService burgerOrderService)
        {
            InitializeComponent();
            _burgerOrderService = burgerOrderService;
        }

        private void AllOrdersForm_Load(object sender, EventArgs e)
        {
            DataGridAllOrders.DataSource = _burgerOrderService.GetAllOrders().ToList();
        }
    }
}
