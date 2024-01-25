using System.ComponentModel.DataAnnotations;

namespace CodeFirst;

public class Category
{
    [Key]
    public int Id { get; set; }
    
    [Required, MaxLength(50), RegularExpression("^[A-Z][a-z]+$")]
    public string Name { get; set; }
    
    // public ICollection<Product> Products { get; set; } 
}