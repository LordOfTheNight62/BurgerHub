namespace BurgerHub.BurgerHub.Models
{
    public class Order
    {
        private List<Burger> _burgers;
        private List<Beverage> _beverages;
        public string? Id { get; init; }
        public double Price { get; private set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public int BurgerQuantity => _burgers.Count;
        public int BeverageQuantity => _beverages.Count;
        public int TotalQuantity => BurgerQuantity + BeverageQuantity;

        public Order()
        {
            Id = Guid.NewGuid().ToString();
            _burgers = new List<Burger>();
            _beverages = new List<Beverage>();
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

        public void AddBeverage(Beverage beverage)
        {
            _beverages.Add(beverage);
            CalculatePrice();
        }

        public void RemoveBeverage(Beverage beverage)
        {
            _beverages.Remove(beverage);
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            Price = _burgers?.Sum(b => b.Price) ?? 0;
            Price += _beverages?.Sum(b => b.Price) ?? 0;
        }
    }
}
