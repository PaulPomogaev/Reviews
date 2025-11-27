using Review.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Review.Domain.Services
{
    public class LoginService : ILoginService
    {
        private readonly DataBaseContext databaseContext;

        public LoginService(DataBaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public bool CheckLogin(Login login)
        {
            if(login?.UserName == null || login?.Password == null)
            {
                return false;
            }

            return databaseContext.Logins
                .Any(x => x.UserName.Equals(login.UserName, StringComparison.OrdinalIgnoreCase) &&
                          x.Password.Equals(login.Password, StringComparison.OrdinalIgnoreCase));
        }
    }
}
