# .NET Core Backend Template

A clean architecture template for building scalable .NET Core backend applications.

Made with ❤️ by Otherside

## Tech Stack

- **.NET 8.0**: Latest version of .NET Core framework
- **MongoDB**: NoSQL database for data persistence
- **Clean Architecture**: Domain-driven design with clear separation of concerns
  - `Domain`: Business entities and contracts
  - `Application`: Use cases and business logic
  - `Infrastructure`: External concerns and implementations
  - `API`: Controllers and configuration

## Project Structure

```
├── src                    # Source code
│   ├── API               # Web API layer
│   │   ├── Controllers   # API endpoints
│   │   └── Program.cs    # Application configuration
│   ├── Application       # Application layer
│   │   └── Use_Cases     # Business logic use cases
│   ├── Domain            # Domain layer
│   │   ├── Contracts     # Interfaces/contracts
│   │   └── Entities      # Domain entities
│   └── Infrastructure    # Infrastructure layer
│       ├── Services      # Application services
│       └── Persistence   # Database implementations
└── tests                 # Test projects (to be added)
```

## Prerequisites

- .NET 8.0 SDK
- MongoDB (running locally or accessible instance)

## Configuration

The application uses the following configuration in `appsettings.json`:

```json
{
  "MongoSettings": {
    "ConnectionString": "mongodb://admin:pass@localhost:27017",
    "DatabaseName": "example"
  }
}
```

## API Endpoints

### Users

#### Create User
- **Endpoint**: POST `/api/users`
- **Description**: Creates a new user
- **Request Body**:
  ```json
  {
    "name": "string",
    "lastName": "string",
    "email": "string",
    "phone": "string"
  }
  ```
- **Response**: 201 Created
  ```json
  {
    "id": "string (guid)",
    "name": "string",
    "lastName": "string",
    "email": "string",
    "phone": "string"
  }
  ```

## Development

1. Clone the repository
2. Update MongoDB connection string in `src/API/appsettings.json`
3. Run the project:
   ```bash
   dotnet run --project src/API/API.csproj
   ```
4. Access Swagger documentation at: `http://localhost:5276/swagger`

## Architecture

This template follows Clean Architecture principles:

1. **Domain Layer**: Contains business entities and contracts
   - No dependencies on other layers
   - Pure business logic

2. **Application Layer**: Contains use cases
   - Depends only on Domain layer
   - Implements business workflows

3. **Infrastructure Layer**: Contains implementations
   - Depends on Domain layer
   - Implements interfaces defined in Domain
   - Contains services that orchestrate use cases

4. **API Layer**: Entry point of the application
   - Depends on all other layers
   - Handles HTTP requests/responses
   - Configures dependency injection

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request
