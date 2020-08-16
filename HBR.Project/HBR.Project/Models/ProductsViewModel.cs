namespace HBR.Project.Models
{
    public class Products
    {
        public int id_Product { get; set; }
        public string _Name { get; set; }
        public int Price { get; set; }
        public int Expiration { get; set; }
        public string _Provider { get; set; }
        public string Direction { get; set; }
        public int idCategories { get; set; }
    }
}
