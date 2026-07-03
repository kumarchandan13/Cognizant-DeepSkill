# Lab 1 - Understanding ORM with a Retail Inventory System

Status: ✅ Completed

Lab 1: Understanding ORM with a Retail Inventory System 
Scenario: 
You’re building an inventory management system for a retail store. The store wants to 
track products, categories, and stock levels in a SQL Server database. 
Objective: 
Understand what ORM is and how EF Core helps bridge the gap between C# objects and 
relational tables. 
Steps: 
1. What is ORM? 
• Explain how ORM maps C# classes to database tables. 
• Benefits: Productivity, maintainability, and abstraction from SQL. 
2. EF Core vs EF Framework: 
• EF Core is cross-platform, lightweight, and supports modern features like 
LINQ, async queries, and compiled queries. 
• EF Framework (EF6) is Windows-only and more mature but less flexible. 
3. EF Core 8.0 Features: 
• JSON column mapping. 
• Improved performance with compiled models. 
• Interceptors and better bulk operations. 
4. Create a .NET Console App: 
dotnet new console -n RetailInventory 
cd RetailInventory 
5. Install EF Core Packages: 
dotnet add package Microsoft.EntityFrameworkCore.SqlServer 
dotnet add package Microsoft.EntityFrameworkCore.Design

This folder will contain the complete solution for Lab 1 of the Cognizant Digital Nurture – .NET FSE Deepskilling Program.