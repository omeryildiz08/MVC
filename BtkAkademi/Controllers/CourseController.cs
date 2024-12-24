using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {

        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
        public IActionResult Apply()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm]Candidate model)
        {
            if(Repository.Applications.Any(x => x.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("", "This email is already registered");
            }
            
            if(ModelState.IsValid) 
            {
            Repository.Add(model);
            return View("Feedback", model);
            }
            else
            {
                return View();
            }
           
        }
    }
}

    
