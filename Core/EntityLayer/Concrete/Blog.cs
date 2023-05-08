using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Blog
{    
    [Key]
    public int BlogID { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public string? Image { get; set; }
    public string? ThumbnailImage { get; set; }
    public bool Status { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    
    public int? CategoryID { get; set; }
    public Category? Category { get; set; }

    public int? WriterId { get; set; }
    public Writer? Writer { get; set; }

    public List<Comment> Comments { get; set; }
}