using BAL.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

public class AboutController : Controller
{
    private AboutManager am = new AboutManager(new EfAboutRepo());
    
    public IActionResult Index()
    {
        return View(am.GetList());
    }
    public PartialViewResult SocialMediaAbout()
    {
        return PartialView();
    }

}