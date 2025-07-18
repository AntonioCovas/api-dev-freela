using DevFreela.API.Models;
using DevFreela.Application.DTOs.InputModels;
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id == 0) return BadRequest();
            var user = _userService.GetById(id);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserInputModel inputModel)
        {
            var newUserId = _userService.Post(inputModel);
            return CreatedAtAction(nameof(GetById), newUserId, inputModel);
        }

        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] UpdateLoginInputModel inputModel)
        {
            _userService.Login(id, inputModel);
            return NoContent();
        }
    }
}
