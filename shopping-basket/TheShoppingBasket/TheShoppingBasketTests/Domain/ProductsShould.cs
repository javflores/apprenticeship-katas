using TheShoppingBasket.Domain;
using TheShoppingBasket.Domain.Product;
using Xunit;

namespace TheShoppingBasketTests.Domain
{
    public class ProductsShould
    {
        private readonly Products _products;

        public ProductsShould()
        {
            _products = new Products();
        }

        [Fact]
        public void return_zero_cost_when_no_product_have_been_added()
        {
            Money cost = _products.Cost();

            Assert.Equal(new Money(0.0m), cost);
        }

        [Fact]
        public void return_cost_of_single_product_added()
        {
            AddProduct(new Bread());

            Money cost = _products.Cost();

            var singleProductCost = 1.00m;
            Assert.Equal(new Money(singleProductCost), cost);
        }

        [Fact]
        public void return_cost_when_contains_several_products()
        {
            AddProduct(new Milk());
            AddProduct(new Butter());
            AddProduct(new Bread());

            Money cost = _products.Cost();

            var severalProductsCost = 2.95m;
            Assert.Equal(new Money(severalProductsCost), cost);
        }

        [Fact]
        public void return_cost_when_contains_several_products_of_same_type()
        {
            AddProducts(new Bread(), 4);
            AddProducts(new Bread(), 2);

            Money cost = _products.Cost();

            var severalProductsCost = 6m;
            Assert.Equal(new Money(severalProductsCost), cost);
        }

        private void AddProduct(Product product)
        {
            AddProducts(product, 1);
        }

        private void AddProducts(Product product, int quantity)
        {
            product.AddQuantity(quantity);
            _products.Add(product);
        }
    }
}