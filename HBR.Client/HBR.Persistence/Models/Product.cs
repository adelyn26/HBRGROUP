using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HBR.Persistence.Models
{
    public class Product
    {
        public int id_Product { get; set; }
        public string _Name { get; set; }
        public int Price { get; set; }
        public string Expiration { get; set; }
        public string _Provider { get; set; }
        public string Direction { get; set; }
        public int idCategoriesid_Categories { get; set; }
        public virtual Categories idCategories { get; set; }
    }
}
