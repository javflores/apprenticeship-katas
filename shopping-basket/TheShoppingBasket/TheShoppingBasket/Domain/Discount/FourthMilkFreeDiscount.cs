using TheShoppingBasket.Domain.Basket;

namespace TheShoppingBasket.Domain.Discount
{
    public class FourthMilkFreeDiscount : IDiscount
    {
        public Money ApplyTo(Products products)
        {
            var numberOfTimesToApplyOffer = products.PacksOf(4, new Milk());

            return new Milk().Price * numberOfTimesToApplyOffer;
        }
    }
}