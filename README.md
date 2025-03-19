# Recipe Management System (Backend)

## 📌 Overview
This is the **backend API** for the Recipe Management System, built using **ASP.NET Core** and **Entity Framework Core**. It provides RESTful endpoints for managing recipes, including operations to **add, update, delete, and fetch recipes** from an SQL database.

## 🛠️ Technologies Used
- **ASP.NET Core** (Backend Framework)
- **Entity Framework Core** (ORM for Database Interaction)
- **SQL Server** (Database)
- **C#** (Programming Language)

## 📂 Folder Structure
```
CrudApi/
│── Controllers/
│   ├── RecipeController.cs    # API Controller for handling requests
│── Data/
│   ├── AppDbContext.cs        # EF Core database context
│   ├── SeedData.cs            # Initial data seeding
│── Migrations/
│   ├── [Migration Files]      # EF Core migration files
│── Models/
│   ├── Recipe.cs              # Recipe model class
│── Properties/
│── appsettings.json           # Application configuration
│── Program.cs                 # Entry point
│── Startup.cs                 # Configurations & middleware
│── setup.sql                  # SQL setup script (if applicable)
│── README.md                  # Project documentation
```

## 🛠️ Installation & Setup
### 1️⃣ Clone the Repository
```sh
https://github.com/DhirajSah736/CrudApi.git
cd CrudApi
```

### 2️⃣ Set Up Database Connection
Update the **appsettings.json** file with your SQL Server connection string:
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=DATABASE_NAME;Integrated Security=True;Encrypt=False;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
Make sure to replace:
- `DATABASE_NAME` → The name of your database

### 3️⃣ Run Database Migrations
To apply migrations and create the database, run:
```sh
dotnet ef migrations add InitialCreate
```
Then update the database:
```sh
dotnet ef database update
```

### 4️⃣ Run the Application
```sh
dotnet run
```
The API should now be running at `http://localhost:5032/` (or your configured port).

## 🔗 API Endpoints
| Method | Endpoint             | Description              |
|--------|----------------------|--------------------------|
| GET    | `/api/recipes`       | Get all recipes         |
| GET    | `/api/recipes/{id}`  | Get a single recipe     |
| POST   | `/api/recipes`       | Add a new recipe        |
| PUT    | `/api/recipes/{id}`  | Update a recipe         |
| DELETE | `/api/recipes/{id}`  | Delete a recipe         |





