using BAL.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.ViewComponents.Writer;

public class WriterAboutOnDash : ViewComponent
{
    private WriterManager wm = new WriterManager(new EfWriterRepo());
    
    public IViewComponentResult Invoke()
    {
        return View(wm.GetWriterById(1));
    }
}