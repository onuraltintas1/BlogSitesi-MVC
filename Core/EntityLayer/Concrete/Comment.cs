using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Comment
{
    [Key]
    public int ID { get; set; }
    public string UserName { get; set; }        
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public int BlogScore { get; set; }
    
    
    public int BlogID { get; set; }
    public Blog Blog { get; set; }
}