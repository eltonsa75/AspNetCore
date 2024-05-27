using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOfBuild.Domain.Products
{
    public class Category
    {
        public int Id {get; private set;}

        public string Name { get; private set; }

        public Category(string name)
        {
            ValidateNameandsetName(name)          
        }
        public void Update(string name) 
        {
            ValidateNameandsetName(name)  
        }
        public void ValidateNameandsetName(string name)
        {

            DomainException.When(string.IsNullOrEmpty(name), "Name is required");
            Name = name;
        }

    }
}