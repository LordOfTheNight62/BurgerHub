using BurgerHub.BurgerHub.Models;

namespace BurgerHub.BurgerHub.Services
{
    public class BurgerOrderService
    {
        private Queue<Order> _orders = new Queue<Order>();

        public void AddOrder(Order order)
        {
            _orders.Enqueue(order);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orders.ToList();
        }
    }
}
