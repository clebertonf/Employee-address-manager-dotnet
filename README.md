# Employee Address Manager

An API for managing employees and their addresses, built with clean architecture principles.

## Features

- Manage **Employees**:
    - Add, update, retrieve, and delete employees.
- Manage **Addresses**:
    - Add, update, retrieve, and delete addresses.
- Clean architecture with a layered project structure.
- Ready-to-use Swagger documentation for testing endpoints.

---

## Project Structure

```
Employee-address-manager
├── EmployeeAddressManager.API            # API Layer
├── EmployeeAddressManager.Application    # Application Logic
├── EmployeeAddressManager.Domain         # Domain Entities
├── EmployeeAddressManager.Infra.Data     # Data Access Layer
├── EmployeeAddressManager.Infra.IoC      # Dependency Injection
├── EmployeeAddressManager.Tests          # Unit Tests
```

---

## Technologies

- .NET 7
- Entity Framework Core
- AutoMapper
- Swagger UI
- Dependency Injection
- xUnit (for tests)

---

## Endpoints

### Address Endpoints

| Method | Endpoint              | Description       |
|--------|-----------------------|-------------------|
| GET    | `/api/addresses`      | List all addresses |
| POST   | `/api/addresses`      | Add a new address |
| GET    | `/api/addresses/{id}` | Get an address by ID |
| PUT    | `/api/addresses/{id}` | Update an address by ID |
| DELETE | `/api/addresses/{id}` | Delete an address by ID |

### Employee Endpoints

| Method | Endpoint              | Description       |
|--------|-----------------------|-------------------|
| GET    | `/api/employees`      | List all employees |
| POST   | `/api/employees`      | Add a new employee |
| GET    | `/api/employees/{id}` | Get an employee by ID |
| PUT    | `/api/employees/{id}` | Update an employee by ID |
| DELETE | `/api/employees/{id}` | Delete an employee by ID |

---

## Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- A database (e.g., SQL Server, PostgreSQL, or SQLite)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/employee-address-manager.git
   cd employee-address-manager
   ```

2. Navigate to the API project:
   ```bash
   cd EmployeeAddressManager.API
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

5. Access Swagger UI:
   Open your browser and go to `http://localhost:5233/swagger`.

---

## Configuration

### Database Setup

1. Update the connection string in `appsettings.json` under the `EmployeeAddressManager.Infra.Data` project:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Your-Database-Connection-String"
   }
   ```

2. Apply migrations:
   ```bash
   dotnet ef database update --project EmployeeAddressManager.Infra.Data
   ```

---

## Testing

Run unit tests with:
```bash
cd EmployeeAddressManager.Tests

dotnet test
```

---

## Swagger Documentation

Swagger UI is available at:
```
http://localhost:5233/swagger
```
Use it to explore and test all the API endpoints interactively.

---

## Contributing

Feel free to open issues or submit pull requests for any bugs, improvements, or new features. All contributions are welcome!

---

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.