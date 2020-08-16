using Microsoft.AspNetCore.Mvc;

namespace HBR.Project.Models
{
    public class UserViewModel
    {
        public int id_User { get; set; }
        public string _Name { get; set; }
        public string LastName { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public int _Password { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }
    }
}
