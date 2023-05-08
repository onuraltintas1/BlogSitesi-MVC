using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

public class ErrorPageController : Controller
{
    // GET
    public IActionResult Error1(int code)
    {
        return View();
    }
}