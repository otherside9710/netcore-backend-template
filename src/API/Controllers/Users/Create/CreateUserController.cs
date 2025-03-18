using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Contracts;
using Domain.Entities;

namespace API.Controllers.Users.Create
{
    [ApiController]
    [Route("api/users")]
    public class CreateUserController : ControllerBase
    {
        private readonly IUserService _userService;

        public CreateUserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            var createdUser = await _userService.CreateUser(user);
            return CreatedAtAction(nameof(CreateUser), new { id = createdUser.Id }, createdUser);
        }
    }
}