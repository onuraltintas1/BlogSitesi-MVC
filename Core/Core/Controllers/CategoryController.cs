using BAL.Abstract;
using BAL.Concrete;
using DAL.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

public class CategoryController : Controller
{
    private CategoryManager cm = new CategoryManager(new EfCategoryRepo());
    
    public IActionResult Index()
    {
        return View( cm.GetList());
    }

    
}