using System.Security.Claims;
using DAL.Context;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

public class LoginController : Controller
{
    [AllowAnonymous]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Index(Writer p)
    {
        Context c = new Context();
        var dataValue = c.Writers.FirstOrDefault(x => x.Mail == p.Mail && x.Password == p.Password);
        if (dataValue != null)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, p.Mail)
            };
            var useridentity = new ClaimsIdentity(claims, "a");
            ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
            await HttpContext.SignInAsync(principal);
            return RedirectToAction("Index", "Writer");

        }
        else
        {
            return View();
        }
    }
}