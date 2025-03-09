namespace BurgerHub.BurgerHub.Models
{
    public class Burger
    {
        public string? Name { get; set; }
        public double Price { get; set; }

        public override string? ToString()
        {
            return $"{Name} - {Price}₺";
        }
    }
}
