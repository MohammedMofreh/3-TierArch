# 🧱 ASP.NET Core Project – Three-Layer Architecture

This project demonstrates a clean separation of concerns using the **Three-Layer Architecture** in ASP.NET Core.

## 📁 Structure Overview

Project.PL // Presentation Layer (UI/Controllers/Views)
└── Controllers
└── Views
└── ViewModels

Project.BLL // Business Logic Layer (Interfaces + Services)
└── Interfaces
└── Repositories

Project.DAL // Data Access Layer (EF Core Models & DbContext)
└── Models
└── Data (Configurations, Migrations, AppDbContext)


## 🔄 Technologies Used
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Repository Pattern
- Layered Architecture (PL / BLL / DAL)

## ✅ Features
- Department CRUD (Create, Read, Update, Delete)
- Separation of concerns
- Repository Interface in BLL
- ViewModels & strongly-typed Views
- EF Core Migrations handled in DAL layer

## 🧠 Why this architecture?

✅ **Maintainability** – Each layer has a single responsibility.  
✅ **Testability** – You can mock BLL interfaces easily for unit tests.  
✅ **Reusability** – Business logic is independent of web UI.  
✅ **Scalability** – You can replace the UI layer (e.g., Blazor, API) without affecting BLL/DAL.

---


