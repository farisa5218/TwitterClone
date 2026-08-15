# Twitter Clone — ASP.NET Core

A production-style Twitter (X) clone built step-by-step using ASP.NET Core, following Clean Architecture and Domain-Driven Design (DDD) principles. The project is developed incrementally for learning: each commit represents a new step.

---

## Project Status

> Work In Progress — Built incrementally as part of an ASP.NET Core course.

| Layer                          | Status            |
|--------------------------------|-------------------|
| Domain Layer                   | ✅ Completed      |
| Application Layer              | Coming Soon       |
| Infrastructure Layer           | Coming Soon       |
| API / Presentation Layer       | Coming Soon       |
| Authentication (JWT)           | Coming Soon       |
| Database (EF Core + SQL Server)| Coming Soon       |
| Real-time (SignalR)            | Coming Soon       |

---

## Architecture

This project follows Clean Architecture with clearly separated concerns:

```
TwitterClone/
│
├── TwitterClone.Domain/          # Core domain entities & business rules
├── TwitterClone.Application/     # (Coming Soon) Use cases, DTOs, interfaces
├── TwitterClone.Infrastructure/  # (Coming Soon) EF Core, repositories, external services
└── TwitterClone.API/             # (Coming Soon) Controllers, APIs, SignalR Hubs
```

### Why Clean Architecture?

- Independent of frameworks — business logic does not depend on ASP.NET
- Testable — each layer can be tested in isolation
- Maintainable — clear boundaries make changes easier

---

## Domain Layer — Entities

The domain layer contains the core business entities with encapsulated logic and domain validation. Properties use private setters to enforce invariants through constructors and methods.

### User

- Id (Guid), UserName, Email
- Created via constructor — ensures required fields are set

### Tweet

- Id, AuthorId, Content
- Content cannot be empty
- Content cannot exceed 280 characters

### Follow

- FollowerId, FollowingId, FollowedAt
- A user cannot follow themselves

### Like

- Tracks which user liked which tweet

### Bookmark

- Tracks saved tweets per user

### Retweet

- Tracks retweet relationships

### Message (Direct Message)

- SenderId, ReceiverId, Content, SentAt
- Sender and receiver cannot be the same
- Content cannot be empty

### Notification

- UserId, Message, IsRead, CreatedAt
- Starts as unread (IsRead = false)
- MarkAsRead() method to update state

---

## Tech Stack

| Technology                      | Purpose                            |
|---------------------------------|------------------------------------|
| .NET 10 / ASP.NET Core          | Web framework                      |
| C# 12                           | Programming language               |
| Entity Framework Core           | ORM (coming soon)                  |
| SQL Server                      | Database (coming soon)             |
| JWT Bearer Auth                 | Authentication (coming soon)       |
| SignalR                         | Real-time messaging (coming soon)  |

---

## Getting Started

### Prerequisites

- .NET 10 SDK: https://dotnet.microsoft.com/
- Visual Studio 2026 (recommended) or VS Code with C# extension

### Clone the Repository

```bash
git clone https://github.com/farisa5218/TwitterClone.git
cd TwitterClone
```

### Build the Solution

```bash
dotnet build
```

### Run the Project

> The API layer is not yet added. Currently only the Domain layer exists.

```bash
dotnet run --project TwitterClone.API   # Available after API layer is added
```

---

## Step-by-Step Build Log

Each commit in this repo represents a learning step:

| Step | What Was Built |
|---|---|
| Step 1 | Solution setup + Domain layer created |
| Step 2 | (Coming next...) |

---

## Project Structure (Current)

```
twitter-clone/
├── .gitignore
├── README.md
└── TwitterClone/
    ├── TwitterClone.slnx
    └── TwitterClone.Domain/
        ├── User.cs
        ├── Tweet.cs
        ├── Follow.cs
        ├── Like.cs
        ├── Bookmark.cs
        ├── Retweet.cs
        ├── Message.cs
        ├── Notification.cs
        └── TwitterClone.Domain.csproj
```

---

## Planned Features

- [ ] User Registration & Login (JWT Authentication)
- [ ] Post Tweets (max 280 characters)
- [ ] Like, Retweet, and Bookmark tweets
- [ ] Follow / Unfollow users
- [ ] User Feed (tweets from followed users)
- [ ] Direct Messages (DMs)
- [ ] Real-time Notifications (SignalR)
- [ ] Search users and tweets
- [ ] User profile with bio & profile picture
- [ ] Trending hashtags

---

## Contributing

This is a course project, but feedback and suggestions are welcome!

1. Fork the repository
2. Create a feature branch: `git checkout -b feature/your-feature`
3. Commit your changes: `git commit -m 'Add some feature'`
4. Push to the branch: `git push origin feature/your-feature`
5. Open a Pull Request: https://github.com/farisa5218/TwitterClone/pull/new/feature/your-feature

---

## License

This project is licensed under the MIT License — see the LICENSE file for details.

---

## Author

farisa5218 — https://github.com/farisa5218/TwitterClone

---

If you want this README translated to Bengali or further customized, tell me which parts to change.
