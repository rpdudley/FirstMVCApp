using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        //add static for new element 
        private static List<PersonViewModel> people = new List<PersonViewModel>();
        public IActionResult Index()
        {
            //PersonViewModel person = new PersonViewModel() 
          //{ Name = "Ryan", Age=22 };
            return View(people);

        }
        //This Iaction method returns the form using PersonViewModel it creates a new form everytime you hit submit 
        public IActionResult Create()
        {
            var personVm = new PersonViewModel();
            return View(personVm);

        }
        //Sends data to CreateForm 
        //This Iaction gets called when you submit the form 
        public IActionResult CreateForm(PersonViewModel personViewModel) 
        {
            
            people.Add(personViewModel);
            return RedirectToAction(nameof(Index));
        
        }
        public string Hello()
        {
            return "Hello Ryan!";
        }

           
    }
}
