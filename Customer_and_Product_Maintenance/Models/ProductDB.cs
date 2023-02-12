using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Lab3.Models
{
    public class ProductDB
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product(){ProductCode = "P101", ProductName = "Shampoo", Price = 12},
            new Product(){ProductCode = "P102", ProductName = "Conditioner", Price = 14},
            new Product(){ProductCode = "P103", ProductName = "Body Wash", Price = 18},
            new Product(){ProductCode = "P104", ProductName = "Body Lotion", Price = 25},
            new Product(){ProductCode = "P105", ProductName = "Powder", Price = 10},
            new Product(){ProductCode = "P106", ProductName = "Perfume", Price = 6}
        };

        public static List<Product> GetProducts()
        {
            return _products;
        }

      

    }
}
