using BAL.Concrete;
using DAL.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

public class ContactController : Controller
{
    private ContactManager cm = new ContactManager(new EfContactRepo());
    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Contact p)
    {
        p.Status = true;
        cm.ContactAdd(p);
        return View("Index","Blog");
    }
}