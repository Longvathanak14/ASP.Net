using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Movie_App.Models;


namespace Movie_App.Controllers
{
    public class MovieController : Controller
    {
        //localhost:4000/Movie/Index

        [ActionName("List")]
        [HttpGet]
        public ViewResult Index()
        {
            ViewBag.movies = GetAllMovies();
            //ViewBag.movies = new Movie
            //{
                //Title = "The way of water.",
                //Description = "The way of water",
                //Genre = Genre.Action,
                //Id = Guid.NewGuid(),
                //ReleaseDate = new DateTime(2022, 12, 30)
            //};
            //ViewBag.Myname = "Chhinlong";
           // ViewBag.EX = new[] { 1, 2, 3, 4, 5, 6, 7 };

            ViewData["newName"] = "Seyla";
            ViewData["array"] = new[] { 1, 2, 3, 4, 5 };
            ViewData["mv"] = new Movie
            {
                Title = "Avatar",
                Description = "The way of the water",
                Genre = Genre.Science,
                Id = Guid.NewGuid(),
                ReleaseDate = new DateTime(2022, 12, 30)
            };
            ViewData["mvs"] = GetAllMovies();


            return View("Index");
            // ViewBag.movies = GetAllMovies();

           //return View("Index");
        //Content($"{movie_id}-{title}");
        }
        private Movie[] GetAllMovies()
        {
            var movies = new Movie[]
            {
                 new Movie
                {
                    Id=Guid.NewGuid(),
                    Title="Avata 1",
                    ReleaseDate=new DateTime(2002,10,20),
                    Genre=Genre.Action,
                    Description="Avata1"
                },
                new Movie
                {
                    Id=Guid.NewGuid(),
                    Title="Avata 2",
                    ReleaseDate=new DateTime(2003,10,20),
                    Genre=Genre.Action,
                    Description="Avata2"
                },
                new Movie
                {
                    Id=Guid.NewGuid(),
                    Title="Avata 3",
                    ReleaseDate=new DateTime(2004,10,20),
                    Genre=Genre.Action,
                    Description="Avata3"
                },
                new Movie
                {
                    Id=Guid.NewGuid(),
                    Title="Avata 4",
                    ReleaseDate=new DateTime(2005,10,20),
                    Genre=Genre.Action,
                    Description="Avata4"
                },
                new Movie
                {
                    Id=Guid.NewGuid(),
                    Title="Avata 5",
                    ReleaseDate=new DateTime(2006,10,20),
                    Genre=Genre.Action,
                    Description="Avata5"
                },
                new Movie
                {
                    Id=Guid.NewGuid(),
                    Title="Avata 6",
                    ReleaseDate=new DateTime(2007,10,20),
                    Genre=Genre.Action,
                    Description="Avata6"
                },
                new Movie
                {
                    Id=Guid.NewGuid(),
                    Title="Avata 2",
                    ReleaseDate=new DateTime(2008,10,20),
                    Genre=Genre.Action,
                    Description="Avata2"
                }

            };


            return movies;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ActionName("Create")]
        public IActionResult Store(string title,string description,decimal price)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            ViewBag.title = title;
            ViewBag.price = price;
            ViewBag.description = description; 
            return Redirect("/Movie/List");
            //return Redirect("/Movie/Index?movie_id=100&title=avatar2");
            //return RedirectToAction("Index", "Movie", new { movie_id = 100, title = "avatar2" });
        }

        public IActionResult Detail()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
