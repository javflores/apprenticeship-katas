using TheShoppingBasket.Domain.Basket;

namespace TheShoppingBasket.Domain.Discount
{
    public class FiftyPercentBreadDiscount : IDiscount
    {
        public Money ApplyTo(Products products)
        {
            if (products.MoreThan(0, new Bread()) && products.MoreThan(1, new Butter()))
            {
                return new Bread().Price.FiftyPercent();
            }

            return new Money();
        }
    }
}