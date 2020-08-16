using HBR.Services.Category.Dto;

namespace HBR.Services.Products.Dto
{
    public class ProductDto
    {
        public int id_Product { get; set; }
        public string _Name { get; set; }
        public int Price { get; set; }
        public string Expiration { get; set; }
        public string _Provider { get; set; }
        public string Direction { get; set; }
        //public string idCategories { get; set; }
        public int idCategoriesid_Categories { get; set; }

        public virtual CategoriesDto idCategories { get; set; }
    }
}
