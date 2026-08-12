# TwitterClone

A lightweight Twitter-like microblogging application implemented with .NET 10.

This repository contains the code for a small-scale social feed service intended for learning and experimentation with modern .NET patterns.

Key ideas
- Domain-driven design with a clear separation between Domain, Application, Infrastructure, and Presentation layers
- Basic features: users, posts (tweets), follow/unfollow, likes, and timelines

Prerequisites
- .NET 10 SDK: https://dotnet.microsoft.com/
- Visual Studio 2026 (recommended) or any code editor that supports .NET development

Quick start (CLI)
1. Restore and build the solution

   dotnet restore
   dotnet build

2. Run the web project (replace <WebProjectPath> with your web project's path if different)

   dotnet run --project <WebProjectPath>

3. Run tests

   dotnet test

Using Visual Studio
1. Open the solution file: TwitterClone.slnx
2. Set the appropriate startup project (web API or frontend) and run (F5)

Project structure (example)
- TwitterClone.Domain  -- core entities and domain logic
- TwitterClone.Application -- business rules and application services
- TwitterClone.Infrastructure -- data access and external integrations
- TwitterClone.Web -- API or UI project
- TwitterClone.Tests -- unit and integration tests

Contributing
- Use feature branches and open a pull request against the main branch
- Follow consistent naming like feature/..., fix/..., chore/...

License
This project is provided under the MIT License. Update the LICENSE file as appropriate.

Contact
- Repository: https://github.com/farisa5218/TwitterClone
