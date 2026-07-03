# Understanding ORM with EF Core

## What is ORM?

ORM (Object Relational Mapping) is a technique that maps C# classes to database tables. It allows developers to work with objects instead of writing SQL queries directly.

### Benefits of ORM

* Improved productivity
* Better maintainability
* Reduced SQL code
* Easier database operations

## EF Core vs EF Framework

### EF Core

* Cross-platform
* Lightweight
* Supports LINQ
* Supports asynchronous queries
* Supports modern .NET versions

### EF Framework (EF6)

* Windows-only
* More mature
* Less flexible than EF Core

## EF Core 8 Features

* JSON column mapping
* Improved performance
* Compiled models
* Interceptors
* Better bulk operations

## Commands Used

dotnet new console -n RetailInventory

dotnet add package Microsoft.EntityFrameworkCore

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Design