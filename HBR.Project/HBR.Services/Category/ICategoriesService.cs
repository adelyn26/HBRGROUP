using HBR.Persistence.Models;
using System.Collections.Generic;

namespace HBR.Services.Category
{
    public interface ICategoriesService
    {
        List<Categories> GetAll();
        Categories GetOne(int id);
        Categories Edit(Categories categories);
        Categories Delete(Categories categories);
        Categories Create(Categories categories);
    }
}