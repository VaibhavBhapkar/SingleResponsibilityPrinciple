using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart_Without_SRP
{
    public class ShoppingCart
    {
        List<Product> products = new List<Product>();
        public List<Product> AddProduct()
        {
            Product product = new Product();
            product.name = "Mobile";
            product.price = 1000;
            products.Add(product);
            return products;
        }
        private double CalculateDiscount(Product product)
        {
            if(product.name=="Mobile")
            {
                return (product.price * 10) / 100;
            }
            else
            {
                return 0;
            }
        }
        public double Checkout(List<Product> products)
        {
            double finalCost=0;
            foreach(Product product in products)
            {
                double discountedPrice = CalculateDiscount(product);
                finalCost = finalCost + (product.price - discountedPrice);
            }
            return finalCost;
        }
    }
}
