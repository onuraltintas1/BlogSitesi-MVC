using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Message
{
    [Key]
    public int Id { get; set; }
    public string Sender { get; set; }
    public string Receiver { get; set; }
    public string Subject { get; set; }
    public string Details { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public bool Status { get; set; }
}