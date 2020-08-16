using HBR.Persistence;
using HBR.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HBR.Services.Category
{
    public class CategoriesService : ICategoriesService
    {
        private HbrContext _hbrContext;
        public CategoriesService(HbrContext hbrContext)
        {
            _hbrContext = hbrContext;
        }

        public List<Persistence.Models.Categories> GetAll()
        {
            var result = new List<Persistence.Models.Categories>();

            try
            {
                result = _hbrContext.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public Categories GetOne(int id)
        {
            var result = new Categories();

            try
            {
                result = _hbrContext.Categories.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public Categories Create(Categories categories)
        {
            var result = new Categories();
            try
            {
                if (result != null)
                {
                    result._Name = categories._Name;
                    result.id_Categories = categories.id_Categories;
                    _hbrContext.Categories.Add(result);
                    _hbrContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
        public Categories Edit( Categories categories)
        {
            var result = new Categories();
            try
            {
                result = _hbrContext.Categories.Find(categories.id_Categories);

                if (result != null)
                {
                    result._Name = categories._Name;
                    result.id_Categories = categories.id_Categories;
                    _hbrContext.Categories.Update(result);
                    _hbrContext.SaveChanges();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }
        public Categories Delete(Categories categories)
        {
            var result = new Categories();
            try
            {
                result = _hbrContext.Categories.Find(categories.id_Categories);

                if (result != null)
                {
                    result._Name = categories._Name;
                    result.id_Categories = categories.id_Categories;
                    _hbrContext.Categories.Remove(result);
                    _hbrContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
    }

}
