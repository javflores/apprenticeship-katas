using TheShoppingBasket.Domain.Basket;

namespace TheShoppingBasket.Domain.Discount
{
    public class FiftyPercentBreadDiscount : IDiscount
    {
        public Money ApplyTo(Products products)
        {
            var butter = products.Find(new Butter());
            var bread = products.Find(new Bread());
            if (bread.MoreThan(0) && butter.MoreThan(1))
            {
                return new Bread().Price.FiftyPercent();
            }

            return new Money();
        }
    }
}