using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOfBuild.Domain.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
            public string Name{ get; set; }

            public Categoryid {get; set;}

            public decimal Price { get; set; }

            public int StockQuantity { get; set; }
    }
}