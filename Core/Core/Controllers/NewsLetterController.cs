using BAL.Concrete;
using DAL.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

public class NewsLetterController : Controller
{
    private NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepo());
    
    [HttpGet]
    public PartialViewResult SubscribeMail()
    {
        return PartialView();
    }
    [HttpPost]
    public PartialViewResult SubscribeMail(NewsLetter p)
    {
        p.Status = true;
        nm.AddNewsLetter(p);
        return PartialView();
    }
}