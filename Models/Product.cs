namespace LearnBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        public double price { get; set; }
        public string Name { get; set; }
        public bool isActive { get; set; }
        public IEnumerable<Product__prop> ProductProperies { get; set; }

    }
}
