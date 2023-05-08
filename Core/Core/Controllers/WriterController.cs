using BAL.Concrete;
using BAL.Validators;
using Core.Models;
using DAL.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;
[Authorize]
public class WriterController : Controller
{
    private readonly WriterManager wm = new WriterManager(new EfWriterRepo());

    public IActionResult Index()
    {
        return View();
    }

  
    public IActionResult WriterMail()
    {
        return View();
    }
    [AllowAnonymous]
    public IActionResult Test()
    {
        return View();
    }
    
    [AllowAnonymous]
    public PartialViewResult WriterNavbarPartial()
    {
        return PartialView();
    }
     
    [AllowAnonymous]
    public PartialViewResult WriterFooterPartial()
    {
        return PartialView();
    }
   
    [AllowAnonymous]
    [HttpGet]
    public IActionResult WriterEditProfile()
    {
        return View(wm.GetById(1));
    }
    [AllowAnonymous]
    [HttpPost]
    public IActionResult WriterEditProfile(Writer p)
    {
        WriterValidator wl = new WriterValidator();
        ValidationResult result = wl.Validate(p);
        if (result.IsValid)
        {
            p.Image = "dasdsa"; //kaldırılıcak bu data'da null olabilir demedim diye 
            wm.TUpdate(p);
            return RedirectToAction("Index", "Dashboard");
        }
        else
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
            }
        }
        return View();
    }

    [AllowAnonymous]
    [HttpGet]
    public IActionResult WriterAdd()
    {
        return View();
    }
    [AllowAnonymous]
    [HttpPost]
    public IActionResult WriterAdd(AddProfileImage p)
    {
        Writer w = new Writer();
        if (p.Image !=null)
        {
            var extension = Path.GetExtension(p.Image.FileName);
            var newImageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
            var stream = new FileStream(location, FileMode.Create);
            p.Image.CopyTo(stream);
            w.Image = newImageName;
        }

        w.Mail = p.Mail;
        w.Name = p.Name;
        w.Password = p.Password;
        w.About = p.About;
        w.WriterStatus = true;
        wm.TAdd(w);
        return RedirectToAction("Index", "Dashboard");
    }
}