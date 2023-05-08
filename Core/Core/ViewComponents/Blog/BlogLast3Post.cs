using BAL.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.ViewComponents.Blog;

public class BlogLast3Post : ViewComponent
{
    private readonly BlogManager bm = new BlogManager(new EfBlogRepo());

    public IViewComponentResult Invoke()
    {
        return View(bm.GetLast3Blog());
    }
}