using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TweetsController : ControllerBase
    {
        public TweetsController() { }


        [HttpGet]
        public IActionResult GetTweets([FromQuery] Guid? userId)
        {
            return Ok(new List<object>
            {
                new
                {
                    TweetId = Guid.NewGuid(),
                    UserId = userId ?? Guid.NewGuid(),
                    content ="hello,world!",
                    CreatedAt = DateTime.UtcNow.AddHours(-2),
                },
                new
                {
                    TweetId = Guid.NewGuid(),
                    UserId = userId ?? Guid.NewGuid(),
                    Content = "This is my second tweet.",
                    CreatedAt = DateTime.UtcNow.AddHours(-1),
                } 
            });
        }
        [HttpGet("{id}")]
        public IActionResult GetTweetById([FromRoute] Guid id)
        {
            return Ok(new
            {
                TweetId = id,
                UserId = Guid.NewGuid(),
                content = "tweet" + id.ToString(),
                CreatedAt =DateTime.UtcNow,
            });

        }

        [HttpPost]
        public IActionResult CreateTweet()
        {
            return Ok(new
            { 
                TweetId = Guid.NewGuid(),
                UserId =Guid.NewGuid(),
                Content ="New tweet content.",
                createdAt =DateTime.UtcNow,
            });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTweet([FromRoute] Guid id)
        {
            return Ok(new
            {
                TweetId = id,
                UserId = Guid.NewGuid(),
                Content = "updatedtweet" + id.ToString(),
                ModifiedAt = DateTime.UtcNow,
            });
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTweet([FromRoute] Guid id)
        {
            return Ok(new
            {
                TweetId = id,
                Message = "Tweet deleted successfully.",
            });
        }
    }
}
