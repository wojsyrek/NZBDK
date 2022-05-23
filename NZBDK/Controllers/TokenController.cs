﻿/*using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NZBDK.Data;
using NZBDK.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NZBDK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly NzbdkDBContext _context;

        public TokenController(IConfiguration config, NzbdkDBContext context)
        {
            _configuration = config;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post(User _userData)
        {
            if (_userData != null && _userData.Name != null && _userData.Password != null)
            {
                var user = await GetUser(_userData.Name, _userData.Password);

                if (user != null)
                {
                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", user.Id.ToString()),
                        new Claim("DisplayName", user.Name)
                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(10),
                        signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<User> GetUser(string Name, string Password)
        {
            *//*return await _context.User.FirstOrDefaultAsync(u => u.Name == Name && u.Password == Password);*//*
            return new User { Name = Name, Password = Password };
        }
    }
}
*/