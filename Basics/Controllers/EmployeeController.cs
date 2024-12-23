using Microsoft.AspNetCore.Mvc;
using Basics.Models;
namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1(){
            string message =$"Hello from Employee Controller.{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
            return View("Index1", message);
        }

        public ViewResult Index2()
        {
            var names = new string[]{
                "Omer",
                "Ahmet",
                "Fatih"
            };
            
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>
            {
                new Employee{Id=1, FirstName="Omer" ,LastName="Yildiz", Age=22},
                new Employee{Id=2, FirstName="Ahmet", LastName="Yildiz", Age=18},
                new Employee{Id=3, FirstName="Fatih", LastName="Yildiz", Age=13}
            };
            return View("Index3", list);
        }

    }
}
