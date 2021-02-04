using AutoMapper;
using CorporateQnA.Data.Models;
using CorporateQnA.Models;
using Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CorporateQnA.Controllers
{
    public class AuthenticationController:ControllerBase
    {
        
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;
        public AuthenticationController(IAuthService authService,IMapper mapper)
        {
            _authService = authService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Signup([FromBody] User userData)
        {
            var user = _mapper.Map<AuthUser>(userData);
            user.UserName = userData.Email;
            user.Id = Guid.NewGuid().ToString();
            var result = await _authService.Signup(user, userData.Password);
            if (result.Succeeded)
            {
                user.PasswordHash = null;
                user.SecurityStamp = null;
                return Ok(user);
            }
            else
            {
                return BadRequest(new { message = result.Errors });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Login([FromBody] User userData)
        {
            var user = await _authService.Login(userData.Email, userData.Password);
            if (user != null)
            {
                return Ok(user);
            }
            return BadRequest();
        }
    }
}
