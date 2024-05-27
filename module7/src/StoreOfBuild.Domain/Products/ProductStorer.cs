using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreOfBuild.Domain.Dtos;

namespace StoreOfBuild.Domain.Products
{
    public class ProductStorer
    {

        private readonly IRepository<Product> _productRepository {get; private set;}
        private readonly IRepository<Category> _categoryRepository {get; private set;}

        public ProductStorer(IRepositore<Product> productRepository, IRepositore<Category> categoryRepository)
        {
            _productRepository = productRepository;
            _categoryrepository = categoryRepository;
        }

        public void Store(ProductDto dto)
        {
            var category = _categoryRepository.GetById(dto.Categoryid);
            DomainException.when(category == null, "Category invalid");

            var product = _productRepository.GetById(dto.Id);
            if(product == null)
            {
                product = new Product(dto.Name,category, dto.Price, dto.StockQuantity);
                _productRepository.save(product);
            }
            else 
            {
                product.Update(dto.Name,category, dto.Price, dto.StockQuantity);
            }
        }

    }
}