## 💄 FateMakeup API (ASP.NET Core 9 + EF Core)

Find your Holy Grail ...

The FateMakeup API is a practice project built to learn and explore ASP.NET Core 9 Web API development with Entity Framework Core. It demonstrates how to create and manage CRUD operations for makeup products, using SQL Server for persistence.
API testing was done through OpenAPI and Scalar.

## 📌 Features

- Practice project for learning Web API development
- CRUD operations (Create, Read, Update, Delete) for makeup items
- Built with ASP.NET Core 9 and Entity Framework Core
- Integrated with SQL Server
- Interactive API testing with Swagger / OpenAPI

## 📖 API Endpoints

| Method | Endpoint            | Description                     |
|--------|---------------------|---------------------------------|
| GET    | `/api/makeup`       | Get all makeup items            |
| GET    | `/api/makeup/{id}`  | Get a makeup item by ID         |
| POST   | `/api/makeup`       | Create a new makeup item        |
| PUT    | `/api/makeup/{id}`  | Update an existing makeup item  |
| DELETE | `/api/makeup/{id}`  | Delete a makeup item by ID      |


Example Request (POST)
{
  "name": "Hydrating Lip Gloss",
  "brand": "Fenty Beauty",
  "category": "Lips",
  "description": "A non-sticky, high-shine lip gloss infused with shea butter for moisture."
}

## 📌 Tech Stack

- ASP.NET Core 9 Web API
- Entity Framework Core 9
- SQL Server Express
- OpenAPI

## 🛠️ Future Improvements

- Add Authentication & Authorization (JWT)
- Implement Repository & Service layers
- Add Pagination & Filtering
- Deploy to Azure or Docker
