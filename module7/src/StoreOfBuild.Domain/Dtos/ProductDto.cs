using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOfBuild.Domain.Dtos
{
    public class ProductDto
    {
        public int Id { get; private set; }
        public string Name {get; private set;}

        public int Categoryid {get; private set;}

        public decimal Price {get; private set;}

        public int StockQuantity {get; private set;}
    }
}