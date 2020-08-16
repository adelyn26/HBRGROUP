using HBR.Persistence.Models;

namespace HBR.Services.Users
{
    public interface IUsersService
    {
        Persistence.Models.Users GetOne(int id_User);
        //Persistence.Models.Users Login(Persistence.Models.Users user);
        //Persistence.Models.Users Register(Persistence.Models.Users user);
        Persistence.Models.Users Edit(Persistence.Models.Users user);
        public Persistence.Models.Users Delete(Persistence.Models.Users user);
    }
}
