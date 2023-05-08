using BAL.Concrete;
using BAL.Validators;
using DAL.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

public class RegisterController : Controller
{
    private WriterManager wm = new WriterManager(new EfWriterRepo());
    private WriterValidator wv = new WriterValidator();
    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Writer p )
    {
        ValidationResult result = wv.Validate(p);
        
        if (result.IsValid)
        {
            p.WriterStatus = true;
            p.About = "deneme";
            wm.TAdd(p);
            return RedirectToAction("Index", "Blog");
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
}