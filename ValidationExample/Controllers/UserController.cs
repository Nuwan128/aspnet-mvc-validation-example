using Microsoft.AspNetCore.Mvc;
using ValidationExample.Models;

namespace ValidationExample.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SubmitForm(UserViewModel model)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View(model);
    }
    public IActionResult Success()
    {
        return View();
    }
}
