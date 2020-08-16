using HBR.Persistence.Models;
using HBR.Services.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using Newtonsoft.Json;
using HBR.Services.Category;
using HBR.Services.Products.Dto;

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
            return Json(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductDto product)
        {
            var data = _service.Create(product);
            return RedirectToAction("Index", "Product");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

            var data = _service.GetOne(id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            
                var data = _service.Edit(product);
                return RedirectToAction("Index", "Product");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var data = _service.GetOne(id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Persistence.Models.Product product)
        {
            if (ModelState.IsValid)
            {
               var data = _service.Delete(product);
                return View(data);
            }
            return View();
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            
             var data = _service.GetOne(id);
              return View(data);
            

        }
     
        public JsonResult GetCategories()
        {
            object data;
            try
            {
                data = _service.GetCategories().ToList().Select(a => new SelectListItem
                {
                    Text = a._Name,
                    Value = a.id_Categories.ToString()
                }).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            data = JsonConvert.SerializeObject(data);
            return this.Json(data);
        }

    }
    
}
