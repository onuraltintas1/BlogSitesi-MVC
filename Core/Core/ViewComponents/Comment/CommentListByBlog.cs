using BAL.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.ViewComponents.Comment;

public class CommentListByBlog : ViewComponent
{
    private CommentManager cm = new CommentManager(new EfCommentRepo());
    
    public IViewComponentResult Invoke(int id)
    {
        return View(cm.GetList(id));
    }
}