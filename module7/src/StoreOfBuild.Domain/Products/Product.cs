using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOfBuild.Domain.Products
{
    public class Product
    {
            public int Id { get; set; }
            public string Name{ get; set; }

            public Category Category {get; set;}

            public decimal Price { get; set; }

            public int StockQuantity { get; set; }

            public Product(string name, Category category, decimal price, int StockQuantity)
            {
                ValidateValues(name, category, price, StockQuantity);
                SetProperties(name, category, price, StockQuantity);
            }
            public void Update(string name, Category category, decimal price, int StockQuantity)
            {
                ValidateValues(name, category, price, StockQuantity);
                SetProperties(name, category, price, StockQuantity);
            }
            public void SetProperties(string name, Category category, decimal price, int StockQuantity)
            {
                                Name = name;
                Category = category;
                Price = price;
                StockQuantity = StockQuantity;
            }

               public static void ValidateValues(string name, Category category, decimal price, int StockQuantity)
            {
                DomainException.when(string.IsNullOrEmpty(name), "Name is required");
                DomainException.when(category == null, "Category is required");
                DomainException.When(price < 0, "Price is required");
                DomainException.When(stockeQuantity < 0, "Stock quantity is required");

            }

    }
}