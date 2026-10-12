using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        public UsersController() { }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(new List<object>
            {
                new
                {
                    UserId =Guid.NewGuid(),
                    UserName = "user1",
                },
                 new
                {
                    UserId =Guid.NewGuid(),
                    UserName = "user2",
                },
            });
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateUser()
        {
            return Ok(
               new
               {
                   UserId = Guid.NewGuid(),
                   UserName = "newuser",
               });
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute] Guid id)
        {
            return Ok(
                new
                {
                    UserId = id,
                    UserName = "user" + id.ToString(),
                });
        }

        [HttpPut("{id}")]

        public IActionResult UpdateUser([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                UserName = "user" + id.ToString(),
            });
        }

        [HttpPatch("{id}/phoneNumber")]
        public IActionResult UpdateUserPhoneNumber([FromRoute] Guid id, [FromBody] string phoneNumber)
        {
            return Ok("hello");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                Message = "user deleted successfully.",
            });
        }
    }
}
