using BAL.Concrete;
using DAL.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace Core.Controllers;

public class CommentController : Controller
{
    private CommentManager cm = new CommentManager(new EfCommentRepo());
    
   

    [HttpPost]
    public PartialViewResult PartialAddComment(Comment p)
    {
        
        p.BlogID = 7;
        cm.CommentAdd(p);
        return PartialView();
    }
    [HttpGet]
    public PartialViewResult PartialAddComment()
    {
        return PartialView();
    }
   

    
}