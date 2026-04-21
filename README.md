This project is a User Management Web Application developed using ASP.NET Core MVC (.NET 8) with Entity Framework Core for database operations. It follows the MVC architecture with a layered design (DAL and PAL) to ensure scalability and maintainability. The application supports CRUD operations for managing user data and uses dependency injection for better code structure and flexibility.
UserHO/
│── Controllers/        # Handles user requests and application logic
│── Models/             # Defines data structures and entities
│── Views/              # UI components (Razor Views)
│── DAL/                # Data Access Layer for database operations
│── PAL/                # Presentation Layer for business logic separation
│── wwwroot/            # Static files (CSS, JS, images)
│── appsettings.json    # Configuration file
│── Program.cs          # Entry point of the application
│── Startup/Config      # Middleware and services configuration
