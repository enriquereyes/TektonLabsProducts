namespace TektonLabsProducts.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int LocalStock { get; set; }    
        public float ProviderPrice { get; set; }
        public int ProviderStock { get; set; }
    }
}