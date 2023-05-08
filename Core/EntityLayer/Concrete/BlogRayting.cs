using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class BlogRayting
{
    [Key]
    public int RaytingId { get; set; }
    public int BlogId { get; set; }
    public int TotalScore { get; set; }
    public int RaytingCount { get; set; }
}