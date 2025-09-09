using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class Quotation
    {
        // -----------------------------
        // Property: Subtotal
        // -----------------------------
        // TODO:
        // - Type: decimal? (nullable decimal, good for money values)
        // - Add [Required] so user must enter it
        // - Add [Range] so value must be greater than 0
        // Learn: https://learn.microsoft.com/aspnet/core/mvc/models/validation
        // Murach: Ch.2 – “Model property with validation attributes” (slides)
        public decimal? Subtotal { get; set; }

        // -----------------------------
        // Property: DiscountPercent
        // -----------------------------
        // TODO:
        // - Type: decimal? 
        // - Add [Required] so user must enter it
        // - Add [Range] so value must be between 0 and 100
        // Learn: https://learn.microsoft.com/dotnet/api/system.componentmodel.dataannotations.rangeattribute
        // Murach: Ch.2 – “A model property with two validation attributes”
        public decimal? DiscountPercent { get; set; }


        // -----------------------------
        // Method: CalculateDiscount
        // -----------------------------
        // PSEUDOCODE:
        // if Subtotal has a value AND DiscountPercent has a value
        //     discount = Subtotal * (DiscountPercent / 100)
        //     round discount to 2 decimal places
        //     return discount
        // else
        //     return 0
        // Learn: Conditional logic (if/else)
        //   https://learn.microsoft.com/dotnet/csharp/language-reference/statements/selection-statements
        // Murach: Ch.2 – “Action method that checks for invalid data”
        public decimal CalculateDiscount()
        {
            // TODO: Replace pseudocode with real C#
            return 0m; // placeholder so code compiles
        }

        // -----------------------------
        // Method: CalculateTotal
        // -----------------------------
        // PSEUDOCODE:
        // if Subtotal has a value
        //     discount = call CalculateDiscount()
        //     total = Subtotal – discount
        //     round total to 2 decimal places
        //     return total
        // else
        //     return 0
        // Learn: Nullable types (HasValue)
        //   https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/nullable-value-types
        // Murach: Ch.1 – MVC pattern, model handles calculations
        public decimal CalculateTotal()
        {
            // TODO: Replace pseudocode with real C#
            return 0m; // placeholder so code compiles
        }
    }
}
