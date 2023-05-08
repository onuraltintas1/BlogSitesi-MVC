using BAL.Concrete;
using BAL.Validators;
using DAL.Abstract;
using DAL.Context;
using DAL.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Core.Controllers;
[AllowAnonymous]
public class BlogController : Controller
{
    private readonly BlogManager bm = new BlogManager(new EfBlogRepo());
    private readonly IBlogRepo _repo = new EfBlogRepo();
    public IActionResult Index()
    {
        return View(bm.GetBlogWithCategory());
    }

    public IActionResult BlogReadAll(int id)
    {
        ViewBag.i = id;
        return View(bm.GetBlogById(id));
    }

    public IActionResult BlogListByWriter()
    {
        
        return View(bm.Test(1));
    }
    [HttpGet]
    public IActionResult BlogAdd()
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepo());
        List<SelectListItem> categoryvalues = (from x in cm.GetList()
            select new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.Id.ToString()
            }).ToList();
        ViewBag.cv = categoryvalues;
        return View();
    }
    [HttpPost]
    public IActionResult BlogAdd(Blog p)
    {
        BlogValidator bv = new BlogValidator();
        ValidationResult result = bv.Validate(p);
        
        if (result.IsValid)
        {
            p.Status = true;
            p.WriterId = 1;
            bm.TAdd(p);
            return RedirectToAction("BlogListByWriter", "Blog");
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
    
    public IActionResult DeletePost(int id)
    {
        var removeid = bm.GetById(id);
        bm.TDelete(removeid);
        return RedirectToAction("BlogListByWriter" , "Blog");
    }
    [HttpPost]
    public IActionResult UpdatePost(Blog p)
    {
        bm.TUpdate(p);
        
        return RedirectToAction("BlogListByWriter" , "Blog");
    }
    [HttpGet]
    public IActionResult UpdatePost(int id)
    {
        var updateBlog = bm.GetById(id);
        return View(updateBlog);
    }

}