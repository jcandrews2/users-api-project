using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using UsersApiProject.Services;
using UsersApiProject.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;

namespace UsersApiProject.Controllers
{
    [Route("/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public ActionResult<List<User>> GetUsers(string? searchString = null)
        {
            var users = _usersService.AllUsers(searchString);

            if (users != null && users.Count > 0)
            {
                return Ok(users);
            }

            return NotFound();
        }
    }
}

