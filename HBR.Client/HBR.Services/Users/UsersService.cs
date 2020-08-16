using HBR.Persistence;
using System;
using System.Linq;


namespace HBR.Services.Users
{
    public class UsersService : IUsersService
    {

        private HbrContext _hbrContext;
        public UsersService(HbrContext hbrContext)
        {
            _hbrContext = hbrContext;
        }

        public Persistence.Models.Users GetOne(int id_User)
        {
            var result = new Persistence.Models.Users();

            try
            {
                result = _hbrContext.Users.Where(x => x.id_User == x.id_User).FirstOrDefault();

                double IdUser = result.id_User;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }


        public Persistence.Models.Users Edit(Persistence.Models.Users user)
        {
            var result = new Persistence.Models.Users();
            try
            {
                result = _hbrContext.Users.Find(user.id_User);

                if (result != null)
                {
                    result.id_User = user.id_User;
                    result._Name = user._Name;
                    result.LastName = user.LastName;
                    result.Telephone = user.Telephone;
                    result.Email = user.Email;
                    result._Password = user._Password;
                    _hbrContext.Users.Update(result);
                    _hbrContext.SaveChanges();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }
     
    }
}
