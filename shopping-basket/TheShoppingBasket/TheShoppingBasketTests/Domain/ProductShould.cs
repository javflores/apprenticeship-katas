using NSubstitute;
using TheShoppingBasket.Domain;
using TheShoppingBasket.Domain.Basket;
using Xunit;

namespace TheShoppingBasketTests.Domain
{
    public class ProductShould
    {
        [Fact]
        public void cost_price_times_quantity()
        {
            const int quantity = 2;
            var product = Substitute.For<Product>("dummy", quantity);
            var productPrice = new Money(1.0m);
            product.Price.Returns(productPrice);

            Assert.Equal(productPrice * quantity, product.Cost());
        }

        [Fact]
        public void equal_to_another_product_when_name_is_same()
        {
            Product product = Substitute.For<Product>("dummy");
            Product anotherProduct = Substitute.For<Product>("dummy");

            var areEqual = product.Equals(anotherProduct);

            Assert.True(areEqual);
        }
    }
}