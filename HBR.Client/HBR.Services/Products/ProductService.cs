using HBR.Persistence;
using System;
using HBR.Persistence.Models;
using System.Collections.Generic;
using System.Linq;
using HBR.Services.Products.Dto;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace HBR.Services.Products
{
    public class ProductService : IProductService
    {
        private HbrContext _hbrContext;
        public ProductService(HbrContext hbrContext)
        {
            _hbrContext = hbrContext;
        }
        public List<Product> GetAll()
        {
            var result = new List<Product>();

            try
            {
                result = _hbrContext.Product.Include(x => x.idCategories).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
        public Product GetOne(int id)
        {
            var result = new Product();

            try
            {
                result = _hbrContext.Product.Include(x => x.idCategories).Where(x => x.id_Product == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
               public List<Categories> GetCategories()
        {
            var result = new List<Categories>();
            try
            {
                result = _hbrContext.Categories.ToList();

            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
       

        public List<Product> GetProductByCategories(int categoryId)
        {
            var result = new List<Product>();

            using (var connection = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-S87J8SH;Initial Catalog=HBR;Integrated Security=True;"))
            {
                var sql = "exec CategoryFilter @Categories";
                var values = new { Categories = categoryId };
                result = connection.Query<Product>(sql, values).ToList();
            }

            return result;
        }

    }

}
