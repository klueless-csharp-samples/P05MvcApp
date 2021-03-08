namespace P05MvcApp.Controllers
{
  using Microsoft.AspNetCore.Mvc;

  public class Page1Controller : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

  }
}