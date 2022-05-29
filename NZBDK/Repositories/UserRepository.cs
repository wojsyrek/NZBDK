using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NZBDK.Data;
using NZBDK.Helpers;
using NZBDK.Interfaces;
using NZBDK.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NZBDK.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppSettings _appSettings;
        private readonly NzbdkDBContext _context;

        public UserRepository(IOptions<AppSettings> appSettings, NzbdkDBContext context)
        {
            _appSettings = appSettings.Value;
            _context = context;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _context.Users.SingleOrDefault(o => o.Name == model.Name & o.Password == model.Password);

            if (user == null) return null;

            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        private string generateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}
