using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        // navigates to https://localhost/helloworld before the View was added
        /*public string Index()
        {
            return "This is the index page";
        }*/
        public IActionResult Index()
        {
            //return View();
            /* DogViewModel doggo = new DogViewModel()
            { Name="Sif", Age=2 };
            return View(doggo);*/
            return View(dogs);
        }

        // // navigates to https://localhost/helloworld/hello
        public IActionResult Hello()
        {
            DogViewModel frankie = new DogViewModel()
            { Name="Frankie", Age=3 };
            return View(frankie);
        }
        
        // need to tell the Create page which model is used in this page, so we create a new dog view model
        public IActionResult Create()
        {   
            // use clean view model to fill out the form and then send it back to create
            var dogVm = new DogViewModel();
            // inside of this view, we have the form
            return View(dogVm);
        }

        // now we fill out the form and click on submit and we get to CreateDog
        // then check if we have dogViewModel data, which we entered in the form
        // next, we get redirected to the index page, which is the listing of all the dogs that we have
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            // add each dog to the list
            dogs.Add(dogViewModel);
            //return View("Index");
            // redirect to the IactionResult Index and call its syntax
            return RedirectToAction(nameof(Index));
        }

        public string Anotherpage()
        {
            return "Another page";
        }
    }
}