﻿using System.Collections;
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
                existingProduct.IncreaseQuantityBy(product.Quantity);
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

        public int QuantityOf(Product product)
        {
            return Find(product).Quantity;
        }

        private Product Find(Product product)
        {
            return _products
                .Where(p => p.Equals(product))
                .DefaultIfEmpty(new NullProduct())
                .Single();
        }
    }
}