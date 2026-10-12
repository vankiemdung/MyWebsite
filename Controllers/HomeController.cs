using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        // GET: /
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/About
        public IActionResult About()
        {
            return View();
        }

        // GET: /Home/Hobbies
        public IActionResult Hobbies()
        {
            // To add a photo: put the file in wwwroot/images/hobbies and add a line here.
            var photos = new List<Photo>
            {
                new Photo { FileName = "hobby1.jpg", Caption = "My first hobby" },
                new Photo { FileName = "hobby2.jpg", Caption = "My second hobby" },
                new Photo { FileName = "hobby3.jpg", Caption = "My third hobby" },
                new Photo { FileName = "hobby4.jpg", Caption = "My fourth hobby" },
            };
            return View(photos);
        }

        // GET: /Home/Family
        public IActionResult Family()
        {
            // To add a photo: put the file in wwwroot/images/family and add a line here.
            var photos = new List<Photo>
            {
                new Photo { FileName = "family1.jpg", Caption = "My family" },
                new Photo { FileName = "family2.jpg", Caption = "Family trip" },
                new Photo { FileName = "family3.jpg", Caption = "Holiday together" },
                new Photo { FileName = "family4.jpg", Caption = "Weekend at home" },
            };
            return View(photos);
        }

        // GET: /Home/Contact
        public IActionResult Contact()
        {
            return View();
        }

        // Shown when something goes wrong (outside Development)
        public IActionResult Error()
        {
            return View();
        }
    }
}
