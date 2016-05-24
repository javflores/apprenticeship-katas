using System;
using System.Collections.Generic;
using TheShoppingBasket.Domain.Basket;

namespace TheShoppingBasket.Services
{
    public interface IProductWarehouse
    {
        Product Find(string product, int quantity);
    }

    internal class ProductWarehouse : IProductWarehouse
    {
        private readonly Dictionary<string, Func<int, Product>> _productCatalogue;

        public ProductWarehouse()
        {
            _productCatalogue = new Dictionary<string, Func<int, Product>>
            {
                ["bread"] = (quantity) => new Bread(quantity),
                ["milk"] = (quantity) => new Milk(quantity),
                ["butter"] = (quantity) => new Butter(quantity)
            };
        }

        public Product Find(string product, int quantity)
        {
          return _productCatalogue.ContainsKey(product) ? PrepareProduct(product, quantity) : new NullProduct();
        }

        private Product PrepareProduct(string product, int quantity)
        {
            return _productCatalogue[product](quantity);
        }
    }
}