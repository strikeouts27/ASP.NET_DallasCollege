using Microsoft.EntityFrameworkCore;

public class ContactContext : DbContext
{
    public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }

    public DbSet<Contact> Contacts { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed Categories
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Family" },
            new Category { CategoryId = 2, Name = "Friend" },
            new Category { CategoryId = 3, Name = "Work" },
            new Category { CategoryId = 4, Name = "Other" }
        );

        // Seed one Contact
        modelBuilder.Entity<Contact>().HasData(
            new Contact {
                ContactId = 1,
                Firstname = "Mary",
                Lastname = "Walton",
                Phone = "555-123-4567",
                Email = "mary@example.com",
                CategoryId = 1,
                DateAdded = DateTime.Now
            }
        );
    }
}
