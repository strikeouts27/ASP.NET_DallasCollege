# DbSet Property Examples

## 📊 What is DbSet?

**DbSet** is a property in your DbContext that represents a table in your database. Here are some examples:

## 🎯 Basic DbSet Example

```csharp
public class PriceQuotationContext : DbContext
{
    // This DbSet represents the "Quotations" table
    public DbSet<Quotation> Quotations { get; set; }
}
```

## 🔍 What This Means

- **`DbSet<Quotation>`** = A collection of all Quotation records
- **`Quotations`** = The property name (becomes table name)
- **Each `Quotation` object** = One row in the table

## 💡 Multiple DbSet Examples

```csharp
public class SchoolContext : DbContext
{
    // Each DbSet becomes a table
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
}
```

## 🛠️ How You Use DbSet

```csharp
// In a controller:
public class QuotationController : Controller
{
    private readonly PriceQuotationContext _context;

    public QuotationController(PriceQuotationContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        // Use the DbSet to query data
        var allQuotations = _context.Quotations.ToList();

        // Filter data
        var highValueQuotes = _context.Quotations
            .Where(q => q.Subtotal > 1000)
            .ToList();

        return View(allQuotations);
    }
}
```

## 🎯 DbSet Operations

```csharp
// ADD new record
_context.Quotations.Add(newQuotation);

// FIND by ID
var quote = _context.Quotations.Find(5);

// UPDATE (just modify the object)
quote.Subtotal = 250.00m;

// DELETE
_context.Quotations.Remove(quote);

// SAVE all changes
_context.SaveChanges();
```

## 🔑 Key Points

- **DbSet = Table** in your database
- **Object = Row** in that table
- **Property = Column** in that table
- **LINQ queries** work directly on DbSet properties

Think of DbSet as a **C# collection** that's magically connected to your database!

## 📚 Additional Notes

### Entity Framework Core Workflow:

1. **Define Models** (like your `Quotation.cs`)
2. **Create DbContext** with DbSet properties
3. **Register DbContext** in `Program.cs`
4. **Use in Controllers** to query/save data
5. **Entity Framework** handles SQL generation automatically

### Common DbSet Methods:

- `.Add()` - Insert new record
- `.Find(id)` - Find by primary key
- `.Where()` - Filter records
- `.FirstOrDefault()` - Get first match or null
- `.ToList()` - Execute query and get list
- `.Remove()` - Delete record
- `.SaveChanges()` - Commit all changes to database
