using Review.Domain.Models;

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
                .Any(x => x.UserName == login.UserName && x.Password == login.Password);
        }
    }
}
