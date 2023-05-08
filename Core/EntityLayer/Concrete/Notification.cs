using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Notification
{
    [Key]
    public int NotificationId { get; set; }
    public string NotificationType { get; set; }
    public string NotificationTypeSymbol { get; set; }
    public string NotificationDetails { get; set; }
    public string NotificationStatus { get; set; }
    public DateTime NotificationDate { get; set; } = DateTime.UtcNow;
}