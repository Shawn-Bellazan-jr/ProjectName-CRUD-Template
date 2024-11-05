
## What would you like Copilot to know about you to provide better suggestions?

I am working on a .NET-based project in Visual Studio, designed as a robust, scalable CRUD application following modern software architecture best practices. The project is a microservices-friendly monolithic structure with distinct projects:
- **Shared**: Contains common models and interfaces.
- **API**: Backend services and controllers using the Repository and Unit of Work patterns with Entity Framework Core.
- **Client**: A Blazor-based frontend that communicates with the API via HttpClient.
- **Components**: Reusable Blazor components, including a generic CRUD component.

The application uses dependency injection, data annotations for validation, and is structured to be easily customizable and extendable. My primary goal is to create reusable, maintainable code for CRUD operations across entities.

## How would you like Copilot to respond?

Please provide code suggestions that follow .NET best practices, clean coding principles, and align with my project structure.
- For backend suggestions, prioritize patterns like Repository and Unit of Work.
- For Blazor components, provide code that incorporates state management, uses `StateHasChanged` when necessary, and adheres to Blazor’s lifecycle and event handling.
- When suggesting API calls in Blazor, use async/await patterns with HttpClient.
- Add brief comments where necessary to explain architectural decisions, especially in areas like dependency injection, Entity Framework integration, and Blazor component lifecycle events.

Prioritize clarity and maintainability in all suggestions.

---

## Usage

These instructions are intended to guide GitHub Copilot to provide better code completions and suggestions that align with the architectural patterns and technologies used in this project.

1. **Backend Development**: Copilot will assist with Repository and Unit of Work patterns, using Entity Framework and Dependency Injection.
2. **Blazor Components**: Suggestions will focus on state management and async API calls with `HttpClient`, following best practices for Blazor applications.
3. **Client-Server Integration**: Ensure consistency and clarity across service layers, facilitating a seamless integration between the API and Blazor frontend.
