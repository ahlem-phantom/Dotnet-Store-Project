using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
