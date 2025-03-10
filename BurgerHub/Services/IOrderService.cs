using BurgerHub.BurgerHub.Models;

namespace BurgerHub.BurgerHub.Services
{
    interface IOrderService
    {
        public void AddOrder(Order order);
        public void RemoveOrder(Order order);
        public IEnumerable<Order> GetAllOrders();
    }
}
