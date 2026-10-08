using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    // api/notifications
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NotificationsController : ControllerBase
    {
        public NotificationsController() { }

        // GET /api/notifications?userId={userId}&type={type}&isRead={isRead}
        [HttpGet]
        public IActionResult GetNotifications([FromQuery] Guid? userId,[FromQuery] string? type,[FromQuery] bool? isRead)
        {
            var triggeredByUserId = Guid.NewGuid();

            return Ok(new List<object>
            {
                new
                {
                    NotificationId =Guid.NewGuid(),
                    UserId = userId ?? Guid.NewGuid(),
                    Type ="Like",
                    Message = $"User with ID{triggeredByUserId} liked your post.",
                    IsRead = false,
                    CreatedAt =DateTime.UtcNow.AddMinutes(-20),
                },
                new
                {
                    NotificationId = Guid.NewGuid(),
                    UserId = userId ?? Guid.NewGuid(),
                    Type = "Comment",
                    Message = $"User with ID {triggeredByUserId} commented on your post.",
                    IsRead = false,
                    CreatedAt = DateTime.UtcNow.AddMinutes(-15),
                },
                new
                {
                    NotificationId = Guid.NewGuid(),
                    UserId = userId ?? Guid.NewGuid(),
                    Type = "Mention",
                    Message = $"User with ID {triggeredByUserId} mentioned you in a post.",
                    IsRead = true,
                    CreatedAt = DateTime.UtcNow.AddMinutes(-10),
                },
                new
                {
                    NotificationId = Guid.NewGuid(),
                    UserId = userId ?? Guid.NewGuid(),
                    Type = "FriendRequest",
                    Message = $"User with ID {triggeredByUserId} sent you a friend request.",
                    IsRead = true,
                    CreatedAt = DateTime.UtcNow.AddMinutes(-5),
                },
                new
                {
                    NotificationId = Guid.NewGuid(),
                    UserId = userId ?? Guid.NewGuid(),
                    Type = "System",
                    Message = "System Notification: Unknown Error",
                    IsRead = false,
                    CreatedAt = DateTime.UtcNow,
                },
            });
        }

        // GET/api/Notification/{id}
        [HttpGet("{id}")]
        public IActionResult GetNotificationById([FromRoute] Guid id)
        {
            return Ok(new
            {
                NotificationId = id,
                UserId = Guid.NewGuid(),
                Type = "Like",
                Message = $"User with ID {Guid.NewGuid()} liked your post.",
                IsRead = false,
                CreatedAt = DateTime.UtcNow,

            });
        }

        //POST/api/notification
        [HttpPost]
        public IActionResult CreateNotification()
        {
            return Ok(new
            {
                NotificationId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                Type = "System",
                TriggeredByUserId = Guid.NewGuid(),
                Message = "System Notification: Unknown Error",
                IsRead = false,
                CreatedAt = DateTime.UtcNow,
            });
        }

        //PATCH/api/notifications/{id}/read
        [HttpPatch]
        public IActionResult MarkNotificationAsRead([FromQuery] Guid id)
        {
            return Ok(new
            {
                NotificationId = id,
                IsRead = true,
            });
        }

        //PATCH/api/notifications/read-all?userId={userId}
        [HttpPatch("read-all")]
        public IActionResult MarkAllNotificationsAsRead([FromQuery] Guid userId)
        {
            return Ok(new
            {
                UserId = userId,
                Message = "ALl notification marked as read.",
            });
        }

        // DELETE/api/notification/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteNotification([FromRoute] Guid id)
        {
            return Ok(new
            {
                NotificationId = id,
                Message = "Notification deleted successfully.",
            });
        }
    }
}
