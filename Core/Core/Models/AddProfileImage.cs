namespace Core.Models;

public class AddProfileImage
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string About { get; set; }
    public IFormFile Image { get; set; }
    public string Mail { get; set; }
    public string Password { get; set; }
    public bool WriterStatus { get; set; }
}