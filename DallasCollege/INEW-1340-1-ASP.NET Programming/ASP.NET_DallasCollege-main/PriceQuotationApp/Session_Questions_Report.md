# ASP.NET Core & Entity Framework Questions Session Report

## Overview

This report summarizes all unique questions asked during the programming session focused on ASP.NET Core, Entity Framework Core, and related web development concepts.

---

## Entity Framework Core & Database Concepts

### 1. Lambda Expressions and LINQ

**Question:** What does `m => m.Genre` mean and what is `m`?

- **Topic:** Lambda expression syntax in Entity Framework
- **Key Concepts:** Parameter representation, navigation properties, Include() method

### 2. Connection Strings and Dependency Injection

**Question:** Can you explain this code:

```json
{
  "ConnectionStrings": {
    "MovieContext": "Server=(localdb)\\mssqllocaldb;Database=Movies;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

And:

```csharp
builder.Services.AddDbContext<MovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieContext")));
```

- **Topic:** Configuration management and dependency injection setup
- **Key Concepts:** appsettings.json, connection strings, DbContext registration

### 3. Package Manager Console

**Question:** What is a package manager console?

- **Topic:** Entity Framework tools and commands
- **Key Concepts:** PMC vs .NET CLI, migration commands, development workflows

### 4. Entity Properties and Primary Keys

**Question:** `public int InvoiceId { get; set; }`

- **Topic:** C# property declarations and Entity Framework conventions
- **Key Concepts:** Auto-implemented properties, primary key conventions, backing fields

### 5. DbContext Functionality

**Question:** What does DbContext do in ASP.NET?

- **Topic:** Entity Framework Core architecture
- **Key Concepts:** Change tracking, connection management, CRUD operations, relationship management

### 6. DbSet Properties

**Question:** What does `public DbSet<Customer> Customers { get; set; } = null;` do?

- **Topic:** Entity-to-table mapping
- **Key Concepts:** DbSet functionality, nullable reference types, table mapping

---

## Quiz Questions (Multiple Choice)

### Database Migration Commands

**Question:** Which command creates the database and updates it to the most recent migration?

- Options: Update-Database, Create-Database, Add-Migration Initial, Add-Migration
- **Answer:** Update-Database

### Primary Key Conventions

**Question:** Which property would NOT be a primary key configured by convention?

- Options: CustomerId, CustomerID, CustomerKey, Id
- **Answer:** CustomerKey (doesn't follow EF naming conventions)

### DbContext Methods

**Question:** Which is a method of the DbContext class?

- Options: Add(), Update(), Delete(), SaveChanges()
- **Answer:** SaveChanges()

### Foreign Key Properties

**Question:** Which defines a foreign key property in an Invoice entity for Customer relationship?

- Options: CustomerId, InvoiceId, Customer (navigation), Invoice (self-reference)
- **Answer:** public int CustomerId { get; set; }

### Entity Operations

**Question:** Which adds a Customer object to the database?

- Options: Various combinations of Add() and SaveChanges()
- **Answer:** context.Customers.Add(c); context.SaveChanges();

### Dependency Injection Setup

**Question:** What does this Program.cs code do?

```csharp
builder.services.AddDbContext<CustomerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Customer")));
```

- Options: DI setup, SQL Server specification, connection string reading, all of above
- **Answer:** All of the above

### LINQ Queries

**Question:** Which returns a sorted list of Customer objects by LastName?

- Options: OrderBy(), SortBy(), OrderBy().ToList(), SortBy().ToList()
- **Answer:** context.Customers.OrderBy(c => c.LastName).ToList()

### Entity Retrieval

**Question:** Which returns a Customer object for a specified ID?

- Options: Find(id), FirstOrDefault(id), Filter(), Where()
- **Answer:** context.Customers.Find(id)

---

## Web Development Concepts

### 1. URL Slugs

**Question:** How can adding a slug to a URL make it more user-friendly?

- **Topic:** URL design and user experience
- **Key Concepts:** Content predictability, SEO benefits, user experience
- **Answer:** Makes it easier to predict page content

### 2. Routing Configuration

**Question:** What does this routing code do?

```csharp
builder.services.AddRouting(options => {
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
});
```

- **Topic:** ASP.NET Core routing configuration
- **Key Concepts:** URL formatting, SEO optimization, consistent URL structure
- **Answer:** Makes all URLs lowercase with trailing slashes

---

## Documentation and Resources

### Entity Framework Documentation

**Question:** Where can I find information about EF commands in ASP.NET documentation?

- **Resources Provided:**
  - Package Manager Console commands: https://learn.microsoft.com/en-us/ef/core/cli/powershell
  - .NET CLI commands: https://learn.microsoft.com/en-us/ef/core/cli/dotnet
  - Getting Started guides and tutorials
  - Migration documentation

---

## Key Learning Areas Covered

1. **Entity Framework Core Fundamentals**

   - DbContext and DbSet concepts
   - Primary key and foreign key conventions
   - Change tracking and SaveChanges()
   - Connection string management

2. **LINQ and Querying**

   - Lambda expressions
   - Method chaining (OrderBy, Where, Include)
   - Query execution (ToList, Find, FirstOrDefault)

3. **ASP.NET Core Configuration**

   - Dependency injection setup
   - Service registration
   - Configuration management

4. **Database Migrations**

   - Package Manager Console commands
   - Migration lifecycle
   - Database creation and updates

5. **Web Development Best Practices**
   - URL design and slugs
   - Routing configuration
   - SEO considerations

---

## Session Statistics

- **Total Unique Questions:** 15+ conceptual questions and explanations
- **Quiz Questions:** 10 multiple choice questions
- **Main Topics:** Entity Framework Core, ASP.NET Core, Database Design, Web Development
- **Focus Areas:** Practical implementation, best practices, troubleshooting

---

_Report generated on September 26, 2025_
_Session focused on ASP.NET Core and Entity Framework Core development_
