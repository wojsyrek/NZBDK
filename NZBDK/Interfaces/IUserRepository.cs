using NZBDK.Models;

namespace NZBDK.Interfaces
{
    public interface IUserRepository
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        User GetUserById(int id);
    }
}
