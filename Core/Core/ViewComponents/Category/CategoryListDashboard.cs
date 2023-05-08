using BAL.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.ViewComponents.Category;

public class CategoryListDashboard : ViewComponent
{
    private CategoryManager cm = new CategoryManager(new EfCategoryRepo());

    public IViewComponentResult Invoke()
    {
        return View(cm.GetList());
    }
}