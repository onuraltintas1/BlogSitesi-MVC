using BAL.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.ViewComponents.Writer;

public class WriterNotification : ViewComponent
{
    private readonly NotificationManager nm = new NotificationManager(new EfNotificationRepo());

    public IViewComponentResult Invoke()
    {
        return View(nm.GetList());
    }
}