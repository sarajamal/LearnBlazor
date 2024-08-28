﻿namespace LearnBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<ProductPropareties> productPropareties { get; set; }

    }
}
