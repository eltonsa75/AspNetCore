using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreOfBuild.Domain.Dtos;

namespace StoreOfBuild.Domain.Products
{
    public class CategoryStorer
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryStorer(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Store(CategoryDto dto)
        {
            var category = _categoryRepository.GetById(dto.Id);
        }
        else 
        category.Update(dto.Name);
    }
}