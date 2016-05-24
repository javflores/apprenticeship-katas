using TheShoppingBasket.Domain;
using TheShoppingBasket.Domain.Basket;
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
            Money cost = _products.TotalCost();

            Assert.Equal(new Money(0.0m), cost);
        }

        [Fact]
        public void return_cost_of_single_product_added()
        {
            var product = new Bread();
            AddProduct(product);

            Money totalCost = _products.TotalCost();

            var singleProductPrice = product.Price;
            Assert.Equal(singleProductPrice, totalCost);
        }

        [Fact]
        public void return_cost_when_contains_several_products()
        {
            AddSeveralProducts();

            Money totalCost = _products.TotalCost();

            var severalProductsCost = new Money(2.95m);
            Assert.Equal(severalProductsCost, totalCost);
        }

        [Fact]
        public void return_cost_when_contains_several_products_of_same_type()
        {
            AddProducts(new Bread(), 4);
            AddProducts(new Bread(), 2);

            Money totalCost = _products.TotalCost();

            var severalProductsCost = new Money(6m);
            Assert.Equal(severalProductsCost, totalCost);
        }

        private void AddProduct(Product product)
        {
            AddProducts(product, 1);
        }

        private void AddSeveralProducts()
        {
            AddProduct(new Milk());
            AddProduct(new Butter());
            AddProduct(new Bread());
        }

        private void AddProducts(Product product, int quantity)
        {
            product.IncreaseQuantityBy(quantity);
            _products.Add(product);
        }
    }
}