using CorporateQnA.Data.Models;
using Dapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Data.Services
{
    public class AuthService:IAuthService
    {
        private readonly IDbConnection connection;
        private readonly UserManager<AuthUser> _userManager;
        public AuthService(IConfiguration config, UserManager<AuthUser> userManager)
        {
            connection = new SqlConnection(config.GetConnectionString("CorporateQnADatabase"));
            _userManager = userManager;
        }

        public async Task<IdentityResult> Signup(AuthUser user,string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<AuthUser> Login(string email, string password)
        {
            var sql = "select * from UserDetails where Email=@Email";
            var user = await connection.QueryFirstOrDefaultAsync<AuthUser>(sql, new { Email = email });
            if (user != null)
            {
                bool canLogin = await _userManager.CheckPasswordAsync(user, password);
                if (canLogin)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
