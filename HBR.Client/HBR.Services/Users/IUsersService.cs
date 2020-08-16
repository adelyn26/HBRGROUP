using HBR.Persistence.Models;

namespace HBR.Services.Users
{
    public interface IUsersService
    {
        Persistence.Models.Users GetOne(int id_User);
        Persistence.Models.Users Edit(Persistence.Models.Users user);
    }
}
