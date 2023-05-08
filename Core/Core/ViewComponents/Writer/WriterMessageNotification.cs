using BAL.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.ViewComponents.Writer;

public class WriterMessageNotification : ViewComponent
{
    private WriterManager cm = new WriterManager(new EfWriterRepo());
    
    public IViewComponentResult Invoke()
    {
        return View();
    }
}