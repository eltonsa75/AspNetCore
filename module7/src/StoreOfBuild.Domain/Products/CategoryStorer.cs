using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOfBuild.Domain.Products
{
    public class CategoryStorer
    {

        private readonly IRepository<Category> _categoryRepository;
        public CategoryStorer(IRepository<Category> _categoryRepository);

        public CategoryStorer(IRepository<Category> _categoryRepository)
        {
            _categoryRepository = _categoryRepository;
        }

        public void Store(CategoryDto dto) 
        {
            var category = _categoryRepository.GetById(dto.Id);

            if(category == null) 
            {
                category = new CategoryStorer(dto.Name);
                _categoryRepository.Save(category);
            }
            else 
            {
                category.Update(dto.Name);
            }
        }
    }
}