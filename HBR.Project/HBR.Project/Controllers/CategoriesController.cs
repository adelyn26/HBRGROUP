using HBR.Persistence.Models;
using HBR.Services.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HBR.Project.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ILogger<CategoriesController> _logger;
        private ICategoriesService _service;

        public CategoriesController(ILogger<CategoriesController> logger, ICategoriesService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public ActionResult Index(Categories categories)
        {

            var data = _service.GetAll();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categories categories)
        {
            if (ModelState.IsValid)
            {

                var data = _service.Create(categories);
            }
            return RedirectToAction("Index", "Categories");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

            var data = _service.GetOne(id); 
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categories categories)
        {
            if (ModelState.IsValid)
            {
                var data = _service.Edit(categories);
                return View(data);
            }
            return View(categories);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {

            var data = _service.GetOne(id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Categories categories)
        {
            if (ModelState.IsValid)
            {
                var data = _service.Delete(categories);
                return View(data);
            }
            return View(categories);
        }

    }
}
