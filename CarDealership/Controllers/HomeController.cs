using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController: Controller
  {
    [Route("/")]

    public ActionResult Index()
    {
    Car honda = new Car("CRV", 30, 2000, "2020");
    return View(honda);
    }
  }
}