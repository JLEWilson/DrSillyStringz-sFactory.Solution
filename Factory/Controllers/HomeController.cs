using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{

  public class HomeController : Controller
  {
    public readonly FactoryContext _db;
    public HomeController(FactoryContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      var engineers =_db.Engineers.ToList();
      var machines =_db.Machines.ToList();
      ViewBag.Engineers = engineers;
      ViewBag.Machines = machines;
      return View();
    }
  }
}