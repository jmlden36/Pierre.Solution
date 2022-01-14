using System.Linq;
using System.Collections.Generic;
using Pierre.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Pierre.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierreContext _db;
    public HomeController(PierreContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Treat> treats = _db.Treats.ToList();
      ViewData.Add("treats", treats);
      List<Flavor> flavors = _db.Flavors.ToList();
      ViewData.Add("flavors", flavors);
      return View();
    }
  }
}