using BurgerHub.BurgerHub.Models;

namespace BurgerHub.BurgerHub.Services
{
    public class OrderService : IOrderService
    {
        private Queue<Order> _orders = new Queue<Order>();

        public void AddOrder(Order order)
        {
            _orders.Enqueue(order);
        }

        public void RemoveOrder(Order order)
        {
            _orders = new Queue<Order>(_orders.Where(o => o.Id != order.Id));
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orders.ToList();
        }
    }
}
