using System.Collections.Generic;
using System.Linq;

namespace TheShoppingBasket.Domain.Basket
{
    public class Products
    {
        private readonly IList<Product> _products;

        public Products()
        {
            _products = new List<Product>();
        }

        public void Add(Product product)
        {
            var existingProduct = _products
                .SingleOrDefault(p => p.Equals(product));

            if (existingProduct != null)
            {
                existingProduct.IncreaseQuantity(product);
                return;
            }
            
            _products.Add(product);
        }

        public Money TotalCost()
        {
            var cost = new Money();

            if (_products.Any())
            {
                cost = _products
                    .Select(product => product.Cost())
                    .Aggregate((amount, nextAmount) => amount + nextAmount);
            }

            return cost;
        }

        public Product Find(Product product)
        {
            return _products
                .Where(p => p.Equals(product))
                .DefaultIfEmpty(new NullProduct())
                .Single();
        }
    }
}