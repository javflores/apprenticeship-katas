using TheShoppingBasket.Domain.Basket;

namespace TheShoppingBasket.Domain.Discount
{
    public class FourthMilkFreeDiscount : IDiscount
    {
        public Money ApplyTo(Products products)
        {
            var milk = products.Find(new Milk());
            var numberOfTimesToApplyOffer = milk.PacksOf(4);

            return new Milk().Price * numberOfTimesToApplyOffer;
        }
    }
}