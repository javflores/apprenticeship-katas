using TheShoppingBasket.Domain.Basket;

namespace TheShoppingBasket.Domain.Discount
{
    public class FourthMilkFreeDiscount : IDiscount
    {
        public Money ApplyTo(Products products)
        {
            var numberOfTimesToApplyOffer = products.QuantityOf(new Milk())/4;

            return new Milk().Price * numberOfTimesToApplyOffer;
        }
    }
}