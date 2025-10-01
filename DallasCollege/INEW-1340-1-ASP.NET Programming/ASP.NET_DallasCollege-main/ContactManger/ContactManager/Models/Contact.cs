// Contact.cs
public class Contact
{
    public int ContactId { get; set; }
    public string Firstname { get; set; } = "";
    public string Lastname { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";

    public DateTime DateAdded { get; set; } // automatically set when added
    
    // FORIEGN KEY 
    public int CategoryId { get; set; }     // links to a Category
    public Category Category { get; set; } = null!;

    // Generates a URL-friendly string like "mary-walton"
    public string Slug => Firstname.ToLower() + "-" + Lastname.ToLower();
}