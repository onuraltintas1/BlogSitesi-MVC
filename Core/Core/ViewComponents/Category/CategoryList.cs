using BAL.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.ViewComponents.Category;

public class CategoryList : ViewComponent
{
    private CategoryManager cm = new CategoryManager(new EfCategoryRepo());

    public IViewComponentResult Invoke()
    {
        return View(cm.GetList());
    }

}