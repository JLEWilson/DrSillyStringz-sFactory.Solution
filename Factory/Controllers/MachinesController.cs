using Microsoft.AspNetCore.Mvc;
using Factory.Models;

namespace Factory.Controllers
{
    public class MachinesController : Controller
    {
      public readonly FactoryContext _db;

      public MachinesController(FactoryContext db)
      {
        _db = db;
      }
      public ActionResult Index()
      {
        return View(_db.Machines);
      }

    }
}