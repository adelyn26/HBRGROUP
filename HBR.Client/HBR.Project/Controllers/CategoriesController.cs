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

       
    }
}
