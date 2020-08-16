using HBR.Persistence;
using HBR.Persistence.Models;
using HBR.Services.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace HBR.Project.Controllers
{
    public class UsersController : Controller
    {
        
        private HbrContext _hbrContext;
        private readonly ILogger<UsersController> _logger;
        private IUsersService _service;
   

        public UsersController(ILogger<UsersController> logger, IUsersService service, HbrContext hbrContext)
        {
            _logger = logger;
            _service = service;
            _hbrContext = hbrContext;
        }

        
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Login")]
        public ActionResult Login(Users user)
        {
            var exist = _hbrContext.Users.Where(person => (person.Email == user.Email) && (person._Password == user._Password)).FirstOrDefault();
           

                if (exist != null)
                {
                 HttpContext.Session.SetInt32("SessionIdUser", exist.id_User);
                HttpContext.Session.SetString("SessionName", exist._Name);

                return RedirectToAction("Index", "Home");
                

               }
                else
                {
                ViewBag.Message = "Email o Contrasena incorrecta, porfavor introducir nuevamente";
                
                return View();
            }

        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(Users users)
        {
            var result = new Users();
            var exist = _hbrContext.Users.Where(person => (person.Email == users.Email) && (person._Password == users._Password)).Count();
            if (exist < 1)
            {
                result._Name = users._Name;
                result.id_User = users.id_User;
                result.LastName = users.LastName;
                result.Telephone = users.Telephone;
                result.Email = users.Email;
                result._Password = users._Password;
                _hbrContext.Users.Add(result);
                _hbrContext.SaveChanges();

                return RedirectToAction("Login", "Users");
            }
            else
            {
                ViewBag.Message = "El usuario ya esta registrado.";

                return View();
            }

        }

        [HttpGet]
        public ActionResult Profile(int id)
        {
            var A = HttpContext.Session.GetInt32("SessionIdUser");
            int UserId = Convert.ToInt32(A);
            var data = _hbrContext.Users.Where(person => (person.id_User == UserId )).FirstOrDefault();
            return View(data);
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login", "Users");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var A = HttpContext.Session.GetInt32("SessionIdUser");
            int UserId = Convert.ToInt32(A);
            var data = _hbrContext.Users.Where(person => (person.id_User == UserId)).FirstOrDefault();
            return View(data);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Users user)
        {
            if (ModelState.IsValid)
            {
                var data = _service.Edit(user);
                return RedirectToAction("Profile", "Users");
            }
            return View();
        }

     

    }

}

    
    

