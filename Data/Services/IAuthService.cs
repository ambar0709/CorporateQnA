using CorporateQnA.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Data.Services
{
    public interface IAuthService
    {
        public Task<IdentityResult> Signup(AuthUser user, string password);
        public Task<AuthUser> Login(string email, string password);
    }
}
