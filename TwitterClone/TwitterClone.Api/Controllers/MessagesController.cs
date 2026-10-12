using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MessagesController : ControllerBase
    {
        public MessagesController() { }

        // GET /api/messages?senderId={senderId}&receiverId={receiverId}
        [HttpGet]
        public IActionResult GetMessages([FromQuery] Guid? senderId, [FromQuery] Guid? receiverId)
        {
            return Ok(new List<object>
            { 
                new
                {
                    MessageId = Guid.NewGuid(),
                    SenderId = senderId ?? Guid.NewGuid(),
                    ReceiverId = receiverId ?? Guid.NewGuid(),
                    Content = "Good Morning!!!",
                    SentAt =DateTime.UtcNow.AddMinutes(-15),
                    IsRead = true,
                },
                new
                {
                    MessageId = Guid.NewGuid(),
                    SenderId = senderId ?? Guid.NewGuid(),
                    ReceiverId = receiverId ?? Guid.NewGuid(),
                    Content = "today the sky is very Beautiful!!!",
                    SentAt =DateTime.UtcNow.AddMinutes(-10),
                    IsRead = false,
                },
            });
        }

        //GET/api/messages/{id}
        [HttpGet("{id}")]
        public IActionResult GetMessageById([FromRoute] Guid id)
        {
            return Ok(new
            {
                MessageId = id,
                SenderId = Guid.NewGuid(),
                ReceiverId = Guid.NewGuid(),
                Content = "message" + id.ToString(),
                SentAt = DateTime.UtcNow,
                IsRead = false,
            });
        }

        //GET/api/messages/conversation?userId={userId}&otherUserId={otherUserId}
        [HttpGet("conversation")]
        public IActionResult GetConversation([FromQuery] Guid userId, [FromQuery] Guid otherUserId)
        {
            return Ok(new List<object>
            {
                new
                {
                    MessageId = Guid.NewGuid(),
                    SenderId = userId,
                    ReceiverId =otherUserId,
                    Content = "Hello",
                    SentAt = DateTime.UtcNow.AddMinutes(-15),
                    IsRead = true,
                },
                new
                {
                    MessageId = Guid.NewGuid(),
                    SenderId = userId,
                    ReceiverId =otherUserId,
                    Content = "Hello",
                    SentAt = DateTime.UtcNow.AddMinutes(-1),
                    IsRead = false,
                }
            });

        }

        //POST/api/messages
        [HttpPost]
        public IActionResult SendMessage()
        {
            return Ok(new
            { 
                MessageId = Guid.NewGuid(),
                SenderId = Guid.NewGuid(),
                ReceiverId = Guid.NewGuid(),
                Content = "This is dotnet platform.",
                SentAt = DateTime.UtcNow,
                IsRead = false,
            });
        }

        //PUT/api/messages/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateMessage([FromRoute] Guid id)
        {
            return Ok(new
            { 
                MessageId = id,
                SenderId = Guid.NewGuid(),
                ReceiverId = Guid.NewGuid(),
                Content = "Hello" + id.ToString(),
                ModifiedAt = DateTime.UtcNow,
            });
        }

        //PATCH/api/messages/{id}
        [HttpPatch("{id}/read")]
        public IActionResult MarkMessageAsRead([FromRoute] Guid id)
        {
            return Ok(new
            {
                MessageId = id,
                IsRead = true,
            });
        }

        //DELETE/api/messages/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage([FromRoute] Guid id)
        {
            return Ok(new
            { 
                MessageId = id,
                Message = "Message deleted successfully.",
            });
        }
    }
}
