﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NJAuto.Server.Data;
using NJAuto.Shared.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NJAuto.Server.Controllers
{
    [Route("/registerController")]
    [ApiController]
    public class RegisterController : Controller
    {

        private readonly UserManager<UserEntity> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public RegisterController(UserManager<UserEntity> userManager,
          RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }


        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterUser request)
        {
            var existingUser = await _userManager.FindByNameAsync(request.Username);
            if (existingUser is not null)
            {
                return BadRequest("Username is already taken");
            }

            if (await _roleManager.FindByNameAsync("Admin") is null)
            {
                await _roleManager.CreateAsync(new()
                {
                    Name = "Admin"
                });
            }

            var user = new UserEntity()
            {
                UserName = request.Username,
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            await _userManager.AddToRoleAsync(user, "Admin");

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok("User created");
        }
    }
}
