using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class About
{
    [Key]
    public int ID { get; set; }
    public string Details1 { get; set; }
    public string Details2 { get; set; }
    public string Image1 { get; set; }
    public string Image2 { get; set; }
    public int MapLocation  { get; set; }
    public bool Status { get; set; }

}