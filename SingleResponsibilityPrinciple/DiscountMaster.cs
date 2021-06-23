using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart_With_SRP
{
    public class DiscountMaster
    {
        public double CalculateDiscount(Product product)
        {
            if (product.name == "Mobile")
            {
                return (product.price * 10) / 100;
            }
            else
            {
                return 0;
            }
        }
    }
}
