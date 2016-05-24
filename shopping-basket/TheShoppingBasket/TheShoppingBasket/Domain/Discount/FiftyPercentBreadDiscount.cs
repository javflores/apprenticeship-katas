using TheShoppingBasket.Domain.Basket;

namespace TheShoppingBasket.Domain.Discount
{
    public class FiftyPercentBreadDiscount : IDiscount
    {
        public Money ApplyTo(Products products)
        {
            var quantityOfButter = products.QuantityOf(new Butter());
            var quantityOfBread = products.QuantityOf(new Bread());

            if (quantityOfBread > 0 && quantityOfButter > 1)
            {
                return new Bread().Price.FiftyPercent();
            }

            return new Money();
        }
    }
}