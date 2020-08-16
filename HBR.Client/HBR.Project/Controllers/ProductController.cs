using HBR.Persistence.Models;
using HBR.Services.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HBR.Services.Category;

namespace HBR.Project.Controllers
{

    public class ProductController : Controller
    {
        
        private readonly ILogger<ProductController> _logger;
        private IProductService _service;

        public ProductController(ILogger<ProductController> logger, IProductService service, ICategoriesService categories)
        {
            _logger = logger;
            _service = service;
        }
        [HttpGet]
        public IActionResult Index(Product product)
        {

            var data = _service.GetAll();
            return View(data);
        }


        public IActionResult GetProductsByCategories(int categoryId)
        {
            var data = _service.GetProductByCategories(categoryId);
            return View(data);
        }
    }
 
}
