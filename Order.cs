namespace BurgerHub
{
    public class Order
    {
        private List<Burger> _burgers;
        public string? Id { get; init; }
        public double Price { get; private set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public int TotalQuantity => _burgers.Count;

        public Order()
        {
            Id = Guid.NewGuid().ToString();
            _burgers = new List<Burger>();
            CalculatePrice();
        }

        public void AddBurger(Burger burger)
        {
            _burgers.Add(burger);
            CalculatePrice();
        }

        public void RemoveBurger(Burger burger)
        {
            _burgers.Remove(burger);
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            Price = _burgers?.Sum(b => b.Price) ?? 0;
        }
    }
}
