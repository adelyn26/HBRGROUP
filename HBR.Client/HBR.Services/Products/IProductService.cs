using HBR.Persistence.Models;
using HBR.Services.Products.Dto;
using System.Collections.Generic;

namespace HBR.Services.Products
{
    public interface IProductService
    {
     
        List<Product> GetAll();
        Product GetOne(int id);
        List<Categories> GetCategories();
        List<Product> GetProductByCategories(int categoryId);
    }
}


