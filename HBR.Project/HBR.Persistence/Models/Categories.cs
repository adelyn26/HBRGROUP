using System.Collections.Generic;

namespace HBR.Persistence.Models
{
    public class Categories
    {
        
        public int id_Categories { get; set; }
        public string _Name { get; set; }
        public virtual List<Product> product { get; set; }
    }
}
