using EmployeeData.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeData.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View(new calc());
        }

        [HttpPost]
        public ActionResult Index(calc c, string calculate)
        {
            if (calculate == "add")
            {
                c.result = c.num1 + c.num2;
            }
            else if (calculate == "min")
            {
                c.result = c.num1 - c.num2;
            }
            else if (calculate == "sub")
            {
                c.result = c.num1 * c.num2;
            }
            else if (calculate == "div")
            {
                c.result = c.num1 / c.num2;
            }
            return View(c);
        }
    }
}
