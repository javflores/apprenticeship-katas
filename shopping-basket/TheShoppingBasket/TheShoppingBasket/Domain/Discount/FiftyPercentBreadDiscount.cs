using System.Linq;
using TheShoppingBasket.Domain.Basket;

namespace TheShoppingBasket.Domain.Discount
{
    public class FiftyPercentBreadDiscount : IDiscount
    {
        public Money Apply(Products products)
        {
            if (CanApplyOffer(products))
            {
                return Offer();
            }

            return new Money();
        }

        private Money Offer()
        {
            return new Bread().Price.FiftyPercent();
        }

        private bool CanApplyOffer(Products products)
        {
            var quantityOfButter = products.QuantityOf(new Butter());
            var quantityOfBread = products.QuantityOf(new Bread());

            return quantityOfBread > 0 && quantityOfButter > 1;
        }
    }
}