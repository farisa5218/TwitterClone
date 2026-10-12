using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwittersController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TwittersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpGet]

        public IActionResult GetTweet()
        {
            var tweets = new List<object>
            {
                new
                {
                    UserId = Guid.NewGuid(),
                    Content = "Hello world.",
                },

                new
                {
                    UserId = Guid.NewGuid(),
                    Content = "This is second tweets",
                },

            };
            return Ok(tweets);
        }
    }
}
