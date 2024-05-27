using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOfBuild.Domain.Products
{
    public class Category
    {
            public int Id { get; private set; }
            public string Name { get; private set; }

            public Category(string Name) 
            {
               ValidateNameAndsetName(name);
            }
            public void Update(string name)
            {
                 ValidateNameAndsetName(name);
            }
            public void ValidateNameAndsetName(string Name) 
            {
                DomainException.when(string.IsNullOrEmpty(name), "Name is required");

                Name = name;
            }

    }
}