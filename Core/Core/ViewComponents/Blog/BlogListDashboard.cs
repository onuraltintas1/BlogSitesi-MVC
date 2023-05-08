using BAL.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.ViewComponents.Blog;

public class BlogListDashboard : ViewComponent
{
    private readonly BlogManager bm = new BlogManager(new EfBlogRepo());

    public IViewComponentResult Invoke()
    {
        return View(bm.GetBlogWithCategory());
    }
}