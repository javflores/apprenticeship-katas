using TheShoppingBasket.Domain;
using TheShoppingBasket.Domain.Basket;
using TheShoppingBasket.Domain.Discount;
using Xunit;

namespace TheShoppingBasketTests.Domain
{
    public class DiscountsShould
    {
        private readonly Discounts _discounts = new Discounts();

        [Fact]
        public void apply_all_individual_discounts()
        {
            Products products = new Products();

            AddProduct(products, new Butter(2));
            AddProduct(products, new Bread(1));
            AddProduct(products, new Milk(4));

            Money discount = _discounts.ApplyTo(products);

            var severalDiscountsApplied = new Money(1.65m);
            Assert.Equal(severalDiscountsApplied, discount);
        }

        private void AddProduct(Products products, Product product)
        {
            products.Add(product);
        }
    }
}